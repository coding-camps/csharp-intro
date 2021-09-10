using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class FrmMobus : Form
    {
        public FrmMobus()
        {
            InitializeComponent();
        }


        public double[] GetRandomNum(int length)
        {
            double[] getDate = new double[length];
            Random random = new Random(); //创建一个Random实例
            for (int i = 0; i < length; i++)
            {
                getDate[i] = random.Next(1, 100); //使用同一个Random实例生成随机数
            }
            return getDate;
        }
        private void FrmMobus_Load(object sender, EventArgs e)
        {

            double[] dataX = GetRandomNum(20).Distinct().OrderByDescending(x => x).ToArray();
            double[] dataY = GetRandomNum(19).Distinct().OrderByDescending(x => x).ToArray();
            frmPlot.Plot.Add.Scatter(dataX, dataY);
            frmPlot.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
