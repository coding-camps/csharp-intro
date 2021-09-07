using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp01
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            initBtn1();
            initBtnList();
        }

        private void btnTest01_Click(object sender, EventArgs e)
        {
            // 点击时改变按钮文字颜色，点击后按钮文字颜色保持不变。
            btnTest01.ForeColor = Color.BlueViolet;
        }

        private void btnTest01_MouseEnter(object sender, EventArgs e)
        {
            // 鼠标进入按钮内时，按钮文字内容变化
            btnTest01.Text = "按钮01";
        }

        private void btnTest01_MouseLeave(object sender, EventArgs e)
        {
            // 鼠标离开按钮时，按钮文字内容恢复
            btnTest01.Text = "btnTest01";
        }

        // 新创建一个按钮 newBtn1
        private Button newBtn1;

        private void initBtn1()
        {
            // newBtn1 的创建过程
            newBtn1 = new Button();
            newBtn1.Text = "自创按钮1";
            newBtn1.Location = new Point(300, 36);
            newBtn1.Size = new Size(168, 98);
            newBtn1.Click += newBtn1_Click;
            Controls.Add(newBtn1);
        }

        private void newBtn1_Click(object sender, EventArgs e)
        {
            // newBtn1 的click事件
            newBtn1.ForeColor = Color.CadetBlue;
        }

        private void initBtnList()
        {
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = $"按钮-{i + 1}";
                btn.Location = new Point(30 + i * 200, 36);
                btn.Size = new Size(168, 98);
                btn.Click += btnList_Click;
                // Controls.Add(btn);
                this.groupBox2.Controls.Add(btn);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // Button btn = sender as Button; // 此行代码与下方代码相同
            Button btn = (Button)sender;
            btn.ForeColor = Color.HotPink;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // 点击登录按钮

            // 获取用户输入信息
            String inputUsername = textBoxUsername.Text;
            String inputPassword = textBoxPassword.Text;

            // 验证用户输入信息
            if (inputUsername == null || inputPassword == null)
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }

            if (inputUsername != "admin")
            {
                MessageBox.Show("用户名不存在！\n请重新输入。");
                textBoxUsername.Text = "";
                return;
            }

            if (inputPassword != "admin")
            {
                MessageBox.Show("密码错误！\n请重新输入。");
                textBoxPassword.Text = "";
                return;
            }

            // 登录成功
            // Form mainForm = new MainForm(inputUsername);
            Constrants.INSTANCE.username = inputUsername;
            Form mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnOpenFrm_Click(object sender, EventArgs e)
        {
            Form frmInfo = new FrmMsg();
            frmInfo.Show();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            // FF4. 使用委托
            DelegateUtil.FrmToFrmMsgAction(this.textMsg.Text);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // 生成随机字符串
            string letters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            RandomNumberGenerator generator = RandomNumberGenerator.Create();
            StringBuilder stringBuilder = new StringBuilder();
            byte[] randombytes = new byte[1];
            int len = int.Parse(tbRandomLen.Text);
            for (int i = 0; i < len; i++)
            {
                generator.GetBytes(randombytes);
                int index = randombytes[0] % letters.Length;
                stringBuilder.Append(letters[index]);
            }
            randStr.Text = stringBuilder.ToString();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            // 复制随机字符串至剪切板
            Clipboard.SetText(randStr.Text);
            MessageBox.Show("文本已复制到剪切板。");
        }

        private void btnModbus_Click(object sender, EventArgs e)
        {
            Form frmModbus = new FrmMobus();
            frmModbus.ShowDialog();
        }
    }
}
