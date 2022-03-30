using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class FileMng : Form
    {
        private string userName = SystemInformation.UserName;

        public FileMng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "HEX Files (*.hex)|*.hex|Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.Title = "Open HEX File";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] lines = File.ReadAllLines(openFileDialog1.FileName);
            textBox1.Text = string.Join(Environment.NewLine, lines);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "HEX Files (*.hex)|*.hex|Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.InitialDirectory = $"C:\\Users\\{userName}\\Documents";
            //saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }

        }

        private void FileMng_Load(object sender, EventArgs e)
        {
            Console.WriteLine(userName);
        }
    }
}
