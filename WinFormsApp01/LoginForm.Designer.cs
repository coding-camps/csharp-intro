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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            groupBox1.SuspendLayout();
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 929);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnTest01);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest01;
        private GroupBox groupBox1;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private GroupBox groupBox2;
    }
}
