using ScottPlot;
using System.IO.Ports;

namespace WinFormsApp01
{
    public partial class FrmMobus : Form
    {
        List<DateTime> dataX = new List<DateTime>();
        List<double> dataY = new List<double>();

        public FrmMobus()
        {
            InitializeComponent();
        }

        private void FrmMobus_Load(object sender, EventArgs e)
        {
            radioSerial.Checked = true;

            loadSerialPorts();
            loadSerialSettings();

            InitializeChart();
            timerModbus.Interval = 1000;
            timerModbus.Tick += Timer_Tick;
            timerModbus.Start();
        }

        private void loadSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                cbSerial.Items.Add(ports[i]);
            }
            cbSerial.SelectedIndex = 0;
        }

        private void loadSerialSettings()
        {
            cbBaud.SelectedIndex = 0;
            cbData.SelectedIndex = 1;
            cbStop.SelectedIndex = 0;
            cbParity.SelectedIndex = 0;
        }


        private void InitializeChart()
        {
            // 显示中文
            frmPlot.Plot.Font.Set("宋体");

            // 启用日期时间格式
            frmPlot.Plot.Axes.DateTimeTicksBottom();
            frmPlot.Plot.RenderManager.RenderStarting += (s, e) =>
            {
                Tick[] ticks = frmPlot.Plot.Axes.Bottom.TickGenerator.Ticks;
                for (int i = 0; i < ticks.Length; i++)
                {
                    DateTime dt = DateTime.FromOADate(ticks[i].Position);
                    string label = dt.ToString("HH:mm:ss");
                    ticks[i] = new Tick(ticks[i].Position, label);
                }
            };
            frmPlot.Plot.Axes.SetLimits(0, 1, 20, 30);
            frmPlot.Plot.XLabel("时间");
            frmPlot.Plot.YLabel("温度[°C]");
            frmPlot.Plot.Title("温度监控");

            frmPlot.Plot.Grid.MajorLineColor = Colors.Green.WithOpacity(.3);
            frmPlot.Plot.Grid.MajorLineWidth = 1;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            DateTime now = DateTime.Now;
            Random rand = new Random();
            double newValue = rand.NextDouble() * 10 + 20; // Random Value between 20 and 30

            if (dataX.Count == 25)
            {
                dataX.RemoveAt(0);
                dataY.RemoveAt(0);
            }

            dataX.Add(now);
            dataY.Add(newValue);

            frmPlot.Plot.Clear(); // 清除之前的绘图
            frmPlot.Plot.Add.Scatter(dataX.ToArray(), dataY.ToArray(), color: Colors.Red);
            frmPlot.Plot.Axes.AutoScale();
            frmPlot.Refresh();
        }


        private void radioSerial_CheckedChanged(object sender, EventArgs e)
        {
            gbSerialSettings.Enabled = true;
        }

        private void radioTcpIP_CheckedChanged(object sender, EventArgs e)
        {
            gbSerialSettings.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // 连接
            operState.BackColor = System.Drawing.Color.Green;
            operState.Text = "连接";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // 断开连接
            operState.BackColor = System.Drawing.Color.LightGray;
            operState.Text = "断开";
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 画图
            operState.BackColor = System.Drawing.Color.LightPink;
            operState.Text = "画图";
        }
    }
}
