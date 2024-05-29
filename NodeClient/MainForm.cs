using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace NodeClient
{
    public partial class MainForm : Form
    {
        public enum MessageType
        {
            BindingRequest = 0x0001,
            SharedSecretRequest = 0x0002,

            BindingResponse = 0x0101,
            SharedSecretResponse = 0x0102,

            BindingErrorResponse = 0x0111,
            SharedSecretErrorResponse = 0x0112,
        }

        public enum ResultType
        {
            MappedAddress = 0x0001,
            ResponseAddress = 0x0002,
            ChangeRequest = 0x0003,
            SourceAddress = 0x0004,
            ChangedAddress = 0x0005,
            Username = 0x0006,
            Password = 0x0007,
            MessageIntegrity = 0x0008,
            ErrorCode = 0x0009,
            UnknownAttribute = 0x000A,
            ReflectedFrom = 0x000B,
            XorMappedAddress = 0x8020,
            XorOnly = 0x0021,
            ServerName = 0x8022,
        }

        private class UdpConnectionInfo
        {
            public EndPoint EndPoint;
            public byte[] Buffer;
            public DataGridViewRow Row;
            public DateTime LastAlive;

            public UdpConnectionInfo()
                : this(new IPEndPoint(IPAddress.Any, 0), new byte[255])
            {

            }

            public UdpConnectionInfo(EndPoint ep, byte[] buffer)
            {
                EndPoint = ep;
                Buffer = buffer;
            }
        }

        private IPEndPoint externalEndPoint;
        private List<UdpConnectionInfo> clients = new List<UdpConnectionInfo>();
        private Socket socket;
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private int SendBindingRequest(IPEndPoint ep)
        {
            //IPEndPoint ep = new IPEndPoint(System.Net.Dns.GetHostAddresses("stun1.l.google.com")[0], 19302);
            byte[] msg = new byte[512];
            int offset = 0;

            // Message Type (2 bytes)
            msg[offset++] = (byte)(0x0001 >> 8);
            msg[offset++] = (byte)(0x0001 & 0xFF);

            // Length (2 bytes) will be assigned at last.
            msg[offset++] = 0;
            msg[offset++] = 0;

            // Transaction ID (16 bytes)
            Array.Copy(Guid.NewGuid().ToByteArray(), 0, msg, offset, 16);
            offset += 16;

            msg[2] = (byte)((offset - 20) >> 8);
            msg[3] = (byte)((offset - 20) & 0xFF);

            return socket.SendTo(msg, 0, offset, SocketFlags.None, ep);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(addressTextBox.Text), Convert.ToInt32(portTextBox.Text));
            byte[] buffer;
            switch (commandComboBox.Text)
            {
                case "Handshake":
                    buffer = Encoding.UTF8.GetBytes("HANDSHAKE");
                    break;
                case "Stun":
                    ep = new IPEndPoint(System.Net.Dns.GetHostAddresses("stun1.l.google.com")[0], 19302);
                    byte[] msg = new byte[512];
                    int offset = 0;

                    //--- message header -------------------------------------

                    // Message Type (2 bytes)
                    msg[offset++] = (byte)(0x0001 >> 8);
                    msg[offset++] = (byte)(0x0001 & 0xFF);

                    // Length (2 bytes) will be assigned at last.
                    msg[offset++] = 0;
                    msg[offset++] = 0;

                    // Transaction ID (16 bytes)
                    Array.Copy(Guid.NewGuid().ToByteArray(), 0, msg, offset, 16);
                    offset += 16;

                    msg[2] = (byte)((offset - 20) >> 8);
                    msg[3] = (byte)((offset - 20) & 0xFF);

                    buffer = new byte[offset];
                    Array.Copy(msg, buffer, buffer.Length);

                    break;
                default:
                    buffer = new byte[0];
                    break;
            }
                
                
            int i = socket.SendTo(buffer, 0, buffer.Length, SocketFlags.None, ep);
            Console.WriteLine(i);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();


            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //socket.Bind(new IPEndPoint(IPAddress.Any, 0));

            //UdpConnectionInfo connection = new UdpConnectionInfo();
            //socket.BeginReceiveFrom(connection.Buffer, 0, connection.Buffer.Length, SocketFlags.None, ref connection.EndPoint, DoReceiveFrom, connection);
        }

        private void DoReceiveFrom(IAsyncResult result)
        {
            if (socket == null) return;

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
                    byte[] buffer = new byte[bytesRead];
                    Array.Copy(connection.Buffer, buffer, bytesRead);

                    string response = "";

                    int offset = 0;
                    MessageType messageType = (MessageType)(buffer[offset++] << 8 | buffer[offset++]);
                    int messageLength = (buffer[offset++] << 8 | buffer[offset++]);
                    Guid guid = Guid.NewGuid();
                    offset += 16;

                    switch (messageType)
                    {
                        case MessageType.BindingRequest:

                            break;
                        case MessageType.BindingResponse:
                            ResultType resultType = (ResultType)(buffer[offset++] << 8 | buffer[offset++]);
                            int length = (buffer[offset++] << 8 | buffer[offset++]);
                            switch (resultType)
                            {
                                // MappedAddress
                                case ResultType.MappedAddress:
                                    offset++;
                                    offset++;

                                    int port = (buffer[offset++] << 8 | buffer[offset++]);

                                    byte[] mappedAddress = new byte[4];
                                    mappedAddress[0] = buffer[offset++];
                                    mappedAddress[1] = buffer[offset++];
                                    mappedAddress[2] = buffer[offset++];
                                    mappedAddress[3] = buffer[offset++];

                                    externalEndPoint = new IPEndPoint(new IPAddress(mappedAddress), port);

                                    response = "MappedAddress:" + externalEndPoint.ToString();

                                    this.Invoke(new Action(() =>
                                    {
                                        externalEndPointLabel.Text = externalEndPoint.ToString();
                                    }));


                                    break;
                                // ResponseAddress
                                case ResultType.ResponseAddress:
                                    break;
                                // ChangeRequest
                                case ResultType.ChangeRequest:
                                    break;
                                // SourceAddress
                                case ResultType.SourceAddress:
                                    break;
                                    // ChangedAddress
                                case ResultType.ChangedAddress:
                                    break;
                                // Username                       
                                case ResultType.Username:
                                    break;
                                // Password
                                case ResultType.Password:
                                    break;
                                // MessageIntegrity
                                case ResultType.MessageIntegrity:
                                    break;
                                // ErrorCode
                                case ResultType.ErrorCode:
                                    break;
                                // UnknownAttribute
                                case ResultType.UnknownAttribute:
                                    break;
                                // ReflectedFrom
                                case ResultType.ReflectedFrom:
                                    break;
                                // XorMappedAddress
                                case ResultType.XorMappedAddress:
                                    break;
                                // XorOnly
                                case ResultType.XorOnly:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            response = "MessageType.Unknown:" + Encoding.UTF8.GetString(buffer);
                            break;
                    }

                    connection.Row.Cells[1].Value = response;
                    connection.Row.Cells[2].Value = Convert.ToInt32(counter);
                }
                else
                {
                    connection.Row.Cells[1].Value = "NULL";
                    connection.Row.Cells[2].Value = Convert.ToInt32(counter);
                }
            }
            finally
            {
                UdpConnectionInfo newConnection = new UdpConnectionInfo();
                socket.BeginReceiveFrom(newConnection.Buffer, 0, newConnection.Buffer.Length, SocketFlags.None, ref newConnection.EndPoint, DoReceiveFrom, newConnection);
            }
        }

        private void nodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nodePortTextBox.Enabled = nodeCheckBox.Checked;
        }

        private void startCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (startCheckBox.Checked)
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    socket.Bind(new IPEndPoint(IPAddress.Any, nodeCheckBox.Checked ? Convert.ToInt32(nodePortTextBox.Text) : 0));

                    UdpConnectionInfo connection = new UdpConnectionInfo();
                    socket.BeginReceiveFrom(connection.Buffer, 0, connection.Buffer.Length, SocketFlags.None, ref connection.EndPoint, DoReceiveFrom, connection);

                    if (nodeCheckBox.Checked)
                    {
                        SendBindingRequest(new IPEndPoint(System.Net.Dns.GetHostAddresses("stun1.l.google.com")[0], 19302));
                    }

                    startCheckBox.ImageIndex = 0;

                    nodeCheckBox.Enabled = false;
                    nodePortTextBox.Enabled = false;

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
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
                clients.Clear();

                startCheckBox.ImageIndex = 1;

                nodeCheckBox.Enabled = true;
                nodePortTextBox.Enabled = true;
            }
        }
    }
}
