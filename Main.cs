using FontAwesome.Sharp;
using Sample_2.Forms;
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
        private Form currentChildForm;

        // Constructor
        public Main()
        {
            InitializeComponent();
            buttonBorderRight = new Panel();
            buttonBorderRight.Size = new Size(7, 60);
            panelMenu.Controls.Add(buttonBorderRight);
            this.DoubleBuffered = true;
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            ActiveButton(btnHome, RGBColors.color1);
            OpenChildForm(new Home());
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

                // Main Frame Icon/Title Handling by Active Button
                btnTitle.IconChar = currentButton.IconChar;
                btnTitle.IconColor = RGBColors.color8;
                labelTitle.Text = (string)currentButton.Tag;
                labelTitle.ForeColor = RGBColors.color8;
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
                currentButton.ForeColor = Color.FromArgb(61, 61, 61);
                currentButton.IconColor = Color.FromArgb(61, 61, 61);
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

                /**/
                foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.Padding = new Padding(20, 0, 0, 0);
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.IconSize = 40;
                }
                /**/
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
            panelMainPage.Controls.Add(childForm);
            panelMainPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion

        // Side Menu Button Click Processes
        #region
        private void btnMenu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Login flogin = new Login();
            flogin.Show();
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Home());
        }

        private void btnSetup_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Setup());
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Dashboard());
        }

        private void btnDiagnostic_Click(object sender, System.EventArgs e)
        {
            if (Login.login == true && (Login.type == "sup" || Login.type == "sub"))
            {
                System.Console.WriteLine(Login.username + " " + Login.type);
                ActiveButton(sender, RGBColors.color4);
                OpenChildForm(new Diagnostic());
            }
            else
            {
                MessageBox.Show("Only authorized users! Please log in.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFM_Click(object sender, System.EventArgs e)
        {
            if (Login.login == true && Login.type == "sup")
            {
                ActiveButton(sender, RGBColors.color5);
                OpenChildForm(new FileMng());
            }
            else if (Login.login == true && Login.type == "sub")
            {
                MessageBox.Show("Only super users! Please get contact with your manager.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Only authorized users! Please log in.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new Settings());
        }

        private void btnUser_Click(object sender, System.EventArgs e)
        {
            if (Login.login == true && Login.type == "sup")
            {
                ActiveButton(sender, RGBColors.color1);
                OpenChildForm(new User());
            }
        }
        #endregion

        // Login/Logout Management
        #region
        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            if (Login.login)
            {
                btnLogout.Visible = true;
                btnLogin.Visible = false;
                panelAccount.Visible = true;
                lblAccount.Text = $"Username: {Login.username}\nType: {Login.type}";

                if (Login.type == "sup")
                {
                    btnUser.Visible = true;
                }
                else
                {
                    btnUser.Visible = false;
                }
            }
            if (!Login.login)
            {
                btnLogout.Visible = false;
                panelAccount.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login.cnn.Close();
                Login.cmd.Dispose();
                Login.rdr.Close();
                Login.login = false;
                if (!Login.login)
                {
                    btnLogout.Visible = false;
                    btnLogin.Visible = true;
                    panelAccount.Visible = false;
                    btnUser.Visible = false;
                }
                OpenChildForm(new Home());
                ActiveButton(btnHome, RGBColors.color1);
            }
            else
            {
                // Do something
            }
        }
        #endregion
    }
}
