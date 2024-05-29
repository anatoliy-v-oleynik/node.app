namespace NodeClient
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
            this.sendButton = new System.Windows.Forms.Button();
            this.commandComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.portTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.externalEndPointLabel = new System.Windows.Forms.Label();
            this.nodeCheckBox = new System.Windows.Forms.CheckBox();
            this.nodePortTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendButton);
            this.panel2.Controls.Add(this.commandComboBox);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(this.portTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(800, 63);
            this.panel2.TabIndex = 7;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(511, 22);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 21);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // commandComboBox
            // 
            this.commandComboBox.DisplayMember = "Ping";
            this.commandComboBox.FormattingEnabled = true;
            this.commandComboBox.Items.AddRange(new object[] {
            "Ping",
            "Handshake",
            "Stun"});
            this.commandComboBox.Location = new System.Drawing.Point(290, 22);
            this.commandComboBox.Name = "commandComboBox";
            this.commandComboBox.Size = new System.Drawing.Size(204, 21);
            this.commandComboBox.TabIndex = 6;
            this.commandComboBox.Text = "Ping";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressTextBox.Location = new System.Drawing.Point(52, 22);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(149, 20);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Text = "78.36.16.209";
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portTextBox
            // 
            this.portTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.portTextBox.Location = new System.Drawing.Point(203, 22);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(84, 20);
            this.portTextBox.TabIndex = 2;
            this.portTextBox.Text = "5500";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.externalEndPointLabel);
            this.panel1.Controls.Add(this.nodeCheckBox);
            this.panel1.Controls.Add(this.nodePortTextBox);
            this.panel1.Controls.Add(this.startCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 9;
            // 
            // externalEndPointLabel
            // 
            this.externalEndPointLabel.AutoSize = true;
            this.externalEndPointLabel.Location = new System.Drawing.Point(200, 23);
            this.externalEndPointLabel.Name = "externalEndPointLabel";
            this.externalEndPointLabel.Size = new System.Drawing.Size(73, 13);
            this.externalEndPointLabel.TabIndex = 9;
            this.externalEndPointLabel.Text = "0.0.0.0:00000";
            // 
            // nodeCheckBox
            // 
            this.nodeCheckBox.AutoSize = true;
            this.nodeCheckBox.Location = new System.Drawing.Point(645, 22);
            this.nodeCheckBox.Name = "nodeCheckBox";
            this.nodeCheckBox.Size = new System.Drawing.Size(52, 17);
            this.nodeCheckBox.TabIndex = 8;
            this.nodeCheckBox.Text = "Узел";
            this.nodeCheckBox.UseVisualStyleBackColor = true;
            this.nodeCheckBox.CheckedChanged += new System.EventHandler(this.nodeCheckBox_CheckedChanged);
            // 
            // nodePortTextBox
            // 
            this.nodePortTextBox.Enabled = false;
            this.nodePortTextBox.Location = new System.Drawing.Point(712, 20);
            this.nodePortTextBox.Name = "nodePortTextBox";
            this.nodePortTextBox.Size = new System.Drawing.Size(64, 20);
            this.nodePortTextBox.TabIndex = 7;
            this.nodePortTextBox.Text = "5500";
            this.nodePortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.startCheckBox.Size = new System.Drawing.Size(54, 48);
            this.startCheckBox.TabIndex = 5;
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
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
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 60;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(800, 329);
            this.dataGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "Node Client";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox addressTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MaskedTextBox portTextBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox commandComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox nodeCheckBox;
        private System.Windows.Forms.MaskedTextBox nodePortTextBox;
        private System.Windows.Forms.Label externalEndPointLabel;
    }
}

