using FontAwesome.Sharp;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sample_2
{
    public partial class Main : Form
    {

        // Fields
        private Panel buttonBorderRight;
        private IconButton currentButton;

        // Constructor
        public Main()
        {
            InitializeComponent();
            buttonBorderRight = new Panel();
            buttonBorderRight.Size = new Size(7, 60);
            panelMenu.Controls.Add(buttonBorderRight);
            this.DoubleBuffered = true;
        }

        // Side Menu Button Colors
        #region
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(229, 27, 36);
            public static Color color2 = Color.FromArgb(229, 27, 36);
            public static Color color3 = Color.FromArgb(229, 27, 36);
            public static Color color4 = Color.FromArgb(229, 27, 36);
            public static Color color5 = Color.FromArgb(229, 27, 36);
            public static Color color6 = Color.FromArgb(229, 27, 36);
        }
        #endregion

        // Active Side Menu Button Handling
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

                // Button Border Right
                buttonBorderRight.BackColor = color;
                buttonBorderRight.Location = new Point(223, currentButton.Location.Y);
                buttonBorderRight.Visible = true;
                buttonBorderRight.BringToFront();
            }
        }
        #endregion

        // Deactive Side Menu Button Handing
        #region
        private void DeactiveButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(255, 255, 255);
                currentButton.ForeColor = Color.FromArgb(0, 0, 0);
                currentButton.IconColor = Color.FromArgb(0, 0, 0);
            }
        }
        #endregion

        // Menu Collapse / Expand
        #region
        private void CollapseMenu()
        {
            if (panelMenu.Width >= 230)
            {
                panelMenu.Width = 80;
                pboxLogo.Visible = false;
                btnMenu.Dock = DockStyle.Fill;
                btnMenu.IconSize = 28;
                buttonBorderRight.Visible = false;
                /**/
                foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
                {
                    menuButton.Text = "";
                    menuButton.Padding = new Padding(0);
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.IconSize = 32;
                }
                /**/
            }
            else
            {
                panelMenu.Width = 230;
                pboxLogo.Visible = true;
                btnMenu.Dock = DockStyle.Right;
                btnMenu.IconSize = 32;
                buttonBorderRight.Visible = true;
                foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.Padding = new Padding(20, 0, 0, 0);
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.IconSize = 40;
                }
            }
        }
        #endregion

        // Side Menu Button Click Processes //
        #region
        private void btnMenu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
        }

        private void btnSetup_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
        }
        #endregion
    }
}
