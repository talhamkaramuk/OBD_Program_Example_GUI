namespace Sample_2
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnFM = new FontAwesome.Sharp.IconButton();
            this.btnDiagnostic = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnSetup = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnTitle = new FontAwesome.Sharp.IconButton();
            this.panelMainPage = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPort = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.pbarStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnFM);
            this.panelMenu.Controls.Add(this.btnDiagnostic);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnSetup);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelSpace);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 531);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUser.IconSize = 40;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 460);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(230, 60);
            this.btnUser.TabIndex = 8;
            this.btnUser.Tag = "User Settings";
            this.btnUser.Text = "User Settings";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Visible = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 38;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(230, 60);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFM
            // 
            this.btnFM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFM.FlatAppearance.BorderSize = 0;
            this.btnFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFM.IconChar = FontAwesome.Sharp.IconChar.Folder;
            this.btnFM.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFM.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFM.IconSize = 38;
            this.btnFM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFM.Location = new System.Drawing.Point(0, 340);
            this.btnFM.Name = "btnFM";
            this.btnFM.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFM.Size = new System.Drawing.Size(230, 60);
            this.btnFM.TabIndex = 5;
            this.btnFM.Tag = "File Manager";
            this.btnFM.Text = "File Manager";
            this.btnFM.UseVisualStyleBackColor = true;
            this.btnFM.Click += new System.EventHandler(this.btnFM_Click);
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnostic.FlatAppearance.BorderSize = 0;
            this.btnDiagnostic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiagnostic.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnDiagnostic.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDiagnostic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiagnostic.IconSize = 38;
            this.btnDiagnostic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnostic.Location = new System.Drawing.Point(0, 280);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDiagnostic.Size = new System.Drawing.Size(230, 60);
            this.btnDiagnostic.TabIndex = 4;
            this.btnDiagnostic.Tag = "Diagnostic";
            this.btnDiagnostic.Text = "Diagnostic";
            this.btnDiagnostic.UseVisualStyleBackColor = true;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 38;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 220);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 60);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetup.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.btnSetup.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSetup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetup.IconSize = 38;
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 160);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(230, 60);
            this.btnSetup.TabIndex = 2;
            this.btnSetup.Tag = "Setup";
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 38;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(230, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelSpace
            // 
            this.panelSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpace.Location = new System.Drawing.Point(0, 80);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(230, 20);
            this.panelSpace.TabIndex = 7;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Controls.Add(this.pboxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 32;
            this.btnMenu.Location = new System.Drawing.Point(173, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(57, 80);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pboxLogo
            // 
            this.pboxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(0, 0);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(174, 80);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelAccount);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.btnLogin);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.btnTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(230, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(554, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.lblAccount);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAccount.Location = new System.Drawing.Point(354, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(100, 80);
            this.panelAccount.TabIndex = 0;
            // 
            // lblAccount
            // 
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAccount.Location = new System.Drawing.Point(0, 0);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAccount.Size = new System.Drawing.Size(100, 80);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "account details";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.Location = new System.Drawing.Point(454, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLogout.Size = new System.Drawing.Size(50, 80);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 32;
            this.btnLogin.Location = new System.Drawing.Point(504, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLogin.Size = new System.Drawing.Size(50, 80);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLogin_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.Location = new System.Drawing.Point(60, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(494, 80);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "title here";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTitle.IconColor = System.Drawing.Color.Black;
            this.btnTitle.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTitle.IconSize = 32;
            this.btnTitle.Location = new System.Drawing.Point(0, 0);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(0);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(60, 80);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // panelMainPage
            // 
            this.panelMainPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPage.Location = new System.Drawing.Point(230, 80);
            this.panelMainPage.Name = "panelMainPage";
            this.panelMainPage.Size = new System.Drawing.Size(554, 451);
            this.panelMainPage.TabIndex = 2;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStatus.Controls.Add(this.tableLayoutPanel1);
            this.panelStatus.Controls.Add(this.pbarStatus);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 531);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(784, 30);
            this.panelStatus.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.292181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.74897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5144F));
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBaudRate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBaudRate, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(537, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(243, 26);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPort.Location = new System.Drawing.Point(0, 0);
            this.labelPort.Margin = new System.Windows.Forms.Padding(0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(63, 26);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port:";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPort.Location = new System.Drawing.Point(63, 0);
            this.lblPort.Margin = new System.Windows.Forms.Padding(0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(44, 26);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "COM9";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(110, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 20);
            this.panel1.TabIndex = 2;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBaudRate.Location = new System.Drawing.Point(115, 0);
            this.labelBaudRate.Margin = new System.Windows.Forms.Padding(0);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(65, 26);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Baud Rate:";
            this.labelBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaudRate.Location = new System.Drawing.Point(183, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(57, 26);
            this.lblBaudRate.TabIndex = 4;
            this.lblBaudRate.Text = "921000";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbarStatus
            // 
            this.pbarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbarStatus.ForeColor = System.Drawing.Color.Lime;
            this.pbarStatus.Location = new System.Drawing.Point(115, 8);
            this.pbarStatus.Maximum = 1;
            this.pbarStatus.Name = "pbarStatus";
            this.pbarStatus.Size = new System.Drawing.Size(30, 13);
            this.pbarStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Connection Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelMainPage);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Title | HEMA Industy Inc.";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pboxLogo;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSetup;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton btnTitle;
        private System.Windows.Forms.Panel panelMainPage;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ProgressBar pbarStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private FontAwesome.Sharp.IconButton btnFM;
        private FontAwesome.Sharp.IconButton btnDiagnostic;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Label lblAccount;
        private FontAwesome.Sharp.IconButton btnUser;
    }
}

