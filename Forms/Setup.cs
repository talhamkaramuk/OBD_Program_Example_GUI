using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Setup : Form
    {
        // Constructor
        public Setup()
        {
            InitializeComponent();
        }

        // Get Serial Ports
        private void Setup_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cboxCOMPorts.Items.Add(port);
            }
            tboxBaudRate.Enabled = false;
        }

        // Connect & Disconnect
        #region
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboxCOMPorts.Text;
                if (cboxBaudRate.Enabled && !tboxBaudRate.Enabled)
                {
                    serialPort1.BaudRate = Convert.ToInt32(cboxBaudRate.Text);
                }
                if (!cboxBaudRate.Enabled && tboxBaudRate.Enabled)
                {
                    serialPort1.BaudRate = Convert.ToInt32(tboxBaudRate.Text);
                }
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    btnConnect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                if (!serialPort1.IsOpen)
                {
                    btnConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Handle Baud Rate
        #region
        private void tboxBaudRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkboxBaudRate_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkboxBaudRate.Checked)
            {
                tboxBaudRate.Enabled = false;
                cboxBaudRate.Enabled = true;
            }
            else if (checkboxBaudRate.Checked)
            {
                tboxBaudRate.Enabled = true;
                cboxBaudRate.Enabled = false;
            }
        }
        #endregion

        private void Setup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
