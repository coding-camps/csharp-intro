using NModbus;
using NModbus.Serial;
using ScottPlot;
using System.ComponentModel;
using System.IO.Ports;
using Color = System.Drawing.Color;

namespace WinFormsApp01
{
    public partial class FrmMobus : Form
    {
        private SerialPort serialPort = null;
        private IModbusSerialMaster master = null;

        List<DateTime> dataX = new List<DateTime>();
        List<double> dataY = new List<double>();

        public FrmMobus()
        {
            InitializeComponent();
        }

        private void FrmMobus_Load(object sender, EventArgs e)
        {
            radioSerial.Checked = true;

            InitSerialPorts();
            InitSerialSettings();

            InitializeChart();
            InitTimer();
        }

        private void InitSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                cbSerial.Items.Add(ports[i]);
            }

            if (ports.Length > 0)
            {
                cbSerial.SelectedIndex = 0;
            }
        }

        private void InitSerialSettings()
        {
            // combox列表，在控件Item属性中添加
            cbBaud.SelectedIndex = 0;

            // 添加combox列表，方法一
            List<String> cbDataItems = new List<String> { "7 Data Bits", "8 Data Bits" };
            cbData.DataSource = cbDataItems;
            cbData.SelectedIndex = 1;

            // 添加combox列表，方法二
            BindingList<string> cbStopList = new BindingList<string> { "1 stop bit", "2 stop bits" };
            cbStop.DataSource = cbStopList;
            cbStop.SelectedIndex = 0;

            // 添加combox列表，方法三
            List<ParityItem> parityItems = new List<ParityItem>();
            parityItems.Add(new ParityItem() { Name = "None Parity", Value = Parity.None });
            parityItems.Add(new ParityItem() { Name = "Odd Parity", Value = Parity.Odd });
            parityItems.Add(new ParityItem() { Name = "Even Parity", Value = Parity.Even });
            cbParity.DataSource = parityItems;
            cbParity.DisplayMember = "Name";
            cbParity.ValueMember = "Value";
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

        private void InitTimer()
        {
            timerModbus.Interval = 1000;
            timerModbus.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            DateTime now = DateTime.Now;
            Random rand = new Random();
            // double newValue = rand.NextDouble() * 10 + 20; // Random Value between 20 and 30
            double newValue = 0;

            // 读取保持型寄存器
            byte slaveId = Convert.ToByte(tbSlaveID.Text);
            ushort start = 0;
            ushort length = 2;
            byte[] value = ReadHoldingRegisters(slaveId, start, length);
            newValue = Convert.ToDouble(value[0]);

            currentTime.Text = now.ToString("HH:mm:ss");
            currentValue.Text = newValue.ToString("#,##0");

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

        private byte[] ReadHoldingRegisters(byte slaveId, ushort start, ushort length)
        {
            ushort[] data = this.master.ReadHoldingRegisters(slaveId, start, length);
            List<byte> result = new List<byte>();
            foreach (ushort value in data)
            {
                result.AddRange(BitConverter.GetBytes(value));
            }

            return result.ToArray();
        }


        private void radioSerial_CheckedChanged(object sender, EventArgs e)
        {
            gbSerialSettings.Enabled = true;
        }

        private void radioTcpIP_CheckedChanged(object sender, EventArgs e)
        {
            gbSerialSettings.Enabled = false;
        }

        // 连接
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // 确认配置
            string portName = cbSerial.Text;
            if (portName == null || portName.Length == 0)
            {
                MessageBox.Show("没有串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int baudRate = Convert.ToInt32(cbBaud.Text);
            int dataBits = 0;
            if (cbData.SelectedIndex == 0)
            {
                dataBits = 7;
            }
            else if (cbData.SelectedIndex == 1)
            {
                dataBits = 8;
            }

            StopBits stopBits = StopBits.None;
            if (cbStop.SelectedIndex == 0)
            {
                stopBits = StopBits.One;
            }
            else if (cbStop.SelectedIndex == 1)
            {
                stopBits = StopBits.Two;
            }

            Parity parity = (Parity)cbParity.SelectedValue;

            // 串口
            this.serialPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);
            this.serialPort.Open();

            // Modbus Master
            SerialPortAdapter adapter = new SerialPortAdapter(this.serialPort);
            ModbusFactory factory = new ModbusFactory();
            this.master = factory.CreateRtuMaster(adapter);
            this.master.Transport.WriteTimeout = Convert.ToInt32(mtbTimeout.Text);
            this.master.Transport.ReadTimeout = Convert.ToInt32(mtbTimeout.Text);
            this.master.Transport.WaitToRetryMilliseconds = Convert.ToInt32(mtbDisplayPolls.Text);
            this.master.Transport.Retries = 3;

            // 开始
            operState.BackColor = Color.Green;
            operState.Text = "连接";
            timerModbus.Start();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // 断开连接
            if (this.serialPort != null && this.serialPort.IsOpen)
            {
                this.serialPort.Close();
            }

            operState.BackColor = Color.LightGray;
            operState.Text = "断开";
            timerModbus.Stop();
        }
    }

    class ParityItem
    {
        public string Name { get; set; }
        public Parity Value { get; set; }
    }
}
