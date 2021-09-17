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
            components = new System.ComponentModel.Container();
            radioSerial = new RadioButton();
            radioTcpIP = new RadioButton();
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
            operState = new Label();
            btnDraw = new Button();
            gbTimout = new GroupBox();
            mtbTimeout = new MaskedTextBox();
            labelTimeoutUnit = new Label();
            gbDisplayPolls = new GroupBox();
            mtbDisplayPolls = new MaskedTextBox();
            labelDisplayPollsUnit = new Label();
            frmPlot = new ScottPlot.WinForms.FormsPlot();
            gbPic = new GroupBox();
            timerModbus = new System.Windows.Forms.Timer(components);
            labelComment = new Label();
            gbConnection.SuspendLayout();
            gbSerialSettings.SuspendLayout();
            gbOperation.SuspendLayout();
            gbTimout.SuspendLayout();
            gbDisplayPolls.SuspendLayout();
            gbPic.SuspendLayout();
            SuspendLayout();
            // 
            // radioSerial
            // 
            radioSerial.AutoSize = true;
            radioSerial.Location = new Point(30, 42);
            radioSerial.Name = "radioSerial";
            radioSerial.Size = new Size(334, 35);
            radioSerial.TabIndex = 0;
            radioSerial.TabStop = true;
            radioSerial.Text = "Serial Port (Modbus RTU)";
            radioSerial.UseVisualStyleBackColor = true;
            radioSerial.CheckedChanged += radioSerial_CheckedChanged;
            // 
            // radioTcpIP
            // 
            radioTcpIP.AutoSize = true;
            radioTcpIP.Location = new Point(30, 83);
            radioTcpIP.Name = "radioTcpIP";
            radioTcpIP.Size = new Size(223, 35);
            radioTcpIP.TabIndex = 1;
            radioTcpIP.TabStop = true;
            radioTcpIP.Text = "Modbus TCP/IP";
            radioTcpIP.UseVisualStyleBackColor = true;
            radioTcpIP.CheckedChanged += radioTcpIP_CheckedChanged;
            // 
            // gbConnection
            // 
            gbConnection.Controls.Add(radioSerial);
            gbConnection.Controls.Add(radioTcpIP);
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
            cbParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParity.FormattingEnabled = true;
            cbParity.Items.AddRange(new object[] { "None Parity", "Odd Parity", "Even Parity" });
            cbParity.Location = new Point(162, 310);
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(242, 39);
            cbParity.TabIndex = 4;
            cbParity.ValueMember = "1";
            // 
            // cbStop
            // 
            cbStop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStop.FormattingEnabled = true;
            cbStop.Items.AddRange(new object[] { "1 stop bit", "2 stop bits" });
            cbStop.Location = new Point(162, 248);
            cbStop.Name = "cbStop";
            cbStop.Size = new Size(242, 39);
            cbStop.TabIndex = 3;
            // 
            // cbData
            // 
            cbData.DropDownStyle = ComboBoxStyle.DropDownList;
            cbData.FormattingEnabled = true;
            cbData.Items.AddRange(new object[] { "7 Data Bits", "8 Data Bits" });
            cbData.Location = new Point(162, 186);
            cbData.Name = "cbData";
            cbData.Size = new Size(242, 39);
            cbData.TabIndex = 2;
            // 
            // cbBaud
            // 
            cbBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaud.FormattingEnabled = true;
            cbBaud.Items.AddRange(new object[] { "9600", "14400", "19200" });
            cbBaud.Location = new Point(164, 124);
            cbBaud.Name = "cbBaud";
            cbBaud.Size = new Size(242, 39);
            cbBaud.TabIndex = 1;
            // 
            // cbSerial
            // 
            cbSerial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSerial.FormattingEnabled = true;
            cbSerial.Location = new Point(162, 62);
            cbSerial.Name = "cbSerial";
            cbSerial.Size = new Size(242, 39);
            cbSerial.TabIndex = 0;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(225, 38);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 46);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "连接";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(477, 38);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(150, 46);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "断开";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // gbOperation
            // 
            gbOperation.Controls.Add(operState);
            gbOperation.Controls.Add(btnDraw);
            gbOperation.Controls.Add(btnDisconnect);
            gbOperation.Controls.Add(btnConnect);
            gbOperation.Location = new Point(27, 971);
            gbOperation.Name = "gbOperation";
            gbOperation.Size = new Size(924, 104);
            gbOperation.TabIndex = 6;
            gbOperation.TabStop = false;
            gbOperation.Text = "Operation";
            // 
            // operState
            // 
            operState.BackColor = Color.LightGray;
            operState.Location = new Point(65, 37);
            operState.Name = "operState";
            operState.Size = new Size(121, 49);
            operState.TabIndex = 7;
            operState.Text = "操作状态";
            operState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(729, 38);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(150, 46);
            btnDraw.TabIndex = 6;
            btnDraw.Text = "画图";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // gbTimout
            // 
            gbTimout.Controls.Add(mtbTimeout);
            gbTimout.Controls.Add(labelTimeoutUnit);
            gbTimout.Location = new Point(27, 162);
            gbTimout.Name = "gbTimout";
            gbTimout.Size = new Size(448, 103);
            gbTimout.TabIndex = 7;
            gbTimout.TabStop = false;
            gbTimout.Text = "Response Timeout";
            // 
            // mtbTimeout
            // 
            mtbTimeout.Location = new Point(30, 46);
            mtbTimeout.Mask = "0000";
            mtbTimeout.Name = "mtbTimeout";
            mtbTimeout.Size = new Size(200, 38);
            mtbTimeout.TabIndex = 2;
            mtbTimeout.Text = "1000";
            mtbTimeout.TextAlign = HorizontalAlignment.Right;
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
            // gbDisplayPolls
            // 
            gbDisplayPolls.Controls.Add(mtbDisplayPolls);
            gbDisplayPolls.Controls.Add(labelDisplayPollsUnit);
            gbDisplayPolls.Location = new Point(27, 273);
            gbDisplayPolls.Name = "gbDisplayPolls";
            gbDisplayPolls.Size = new Size(448, 118);
            gbDisplayPolls.TabIndex = 8;
            gbDisplayPolls.TabStop = false;
            gbDisplayPolls.Text = "Display Between Polls";
            // 
            // mtbDisplayPolls
            // 
            mtbDisplayPolls.Location = new Point(30, 48);
            mtbDisplayPolls.Mask = "0000";
            mtbDisplayPolls.Name = "mtbDisplayPolls";
            mtbDisplayPolls.Size = new Size(200, 38);
            mtbDisplayPolls.TabIndex = 11;
            mtbDisplayPolls.Text = "20";
            mtbDisplayPolls.TextAlign = HorizontalAlignment.Right;
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
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new Point(998, 22);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(617, 62);
            labelComment.TabIndex = 11;
            labelComment.Text = "1. 创建串口或网口（实体或虚拟），界面即可正常显示；\r\n2. 创建Modbus Slave模拟器，点击开始，即可画图。";
            // 
            // FrmMobus
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 1104);
            Controls.Add(labelComment);
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
            PerformLayout();
        }

        #endregion

        private RadioButton radioSerial;
        private RadioButton radioTcpIP;
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
        private Label labelDisplayPollsUnit;
        private ScottPlot.WinForms.FormsPlot frmPlot;
        private GroupBox gbPic;
        private System.Windows.Forms.Timer timerModbus;
        private MaskedTextBox mtbDisplayPolls;
        private MaskedTextBox mtbTimeout;
        private Label labelComment;
        private Button btnDraw;
        private Label operState;
    }
}
