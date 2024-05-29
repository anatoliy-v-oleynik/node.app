using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace NodeServer
{
    public partial class MainForm : Form
    {
        private class UdpConnectionInfo
        {
            public EndPoint EndPoint;
            public byte[] Buffer;
            public DataGridViewRow Row;

            public UdpConnectionInfo()
                :this(new IPEndPoint(IPAddress.Any, 0), new byte[255])
            {

            }

            public UdpConnectionInfo(EndPoint ep, byte[] buffer)
            {
                EndPoint = ep;
                Buffer = buffer;
            }
        }

        private List<UdpConnectionInfo> clients = new List<UdpConnectionInfo>();
        private Socket socket;
        private System.Threading.Timer timer;
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("ON_LOAD");
        }

        private void DoReceiveFrom(IAsyncResult result)
        {
            UdpConnectionInfo connection = (UdpConnectionInfo)result.AsyncState;
            try
            {
                int bytesRead = socket.EndReceiveFrom(result, ref connection.EndPoint);
                
                if (!clients.Any(client => client.EndPoint.Equals(connection.EndPoint)))
                {
                    this.Invoke(new Action(() =>
                    {
                        connection.Row = this.dataGridView.Rows[this.dataGridView.Rows.Add(new string[2] { connection.EndPoint.ToString(), "" })];
                        clients.Add(connection);
                    }));
                }
                else
                {
                    connection.Row = clients.Find(client => client.EndPoint.Equals(connection.EndPoint)).Row;
                }

                counter++;

                if (bytesRead != 0)
                {
                    byte[] sendBuffer = null;

                    byte[] buffer = new byte[bytesRead];
                    Array.Copy(connection.Buffer, buffer, bytesRead);

                    string command = Encoding.UTF8.GetString(buffer);
                    switch (command)
                    {
                        case "HANDSHAKE":
                            sendBuffer = Encoding.UTF8.GetBytes("HANDSHAKE-" + connection.EndPoint.ToString());
                            socket.SendTo(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, connection.EndPoint);
                            break;
                    }

                    connection.Row.Cells[1].Value = command + "-" + Convert.ToInt32(counter);
                }
                else
                {
                    connection.Row.Cells[1].Value = "";
                }
            }
            finally
            {
                UdpConnectionInfo newConnection = new UdpConnectionInfo();
                socket.BeginReceiveFrom(newConnection.Buffer, 0, newConnection.Buffer.Length, SocketFlags.None, ref newConnection.EndPoint, DoReceiveFrom, newConnection);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (startCheckBox.Checked)
            {
                try
                {
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    socket.Bind(new IPEndPoint(IPAddress.Any, Convert.ToInt32(portTextBox.Text)));

                    UdpConnectionInfo connection = new UdpConnectionInfo();
                    socket.BeginReceiveFrom(connection.Buffer, 0, connection.Buffer.Length, SocketFlags.None, ref connection.EndPoint, DoReceiveFrom, connection);

                    startCheckBox.ImageIndex = 0;

                    nodeCheckBox.Enabled = false;
                    portTextBox.Enabled = false;

                }
                catch
                {
                    startCheckBox.ImageIndex = 1;
                }
                finally
                {

                }
            }
            else
            {
                socket.Close();
                socket = null;
                clients.Clear();

                startCheckBox.ImageIndex = 1;

                nodeCheckBox.Enabled = true;
                portTextBox.Enabled = true;
            }
        }

        private void nodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nodeCheckBox.Checked)
            {
                portTextBox.Text = "5500";
            }
            else
            {
                portTextBox.Text = "3478";
            }
        }

        private void loopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loopCheckBox.Checked)
            {
                timer = new System.Threading.Timer(s =>
                {
                    IPEndPoint ep = new IPEndPoint(IPAddress.Parse(sendAddressTextBox.Text), Convert.ToInt32(sendPortTextBox.Text));
                    byte[] buffer = Encoding.UTF8.GetBytes(loopDataTextBox.Text);
                    socket.SendTo(buffer, 0, buffer.Length, SocketFlags.None, ep);
                }, null, 0, 1000);

            }
            else
            {
                this.timer.Dispose();
            }
        }

        private void sendDataButton_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(sendAddressTextBox.Text), int.Parse(sendPortTextBox.Text));
            byte[] buffer = Encoding.UTF8.GetBytes(sendDataTextBox.Text);
            socket.SendTo(buffer, 0, buffer.Length, SocketFlags.None, ep);
        }
    }
}
