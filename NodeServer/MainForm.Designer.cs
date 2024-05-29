namespace NodeServer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loopDataTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loopCheckBox = new System.Windows.Forms.CheckBox();
            this.sendDataTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendAddressTextBox = new System.Windows.Forms.TextBox();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nodeCheckBox = new System.Windows.Forms.CheckBox();
            this.portTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loopDataTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.loopCheckBox);
            this.panel2.Controls.Add(this.sendDataTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sendPortTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.sendAddressTextBox);
            this.panel2.Controls.Add(this.sendDataButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(807, 94);
            this.panel2.TabIndex = 5;
            // 
            // loopDataTextBox
            // 
            this.loopDataTextBox.Location = new System.Drawing.Point(595, 25);
            this.loopDataTextBox.Name = "loopDataTextBox";
            this.loopDataTextBox.Size = new System.Drawing.Size(136, 20);
            this.loopDataTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LoopData:";
            // 
            // loopCheckBox
            // 
            this.loopCheckBox.AutoSize = true;
            this.loopCheckBox.Location = new System.Drawing.Point(745, 27);
            this.loopCheckBox.Name = "loopCheckBox";
            this.loopCheckBox.Size = new System.Drawing.Size(50, 17);
            this.loopCheckBox.TabIndex = 9;
            this.loopCheckBox.Text = "Loop";
            this.loopCheckBox.UseVisualStyleBackColor = true;
            this.loopCheckBox.CheckedChanged += new System.EventHandler(this.loopCheckBox_CheckedChanged);
            // 
            // sendDataTextBox
            // 
            this.sendDataTextBox.Location = new System.Drawing.Point(264, 25);
            this.sendDataTextBox.Name = "sendDataTextBox";
            this.sendDataTextBox.Size = new System.Drawing.Size(175, 20);
            this.sendDataTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SendData:";
            // 
            // sendPortTextBox
            // 
            this.sendPortTextBox.Location = new System.Drawing.Point(159, 25);
            this.sendPortTextBox.Name = "sendPortTextBox";
            this.sendPortTextBox.Size = new System.Drawing.Size(36, 20);
            this.sendPortTextBox.TabIndex = 6;
            this.sendPortTextBox.Text = "3478";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // sendAddressTextBox
            // 
            this.sendAddressTextBox.Location = new System.Drawing.Point(38, 25);
            this.sendAddressTextBox.Name = "sendAddressTextBox";
            this.sendAddressTextBox.Size = new System.Drawing.Size(80, 20);
            this.sendAddressTextBox.TabIndex = 3;
            this.sendAddressTextBox.Text = "127.0.0.1";
            // 
            // sendDataButton
            // 
            this.sendDataButton.Location = new System.Drawing.Point(451, 25);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(75, 21);
            this.sendDataButton.TabIndex = 2;
            this.sendDataButton.Text = "SendTo";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nodeCheckBox);
            this.panel1.Controls.Add(this.portTextBox);
            this.panel1.Controls.Add(this.startCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(807, 67);
            this.panel1.TabIndex = 7;
            // 
            // nodeCheckBox
            // 
            this.nodeCheckBox.AutoSize = true;
            this.nodeCheckBox.Checked = true;
            this.nodeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nodeCheckBox.Location = new System.Drawing.Point(653, 25);
            this.nodeCheckBox.Name = "nodeCheckBox";
            this.nodeCheckBox.Size = new System.Drawing.Size(52, 17);
            this.nodeCheckBox.TabIndex = 6;
            this.nodeCheckBox.Text = "Узел";
            this.nodeCheckBox.UseVisualStyleBackColor = true;
            this.nodeCheckBox.CheckedChanged += new System.EventHandler(this.nodeCheckBox_CheckedChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(720, 23);
            this.portTextBox.Mask = "9999";
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(64, 20);
            this.portTextBox.TabIndex = 5;
            this.portTextBox.Text = "5500";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startCheckBox
            // 
            this.startCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.startCheckBox.AutoSize = true;
            this.startCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.startCheckBox.FlatAppearance.BorderSize = 0;
            this.startCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.startCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.startCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.startCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startCheckBox.ImageIndex = 1;
            this.startCheckBox.ImageList = this.imageList;
            this.startCheckBox.Location = new System.Drawing.Point(5, 5);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(54, 57);
            this.startCheckBox.TabIndex = 4;
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "eve_checked.png");
            this.imageList.Images.SetKeyName(1, "eve_uncheck.png");
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 60;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(807, 438);
            this.dataGridView.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 599);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "Node Server";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MaskedTextBox portTextBox;
        private System.Windows.Forms.CheckBox nodeCheckBox;
        private System.Windows.Forms.TextBox sendPortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendDataTextBox;
        private System.Windows.Forms.CheckBox loopCheckBox;
        private System.Windows.Forms.TextBox loopDataTextBox;
        private System.Windows.Forms.Label label4;
    }
}

