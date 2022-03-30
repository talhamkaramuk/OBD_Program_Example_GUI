using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Setup : Form
    {

        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cboxCOMPorts.Items.Add(port);
            }
        }

        private void tboxBaudRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Connect & Disconnect
        #region
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = cboxCOMPorts.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cboxBaudRate.Text);
                    serialPort1.Open();
                    btnConnect.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Port is already open", "Warning");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            else
            {
                MessageBox.Show("Port is already close", "Warning");
            }
        }
        #endregion

        private void Setup_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
