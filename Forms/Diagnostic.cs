using FontAwesome.Sharp;
using Sample_2.Forms.DiagnosticForms;
using System;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Diagnostic : Form
    {
        private IconButton currentButton;
        private Form currentChildForm;

        public Diagnostic()
        {
            InitializeComponent();
        }

        private void Diagnostic_Load(object sender, EventArgs e)
        {

        }

        // Open Selected Section Frame
        #region
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion
    }
}
