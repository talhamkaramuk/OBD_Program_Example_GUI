using FontAwesome.Sharp;
using Sample_2.Forms.DashboardForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sample_2.Forms
{
    public partial class Dashboard : Form
    {
        private IconButton currentButton;
        private Form currentChildForm;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            ActiveButton(btnTacho, RGBColors.color1);
            OpenChildForm(new Tachometers());
        }

        // Button Colors
        #region
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(229, 27, 36);
            public static Color color2 = Color.FromArgb(229, 27, 36);
            public static Color color3 = Color.FromArgb(229, 27, 36);
            public static Color color4 = Color.FromArgb(229, 27, 36);
            public static Color color5 = Color.FromArgb(229, 27, 36);
            public static Color color6 = Color.FromArgb(229, 27, 36);
            public static Color color7 = Color.FromArgb(68, 101, 155);
            public static Color color8 = Color.FromArgb(61, 61, 61);
        }
        #endregion

        // Active Button Handling
        #region
        private void ActiveButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DeactiveButton();

                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(199, 200, 201);
                currentButton.ForeColor = Color.FromArgb(0, 0, 0);
                currentButton.IconColor = color;
            }
        }
        #endregion

        // Deactive Top Menu Button Handling
        #region
        private void DeactiveButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(240, 240, 240);
                currentButton.ForeColor = Color.FromArgb(61, 61, 61);
                currentButton.IconColor = Color.FromArgb(61, 61, 61);
            }
        }
        #endregion

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
            panelDashMain.Controls.Add(childForm);
            panelDashMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion

        // Top Menu Button Processes
        #region
        private void btnTacho_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Tachometers());
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Fuel());
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Graphs());
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Tools());
        }
        #endregion

    }
}
