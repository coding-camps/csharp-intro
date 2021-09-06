namespace WinFormsApp01
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btnTest01 = new Button();
            groupBox1 = new GroupBox();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textMsg = new TextBox();
            btnSendMsg = new Button();
            btnOpenFrm = new Button();
            groupBox4 = new GroupBox();
            roundRect9 = new UIControLib.RoundRect();
            roundRect7 = new UIControLib.RoundRect();
            roundRect6 = new UIControLib.RoundRect();
            roundRect5 = new UIControLib.RoundRect();
            roundRect4 = new UIControLib.RoundRect();
            roundRect3 = new UIControLib.RoundRect();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            gbRandom = new GroupBox();
            tbRandomLen = new TextBox();
            labelRandomLen = new Label();
            btnRandomCopy = new Button();
            randStr = new TextBox();
            btnRandom = new Button();
            btnSQLite = new Button();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gbRandom.SuspendLayout();
            SuspendLayout();
            // 
            // btnTest01
            // 
            btnTest01.Location = new Point(43, 31);
            btnTest01.Name = "btnTest01";
            btnTest01.Size = new Size(229, 105);
            btnTest01.TabIndex = 0;
            btnTest01.Text = "btnTest01";
            btnTest01.UseVisualStyleBackColor = true;
            btnTest01.Click += btnTest01_Click;
            btnTest01.MouseEnter += btnTest01_MouseEnter;
            btnTest01.MouseLeave += btnTest01_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(labelUsername);
            groupBox1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(39, 365);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "登录界面";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonLogin.Location = new Point(462, 91);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(151, 120);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "登录";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBoxPassword.Location = new Point(184, 160);
            textBoxPassword.MaxLength = 10;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "输入密码";
            textBoxPassword.Size = new Size(200, 48);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBoxUsername.Location = new Point(184, 88);
            textBoxUsername.MaxLength = 10;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "输入用户名";
            textBoxUsername.Size = new Size(200, 48);
            textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelPassword.Location = new Point(64, 160);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(114, 41);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "密码：";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelUsername.Location = new Point(64, 91);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(114, 41);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "名称：";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(39, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 155);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textMsg);
            groupBox3.Controls.Add(btnSendMsg);
            groupBox3.Controls.Add(btnOpenFrm);
            groupBox3.Location = new Point(43, 680);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(480, 194);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "委托案例之窗体间传值";
            // 
            // textMsg
            // 
            textMsg.Location = new Point(16, 56);
            textMsg.MaxLength = 17;
            textMsg.Name = "textMsg";
            textMsg.PlaceholderText = "2.这里填写的是传给下个窗口的消息";
            textMsg.Size = new Size(436, 38);
            textMsg.TabIndex = 2;
            // 
            // btnSendMsg
            // 
            btnSendMsg.Location = new Point(258, 115);
            btnSendMsg.Name = "btnSendMsg";
            btnSendMsg.Size = new Size(194, 44);
            btnSendMsg.TabIndex = 1;
            btnSendMsg.Text = "3.发送消息";
            btnSendMsg.UseVisualStyleBackColor = true;
            btnSendMsg.Click += btnSendMsg_Click;
            // 
            // btnOpenFrm
            // 
            btnOpenFrm.Location = new Point(16, 115);
            btnOpenFrm.Name = "btnOpenFrm";
            btnOpenFrm.Size = new Size(194, 44);
            btnOpenFrm.TabIndex = 0;
            btnOpenFrm.Text = "1.打开窗体";
            btnOpenFrm.UseVisualStyleBackColor = true;
            btnOpenFrm.Click += btnOpenFrm_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightGray;
            groupBox4.Controls.Add(roundRect9);
            groupBox4.Controls.Add(roundRect7);
            groupBox4.Controls.Add(roundRect6);
            groupBox4.Controls.Add(roundRect5);
            groupBox4.Controls.Add(roundRect4);
            groupBox4.Controls.Add(roundRect3);
            groupBox4.FlatStyle = FlatStyle.Popup;
            groupBox4.Location = new Point(762, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(868, 257);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "这里的圆角框是自定义控件";
            // 
            // roundRect9
            // 
            roundRect9.BorderColor = Color.Red;
            roundRect9.BorderWidth = 9;
            roundRect9.FillColor = SystemColors.Control;
            roundRect9.Location = new Point(545, 141);
            roundRect9.Name = "roundRect9";
            roundRect9.Size = new Size(219, 86);
            roundRect9.TabIndex = 10;
            roundRect9.Text = "roundRect9";
            // 
            // roundRect7
            // 
            roundRect7.BorderColor = Color.Red;
            roundRect7.FillColor = Color.Snow;
            roundRect7.Location = new Point(242, 167);
            roundRect7.Name = "roundRect7";
            roundRect7.Size = new Size(251, 60);
            roundRect7.TabIndex = 8;
            roundRect7.Text = "roundRect7";
            // 
            // roundRect6
            // 
            roundRect6.BorderColor = Color.DarkGray;
            roundRect6.BorderRadius = 20;
            roundRect6.BorderWidth = 12;
            roundRect6.FillColor = SystemColors.Control;
            roundRect6.Location = new Point(667, 53);
            roundRect6.Name = "roundRect6";
            roundRect6.Size = new Size(150, 46);
            roundRect6.TabIndex = 9;
            roundRect6.Text = "roundRect6";
            // 
            // roundRect5
            // 
            roundRect5.BorderColor = Color.Red;
            roundRect5.BorderRadius = 20;
            roundRect5.BorderWidth = 10;
            roundRect5.FillColor = SystemColors.Control;
            roundRect5.Location = new Point(16, 44);
            roundRect5.Name = "roundRect5";
            roundRect5.Size = new Size(219, 113);
            roundRect5.TabIndex = 8;
            roundRect5.Text = "roundRect5";
            // 
            // roundRect4
            // 
            roundRect4.BorderColor = Color.LimeGreen;
            roundRect4.BorderRadius = 15;
            roundRect4.BorderWidth = 10;
            roundRect4.FillColor = Color.LightCyan;
            roundRect4.Location = new Point(256, 53);
            roundRect4.Name = "roundRect4";
            roundRect4.Size = new Size(212, 92);
            roundRect4.TabIndex = 7;
            roundRect4.Text = "roundRect4";
            // 
            // roundRect3
            // 
            roundRect3.BorderColor = Color.DarkGray;
            roundRect3.FillColor = SystemColors.ButtonFace;
            roundRect3.Location = new Point(496, 53);
            roundRect3.Name = "roundRect3";
            roundRect3.Size = new Size(150, 46);
            roundRect3.TabIndex = 6;
            roundRect3.Text = "roundRect3";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(762, 306);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(868, 580);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(gbRandom);
            tabPage1.Controls.Add(btnSQLite);
            tabPage1.ForeColor = SystemColors.Highlight;
            tabPage1.Location = new Point(8, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 527);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // gbRandom
            // 
            gbRandom.BackColor = SystemColors.GradientInactiveCaption;
            gbRandom.Controls.Add(tbRandomLen);
            gbRandom.Controls.Add(labelRandomLen);
            gbRandom.Controls.Add(btnRandomCopy);
            gbRandom.Controls.Add(randStr);
            gbRandom.Controls.Add(btnRandom);
            gbRandom.Location = new Point(22, 102);
            gbRandom.Name = "gbRandom";
            gbRandom.Size = new Size(397, 403);
            gbRandom.TabIndex = 12;
            gbRandom.TabStop = false;
            gbRandom.Text = "随机字符串生成";
            // 
            // tbRandomLen
            // 
            tbRandomLen.Location = new Point(188, 50);
            tbRandomLen.MaxLength = 3;
            tbRandomLen.Name = "tbRandomLen";
            tbRandomLen.Size = new Size(143, 38);
            tbRandomLen.TabIndex = 17;
            tbRandomLen.Text = "16";
            // 
            // labelRandomLen
            // 
            labelRandomLen.AutoSize = true;
            labelRandomLen.Location = new Point(58, 50);
            labelRandomLen.Name = "labelRandomLen";
            labelRandomLen.Size = new Size(134, 31);
            labelRandomLen.TabIndex = 16;
            labelRandomLen.Text = "字符串长度";
            // 
            // btnRandomCopy
            // 
            btnRandomCopy.Location = new Point(75, 311);
            btnRandomCopy.Name = "btnRandomCopy";
            btnRandomCopy.Size = new Size(241, 56);
            btnRandomCopy.TabIndex = 15;
            btnRandomCopy.Text = "复制到剪切板";
            btnRandomCopy.UseVisualStyleBackColor = true;
            btnRandomCopy.Click += btnRandomCopy_Click;
            // 
            // randStr
            // 
            randStr.Location = new Point(20, 123);
            randStr.Multiline = true;
            randStr.Name = "randStr";
            randStr.Size = new Size(350, 76);
            randStr.TabIndex = 13;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(75, 244);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(241, 56);
            btnRandom.TabIndex = 12;
            btnRandom.Text = "生成随机字符串";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnSQLite
            // 
            btnSQLite.Location = new Point(22, 14);
            btnSQLite.Name = "btnSQLite";
            btnSQLite.Size = new Size(160, 65);
            btnSQLite.TabIndex = 10;
            btnSQLite.Text = "SQLite示例";
            btnSQLite.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.ForeColor = Color.Tomato;
            tabPage2.Location = new Point(8, 45);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(852, 527);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 929);
            Controls.Add(tabControl1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnTest01);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gbRandom.ResumeLayout(false);
            gbRandom.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion

        private Button btnTest01;
        private GroupBox groupBox1;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnOpenFrm;
        private Button btnSendMsg;
        private TextBox textMsg;
        private System.Windows.Forms.GroupBox groupBox4;
        private UIControLib.RoundRect roundRect3;
        private UIControLib.RoundRect roundRect4;
        private UIControLib.RoundRect roundRect5;
        private UIControLib.RoundRect roundRect7;
        private UIControLib.RoundRect roundRect9;
        private UIControLib.RoundRect roundRect6;
        private Button btnSQLite;
        private GroupBox gbRandom;
        private Button btnRandom;
        private TextBox randStr;
        private Button btnRandomCopy;
        private TextBox tbRandomLen;
        private Label labelRandomLen;
    }
}
