using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Dashboard : Form
    {

        private string _data;

        public Dashboard()
        {
            InitializeComponent();
            VerticalProgressBarColor.SetState(vpbarFuel, 1);
            VerticalProgressBarColor.SetState(vpbarTemp, 2);
        }

        private void Dashboard_Load(object sender, System.EventArgs e)
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
            if (Convert.ToInt32(value[0]) > 1000)
            {
                Convert.ToInt32(value[0]).Equals(1000);
            }
            else
            {
                vpbarFuel.Value = Convert.ToInt32(value[0]);
            }

            if (Convert.ToInt32(value[1]) > 1000)
            {
                Convert.ToInt32(value[1]).Equals(1000);
            }
            else
            {
                vpbarTemp.Value = Convert.ToInt32(value[1]);
            }

        }
    }
}
