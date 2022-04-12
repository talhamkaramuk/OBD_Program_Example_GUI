namespace Sample_2.Forms
{
    partial class Dashboard
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
            this.panelDashMain = new System.Windows.Forms.Panel();
            this.tabpanelTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnGraph = new FontAwesome.Sharp.IconButton();
            this.btnFuel = new FontAwesome.Sharp.IconButton();
            this.btnTacho = new FontAwesome.Sharp.IconButton();
            this.btnTools = new FontAwesome.Sharp.IconButton();
            this.tabpanelTopButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashMain
            // 
            this.panelDashMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashMain.Location = new System.Drawing.Point(0, 39);
            this.panelDashMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashMain.Name = "panelDashMain";
            this.panelDashMain.Size = new System.Drawing.Size(554, 412);
            this.panelDashMain.TabIndex = 10;
            // 
            // tabpanelTopButtons
            // 
            this.tabpanelTopButtons.ColumnCount = 5;
            this.tabpanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98195F));
            this.tabpanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41155F));
            this.tabpanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.06498F));
            this.tabpanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.3574F));
            this.tabpanelTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.18412F));
            this.tabpanelTopButtons.Controls.Add(this.btnGraph, 2, 0);
            this.tabpanelTopButtons.Controls.Add(this.btnFuel, 1, 0);
            this.tabpanelTopButtons.Controls.Add(this.btnTacho, 0, 0);
            this.tabpanelTopButtons.Controls.Add(this.btnTools, 3, 0);
            this.tabpanelTopButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanelTopButtons.Location = new System.Drawing.Point(0, 0);
            this.tabpanelTopButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelTopButtons.Name = "tabpanelTopButtons";
            this.tabpanelTopButtons.RowCount = 1;
            this.tabpanelTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelTopButtons.Size = new System.Drawing.Size(554, 39);
            this.tabpanelTopButtons.TabIndex = 9;
            // 
            // btnGraph
            // 
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnGraph.IconColor = System.Drawing.Color.Black;
            this.btnGraph.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGraph.IconSize = 32;
            this.btnGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.Location = new System.Drawing.Point(185, 0);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(0);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(89, 39);
            this.btnGraph.TabIndex = 3;
            this.btnGraph.Text = "Graphics";
            this.btnGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnFuel
            // 
            this.btnFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuel.FlatAppearance.BorderSize = 0;
            this.btnFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuel.IconChar = FontAwesome.Sharp.IconChar.GasPump;
            this.btnFuel.IconColor = System.Drawing.Color.Black;
            this.btnFuel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFuel.IconSize = 32;
            this.btnFuel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuel.Location = new System.Drawing.Point(83, 0);
            this.btnFuel.Margin = new System.Windows.Forms.Padding(0);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(102, 39);
            this.btnFuel.TabIndex = 1;
            this.btnFuel.Text = "Fuel and Oil";
            this.btnFuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // btnTacho
            // 
            this.btnTacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTacho.FlatAppearance.BorderSize = 0;
            this.btnTacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTacho.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btnTacho.IconColor = System.Drawing.Color.Black;
            this.btnTacho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTacho.IconSize = 32;
            this.btnTacho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTacho.Location = new System.Drawing.Point(0, 0);
            this.btnTacho.Margin = new System.Windows.Forms.Padding(0);
            this.btnTacho.Name = "btnTacho";
            this.btnTacho.Size = new System.Drawing.Size(83, 39);
            this.btnTacho.TabIndex = 0;
            this.btnTacho.Text = "Gauges";
            this.btnTacho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTacho.UseVisualStyleBackColor = true;
            this.btnTacho.Click += new System.EventHandler(this.btnTacho_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnTools.IconColor = System.Drawing.Color.Black;
            this.btnTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTools.IconSize = 32;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(274, 0);
            this.btnTools.Margin = new System.Windows.Forms.Padding(0);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(74, 39);
            this.btnTools.TabIndex = 2;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panelDashMain);
            this.Controls.Add(this.tabpanelTopButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabpanelTopButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDashMain;
        private System.Windows.Forms.TableLayoutPanel tabpanelTopButtons;
        private FontAwesome.Sharp.IconButton btnTools;
        private FontAwesome.Sharp.IconButton btnFuel;
        private FontAwesome.Sharp.IconButton btnTacho;
        private FontAwesome.Sharp.IconButton btnGraph;
    }
}