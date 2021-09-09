namespace WinFormsApp01
{
    partial class FrmMobus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rSerial = new RadioButton();
            rTcpIP = new RadioButton();
            gbConnection = new GroupBox();
            gbSerialSettings = new GroupBox();
            labelParity = new Label();
            labelStop = new Label();
            labelData = new Label();
            labelBaud = new Label();
            labelSerial = new Label();
            cbParity = new ComboBox();
            cbStop = new ComboBox();
            cbData = new ComboBox();
            cbBaud = new ComboBox();
            cbSerial = new ComboBox();
            btnConnect = new Button();
            btnDisconnect = new Button();
            gbOperation = new GroupBox();
            gbTimout = new GroupBox();
            labelTimeoutUnit = new Label();
            tbTimeout = new TextBox();
            gbDisplayPolls = new GroupBox();
            labelDisplayPollsUnit = new Label();
            tbDisplayPolls = new TextBox();
            frmPlot = new ScottPlot.WinForms.FormsPlot();
            gbPic = new GroupBox();
            gbConnection.SuspendLayout();
            gbSerialSettings.SuspendLayout();
            gbOperation.SuspendLayout();
            gbTimout.SuspendLayout();
            gbDisplayPolls.SuspendLayout();
            gbPic.SuspendLayout();
            SuspendLayout();
            // 
            // rSerial
            // 
            rSerial.AutoSize = true;
            rSerial.Location = new Point(30, 42);
            rSerial.Name = "rSerial";
            rSerial.Size = new Size(334, 35);
            rSerial.TabIndex = 0;
            rSerial.TabStop = true;
            rSerial.Text = "Serial Port (Modbus RTU)";
            rSerial.UseVisualStyleBackColor = true;
            // 
            // rTcpIP
            // 
            rTcpIP.AutoSize = true;
            rTcpIP.Location = new Point(30, 83);
            rTcpIP.Name = "rTcpIP";
            rTcpIP.Size = new Size(223, 35);
            rTcpIP.TabIndex = 1;
            rTcpIP.TabStop = true;
            rTcpIP.Text = "Modbus TCP/IP";
            rTcpIP.UseVisualStyleBackColor = true;
            // 
            // gbConnection
            // 
            gbConnection.Controls.Add(rSerial);
            gbConnection.Controls.Add(rTcpIP);
            gbConnection.Location = new Point(27, 22);
            gbConnection.Name = "gbConnection";
            gbConnection.Size = new Size(448, 134);
            gbConnection.TabIndex = 2;
            gbConnection.TabStop = false;
            gbConnection.Text = "Connection";
            // 
            // gbSerialSettings
            // 
            gbSerialSettings.Controls.Add(labelParity);
            gbSerialSettings.Controls.Add(labelStop);
            gbSerialSettings.Controls.Add(labelData);
            gbSerialSettings.Controls.Add(labelBaud);
            gbSerialSettings.Controls.Add(labelSerial);
            gbSerialSettings.Controls.Add(cbParity);
            gbSerialSettings.Controls.Add(cbStop);
            gbSerialSettings.Controls.Add(cbData);
            gbSerialSettings.Controls.Add(cbBaud);
            gbSerialSettings.Controls.Add(cbSerial);
            gbSerialSettings.ForeColor = SystemColors.ControlText;
            gbSerialSettings.Location = new Point(503, 22);
            gbSerialSettings.Name = "gbSerialSettings";
            gbSerialSettings.Size = new Size(448, 369);
            gbSerialSettings.TabIndex = 3;
            gbSerialSettings.TabStop = false;
            gbSerialSettings.Text = "Serial Settings";
            // 
            // labelParity
            // 
            labelParity.AutoSize = true;
            labelParity.Location = new Point(39, 312);
            labelParity.Name = "labelParity";
            labelParity.Size = new Size(116, 31);
            labelParity.TabIndex = 9;
            labelParity.Text = "Parity Bit";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(51, 249);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(104, 31);
            labelStop.TabIndex = 8;
            labelStop.Text = "Stop Bit";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(40, 186);
            labelData.Name = "labelData";
            labelData.Size = new Size(115, 31);
            labelData.TabIndex = 7;
            labelData.Text = "Data Bits";
            // 
            // labelBaud
            // 
            labelBaud.AutoSize = true;
            labelBaud.Location = new Point(24, 123);
            labelBaud.Name = "labelBaud";
            labelBaud.Size = new Size(131, 31);
            labelBaud.TabIndex = 6;
            labelBaud.Text = "Baud Rate";
            // 
            // labelSerial
            // 
            labelSerial.AutoSize = true;
            labelSerial.Location = new Point(24, 62);
            labelSerial.Name = "labelSerial";
            labelSerial.Size = new Size(131, 31);
            labelSerial.TabIndex = 5;
            labelSerial.Text = "Serial Port";
            // 
            // cbParity
            // 
            cbParity.DisplayMember = "1";
            cbParity.FormattingEnabled = true;
            cbParity.Items.AddRange(new object[] { "1 stop bit", "2 stop bits" });
            cbParity.Location = new Point(162, 310);
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(242, 39);
            cbParity.TabIndex = 4;
            cbParity.ValueMember = "1";
            // 
            // cbStop
            // 
            cbStop.FormattingEnabled = true;
            cbStop.Location = new Point(162, 248);
            cbStop.Name = "cbStop";
            cbStop.Size = new Size(242, 39);
            cbStop.TabIndex = 3;
            // 
            // cbData
            // 
            cbData.FormattingEnabled = true;
            cbData.Location = new Point(162, 186);
            cbData.Name = "cbData";
            cbData.Size = new Size(242, 39);
            cbData.TabIndex = 2;
            // 
            // cbBaud
            // 
            cbBaud.FormattingEnabled = true;
            cbBaud.Location = new Point(164, 124);
            cbBaud.Name = "cbBaud";
            cbBaud.Size = new Size(242, 39);
            cbBaud.TabIndex = 1;
            // 
            // cbSerial
            // 
            cbSerial.FormattingEnabled = true;
            cbSerial.Location = new Point(162, 62);
            cbSerial.Name = "cbSerial";
            cbSerial.Size = new Size(242, 39);
            cbSerial.TabIndex = 0;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(21, 37);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 46);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "连接";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += button1_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(214, 37);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(150, 46);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "断开";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += button2_Click;
            // 
            // gbOperation
            // 
            gbOperation.Controls.Add(btnDisconnect);
            gbOperation.Controls.Add(btnConnect);
            gbOperation.Location = new Point(27, 971);
            gbOperation.Name = "gbOperation";
            gbOperation.Size = new Size(924, 104);
            gbOperation.TabIndex = 6;
            gbOperation.TabStop = false;
            gbOperation.Text = "Operation";
            // 
            // gbTimout
            // 
            gbTimout.Controls.Add(labelTimeoutUnit);
            gbTimout.Controls.Add(tbTimeout);
            gbTimout.Location = new Point(27, 162);
            gbTimout.Name = "gbTimout";
            gbTimout.Size = new Size(448, 103);
            gbTimout.TabIndex = 7;
            gbTimout.TabStop = false;
            gbTimout.Text = "Response Timeout";
            // 
            // labelTimeoutUnit
            // 
            labelTimeoutUnit.AutoSize = true;
            labelTimeoutUnit.Location = new Point(236, 51);
            labelTimeoutUnit.Name = "labelTimeoutUnit";
            labelTimeoutUnit.Size = new Size(63, 31);
            labelTimeoutUnit.TabIndex = 1;
            labelTimeoutUnit.Text = "[ms]";
            // 
            // tbTimeout
            // 
            tbTimeout.Location = new Point(30, 48);
            tbTimeout.Name = "tbTimeout";
            tbTimeout.Size = new Size(200, 38);
            tbTimeout.TabIndex = 0;
            tbTimeout.Text = "1000";
            // 
            // gbDisplayPolls
            // 
            gbDisplayPolls.Controls.Add(labelDisplayPollsUnit);
            gbDisplayPolls.Controls.Add(tbDisplayPolls);
            gbDisplayPolls.Location = new Point(27, 273);
            gbDisplayPolls.Name = "gbDisplayPolls";
            gbDisplayPolls.Size = new Size(448, 118);
            gbDisplayPolls.TabIndex = 8;
            gbDisplayPolls.TabStop = false;
            gbDisplayPolls.Text = "Display Between Polls";
            // 
            // labelDisplayPollsUnit
            // 
            labelDisplayPollsUnit.AutoSize = true;
            labelDisplayPollsUnit.Location = new Point(236, 51);
            labelDisplayPollsUnit.Name = "labelDisplayPollsUnit";
            labelDisplayPollsUnit.Size = new Size(63, 31);
            labelDisplayPollsUnit.TabIndex = 3;
            labelDisplayPollsUnit.Text = "[ms]";
            // 
            // tbDisplayPolls
            // 
            tbDisplayPolls.Location = new Point(30, 48);
            tbDisplayPolls.Name = "tbDisplayPolls";
            tbDisplayPolls.Size = new Size(200, 38);
            tbDisplayPolls.TabIndex = 2;
            tbDisplayPolls.Text = "20";
            // 
            // frmPlot
            // 
            frmPlot.Dock = DockStyle.Fill;
            frmPlot.Location = new Point(3, 34);
            frmPlot.Name = "frmPlot";
            frmPlot.Size = new Size(918, 496);
            frmPlot.TabIndex = 9;
            // 
            // gbPic
            // 
            gbPic.Controls.Add(frmPlot);
            gbPic.Location = new Point(27, 414);
            gbPic.Name = "gbPic";
            gbPic.Size = new Size(924, 533);
            gbPic.TabIndex = 10;
            gbPic.TabStop = false;
            gbPic.Text = "Curve";
            // 
            // FrmMobus
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 1104);
            Controls.Add(gbPic);
            Controls.Add(gbDisplayPolls);
            Controls.Add(gbTimout);
            Controls.Add(gbOperation);
            Controls.Add(gbSerialSettings);
            Controls.Add(gbConnection);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMobus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMobus";
            Load += FrmMobus_Load;
            gbConnection.ResumeLayout(false);
            gbConnection.PerformLayout();
            gbSerialSettings.ResumeLayout(false);
            gbSerialSettings.PerformLayout();
            gbOperation.ResumeLayout(false);
            gbTimout.ResumeLayout(false);
            gbTimout.PerformLayout();
            gbDisplayPolls.ResumeLayout(false);
            gbDisplayPolls.PerformLayout();
            gbPic.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rSerial;
        private RadioButton rTcpIP;
        private GroupBox gbConnection;
        private GroupBox gbSerialSettings;
        private ComboBox cbSerial;
        private ComboBox cbParity;
        private ComboBox cbStop;
        private ComboBox cbData;
        private ComboBox cbBaud;
        private Label labelSerial;
        private Label labelBaud;
        private Label labelData;
        private Label labelStop;
        private Label labelParity;
        private Button btnConnect;
        private Button btnDisconnect;
        private GroupBox gbOperation;
        private GroupBox gbTimout;
        private GroupBox gbDisplayPolls;
        private Label labelTimeoutUnit;
        private TextBox tbTimeout;
        private Label labelDisplayPollsUnit;
        private TextBox tbDisplayPolls;
        private ScottPlot.WinForms.FormsPlot frmPlot;
        private GroupBox gbPic;
    }
}