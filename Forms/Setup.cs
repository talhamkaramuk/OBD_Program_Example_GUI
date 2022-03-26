using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Setup : Form
    {

        public Setup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            int yuk = this.Height;
            int gen = this.Width;
            Console.WriteLine("yuk: " + yuk + "\ngen: " + gen);
        }
    }
}
