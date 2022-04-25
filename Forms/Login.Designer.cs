namespace Sample_2.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.tabpanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pboxTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bottomBorder2 = new System.Windows.Forms.Panel();
            this.bottomBorder1 = new System.Windows.Forms.Panel();
            this.pboxPassword = new System.Windows.Forms.PictureBox();
            this.pboxUsername = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.tabpanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTitle)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.tabpanelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(334, 141);
            this.panelTitle.TabIndex = 0;
            // 
            // tabpanelTitle
            // 
            this.tabpanelTitle.ColumnCount = 1;
            this.tabpanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpanelTitle.Controls.Add(this.pboxTitle, 0, 0);
            this.tabpanelTitle.Controls.Add(this.lblTitle, 0, 1);
            this.tabpanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanelTitle.Location = new System.Drawing.Point(0, 0);
            this.tabpanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelTitle.Name = "tabpanelTitle";
            this.tabpanelTitle.RowCount = 2;
            this.tabpanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tabpanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanelTitle.Size = new System.Drawing.Size(334, 141);
            this.tabpanelTitle.TabIndex = 0;
            // 
            // pboxTitle
            // 
            this.pboxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxTitle.Image = global::Sample_2.Properties.Resources.icons8_user_48;
            this.pboxTitle.Location = new System.Drawing.Point(0, 0);
            this.pboxTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pboxTitle.Name = "pboxTitle";
            this.pboxTitle.Size = new System.Drawing.Size(334, 94);
            this.pboxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxTitle.TabIndex = 0;
            this.pboxTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(0, 94);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 47);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "USER LOGIN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.bottomBorder2);
            this.panelMain.Controls.Add(this.bottomBorder1);
            this.panelMain.Controls.Add(this.pboxPassword);
            this.panelMain.Controls.Add(this.pboxUsername);
            this.panelMain.Controls.Add(this.btnBack);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.tboxPassword);
            this.panelMain.Controls.Add(this.tboxUsername);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 141);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(334, 250);
            this.panelMain.TabIndex = 0;
            // 
            // bottomBorder2
            // 
            this.bottomBorder2.BackColor = System.Drawing.Color.Silver;
            this.bottomBorder2.Location = new System.Drawing.Point(46, 108);
            this.bottomBorder2.Name = "bottomBorder2";
            this.bottomBorder2.Size = new System.Drawing.Size(253, 2);
            this.bottomBorder2.TabIndex = 9;
            // 
            // bottomBorder1
            // 
            this.bottomBorder1.BackColor = System.Drawing.Color.Silver;
            this.bottomBorder1.Location = new System.Drawing.Point(46, 64);
            this.bottomBorder1.Name = "bottomBorder1";
            this.bottomBorder1.Size = new System.Drawing.Size(253, 2);
            this.bottomBorder1.TabIndex = 8;
            // 
            // pboxPassword
            // 
            this.pboxPassword.Image = global::Sample_2.Properties.Resources.icons8_lock_24;
            this.pboxPassword.Location = new System.Drawing.Point(46, 78);
            this.pboxPassword.Name = "pboxPassword";
            this.pboxPassword.Size = new System.Drawing.Size(24, 24);
            this.pboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxPassword.TabIndex = 7;
            this.pboxPassword.TabStop = false;
            // 
            // pboxUsername
            // 
            this.pboxUsername.Image = global::Sample_2.Properties.Resources.icons8_user_24;
            this.pboxUsername.Location = new System.Drawing.Point(46, 34);
            this.pboxUsername.Name = "pboxUsername";
            this.pboxUsername.Size = new System.Drawing.Size(24, 24);
            this.pboxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxUsername.TabIndex = 6;
            this.pboxUsername.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(105, 192);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(46, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(253, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tboxPassword
            // 
            this.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassword.Location = new System.Drawing.Point(76, 78);
            this.tboxPassword.MaxLength = 8;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '•';
            this.tboxPassword.Size = new System.Drawing.Size(223, 24);
            this.tboxPassword.TabIndex = 3;
            // 
            // tboxUsername
            // 
            this.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxUsername.Location = new System.Drawing.Point(76, 34);
            this.tboxUsername.MaxLength = 8;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(223, 24);
            this.tboxUsername.TabIndex = 2;
            this.tboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUsername_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 391);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(350, 430);
            this.MinimumSize = new System.Drawing.Size(350, 430);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelTitle.ResumeLayout(false);
            this.tabpanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTitle)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TableLayoutPanel tabpanelTitle;
        private System.Windows.Forms.PictureBox pboxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.PictureBox pboxUsername;
        private System.Windows.Forms.Panel bottomBorder2;
        private System.Windows.Forms.Panel bottomBorder1;
        private System.Windows.Forms.PictureBox pboxPassword;
    }
}