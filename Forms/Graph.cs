using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private string _data;

        private void Form4_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                _data = serialPort1.ReadLine();
                this.Invoke(new EventHandler(displayData_event));

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} " + ex.GetType().Name);
            }
        }

        private void displayData_event(object sender, EventArgs e)
        {
            string[] value = _data.Split('/');
            chartSpeed.Series["Speed"].Points.AddY(Convert.ToInt32(value[0]));
            chartFuel.Series["Fuel"].Points.AddY(Convert.ToInt32(value[1]));
            lblSpeed.Text = value[0];
            lblFuel.Text = value[1];
        }
    }
}
