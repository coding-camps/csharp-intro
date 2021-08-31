using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class FrmMsg : Form
    {
        public FrmMsg()
        {
            InitializeComponent();
            // FF3. 绑定委托
            DelegateUtil.FrmToFrmMsgAction = ShowMsg;
        }

        // FF2. 写方法
        private void ShowMsg(string obj)
        {
            this.labelMsg.Text = obj;
        }
    }
}
