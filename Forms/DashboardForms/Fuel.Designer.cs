namespace Sample_2.Forms.DashboardForms
{
    partial class Fuel
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
            this.tabpanelFuel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblvalTemp = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblvalFuel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRemDist = new System.Windows.Forms.Label();
            this.lblvalRemDist = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblvalDistance = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInsFuelCons = new System.Windows.Forms.Label();
            this.lblvalInsFuelCons = new System.Windows.Forms.Label();
            this.subtabFuelCons = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalFuelCons = new System.Windows.Forms.Label();
            this.lblvalTotalFuelCons = new System.Windows.Forms.Label();
            this.vpbarFuel = new VerticalProgressBar();
            this.vpbarTemp = new VerticalProgressBar();
            this.iconFuel = new System.Windows.Forms.Label();
            this.iconTemp = new System.Windows.Forms.Label();
            this.tabpanelFuel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.subtabFuelCons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpanelFuel
            // 
            this.tabpanelFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabpanelFuel.ColumnCount = 3;
            this.tabpanelFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabpanelFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabpanelFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabpanelFuel.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tabpanelFuel.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tabpanelFuel.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tabpanelFuel.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tabpanelFuel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tabpanelFuel.Controls.Add(this.subtabFuelCons, 0, 0);
            this.tabpanelFuel.Location = new System.Drawing.Point(0, 0);
            this.tabpanelFuel.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelFuel.Name = "tabpanelFuel";
            this.tabpanelFuel.RowCount = 2;
            this.tabpanelFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabpanelFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabpanelFuel.Size = new System.Drawing.Size(380, 412);
            this.tabpanelFuel.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lblTemp, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblvalTemp, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(252, 206);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(128, 206);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemp.Location = new System.Drawing.Point(4, 1);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(120, 60);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperature";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalTemp
            // 
            this.lblvalTemp.BackColor = System.Drawing.Color.White;
            this.lblvalTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvalTemp.Location = new System.Drawing.Point(1, 62);
            this.lblvalTemp.Margin = new System.Windows.Forms.Padding(0);
            this.lblvalTemp.Name = "lblvalTemp";
            this.lblvalTemp.Size = new System.Drawing.Size(126, 143);
            this.lblvalTemp.TabIndex = 1;
            this.lblvalTemp.Text = "Data";
            this.lblvalTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lblFuel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblvalFuel, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(126, 206);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(126, 206);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFuel.Location = new System.Drawing.Point(4, 1);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(118, 60);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel";
            this.lblFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalFuel
            // 
            this.lblvalFuel.BackColor = System.Drawing.Color.White;
            this.lblvalFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvalFuel.Location = new System.Drawing.Point(1, 62);
            this.lblvalFuel.Margin = new System.Windows.Forms.Padding(0);
            this.lblvalFuel.Name = "lblvalFuel";
            this.lblvalFuel.Size = new System.Drawing.Size(124, 143);
            this.lblvalFuel.TabIndex = 1;
            this.lblvalFuel.Text = "Data";
            this.lblvalFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblRemDist, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblvalRemDist, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 206);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(126, 206);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lblRemDist
            // 
            this.lblRemDist.AutoSize = true;
            this.lblRemDist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemDist.Location = new System.Drawing.Point(4, 1);
            this.lblRemDist.Name = "lblRemDist";
            this.lblRemDist.Size = new System.Drawing.Size(118, 60);
            this.lblRemDist.TabIndex = 0;
            this.lblRemDist.Text = "Remaining Distance";
            this.lblRemDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalRemDist
            // 
            this.lblvalRemDist.BackColor = System.Drawing.Color.White;
            this.lblvalRemDist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvalRemDist.Location = new System.Drawing.Point(1, 62);
            this.lblvalRemDist.Margin = new System.Windows.Forms.Padding(0);
            this.lblvalRemDist.Name = "lblvalRemDist";
            this.lblvalRemDist.Size = new System.Drawing.Size(124, 143);
            this.lblvalRemDist.TabIndex = 1;
            this.lblvalRemDist.Text = "label10";
            this.lblvalRemDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDistance, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblvalDistance, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(252, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(128, 206);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDistance.Location = new System.Drawing.Point(4, 1);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(120, 60);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distance";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalDistance
            // 
            this.lblvalDistance.BackColor = System.Drawing.Color.White;
            this.lblvalDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvalDistance.Location = new System.Drawing.Point(1, 62);
            this.lblvalDistance.Margin = new System.Windows.Forms.Padding(0);
            this.lblvalDistance.Name = "lblvalDistance";
            this.lblvalDistance.Size = new System.Drawing.Size(126, 143);
            this.lblvalDistance.TabIndex = 1;
            this.lblvalDistance.Text = "label6";
            this.lblvalDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblInsFuelCons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblvalInsFuelCons, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(126, 206);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblInsFuelCons
            // 
            this.lblInsFuelCons.AutoSize = true;
            this.lblInsFuelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInsFuelCons.Location = new System.Drawing.Point(4, 1);
            this.lblInsFuelCons.Name = "lblInsFuelCons";
            this.lblInsFuelCons.Size = new System.Drawing.Size(118, 60);
            this.lblInsFuelCons.TabIndex = 0;
            this.lblInsFuelCons.Text = "Instant Fuel Consumption";
            this.lblInsFuelCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalInsFuelCons
            // 
            this.lblvalInsFuelCons.BackColor = System.Drawing.Color.White;
            this.lblvalInsFuelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvalInsFuelCons.Location = new System.Drawing.Point(1, 62);
            this.lblvalInsFuelCons.Margin = new System.Windows.Forms.Padding(0);
            this.lblvalInsFuelCons.Name = "lblvalInsFuelCons";
            this.lblvalInsFuelCons.Size = new System.Drawing.Size(124, 143);
            this.lblvalInsFuelCons.TabIndex = 1;
            this.lblvalInsFuelCons.Text = "label4";
            this.lblvalInsFuelCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtabFuelCons
            // 
            this.subtabFuelCons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.subtabFuelCons.ColumnCount = 1;
            this.subtabFuelCons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subtabFuelCons.Controls.Add(this.lblTotalFuelCons, 0, 0);
            this.subtabFuelCons.Controls.Add(this.lblvalTotalFuelCons, 0, 1);
            this.subtabFuelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtabFuelCons.Location = new System.Drawing.Point(0, 0);
            this.subtabFuelCons.Margin = new System.Windows.Forms.Padding(0);
            this.subtabFuelCons.Name = "subtabFuelCons";
            this.subtabFuelCons.RowCount = 2;
            this.subtabFuelCons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.subtabFuelCons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.subtabFuelCons.Size = new System.Drawing.Size(126, 206);
            this.subtabFuelCons.TabIndex = 0;
            // 
            // lblTotalFuelCons
            // 
            this.lblTotalFuelCons.AutoSize = true;
            this.lblTotalFuelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalFuelCons.Location = new System.Drawing.Point(4, 1);
            this.lblTotalFuelCons.Name = "lblTotalFuelCons";
            this.lblTotalFuelCons.Size = new System.Drawing.Size(118, 60);
            this.lblTotalFuelCons.TabIndex = 0;
            this.lblTotalFuelCons.Text = "Total Fuel Consumption";
            this.lblTotalFuelCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvalTotalFuelCons
            // 
            this.lblvalTotalFuelCons.BackColor = System.Drawing.Color.White;
            this.lblvalTotalFuelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblvalTotalFuelCons.Location = new System.Drawing.Point(1, 62);
            this.lblvalTotalFuelCons.Margin = new System.Windows.Forms.Padding(0);
            this.lblvalTotalFuelCons.Name = "lblvalTotalFuelCons";
            this.lblvalTotalFuelCons.Size = new System.Drawing.Size(124, 143);
            this.lblvalTotalFuelCons.TabIndex = 1;
            this.lblvalTotalFuelCons.Text = "label2";
            this.lblvalTotalFuelCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vpbarFuel
            // 
            this.vpbarFuel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vpbarFuel.Location = new System.Drawing.Point(406, 9);
            this.vpbarFuel.Margin = new System.Windows.Forms.Padding(0);
            this.vpbarFuel.Name = "vpbarFuel";
            this.vpbarFuel.Size = new System.Drawing.Size(44, 394);
            this.vpbarFuel.TabIndex = 2;
            // 
            // vpbarTemp
            // 
            this.vpbarTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vpbarTemp.Location = new System.Drawing.Point(482, 9);
            this.vpbarTemp.Margin = new System.Windows.Forms.Padding(0);
            this.vpbarTemp.Name = "vpbarTemp";
            this.vpbarTemp.Size = new System.Drawing.Size(44, 394);
            this.vpbarTemp.TabIndex = 1;
            // 
            // iconFuel
            // 
            this.iconFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFuel.BackColor = System.Drawing.Color.Transparent;
            this.iconFuel.Image = global::Sample_2.Properties.Resources.icons8_gas_station_32;
            this.iconFuel.Location = new System.Drawing.Point(412, 190);
            this.iconFuel.Name = "iconFuel";
            this.iconFuel.Size = new System.Drawing.Size(32, 32);
            this.iconFuel.TabIndex = 3;
            // 
            // iconTemp
            // 
            this.iconTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTemp.BackColor = System.Drawing.Color.Transparent;
            this.iconTemp.Image = global::Sample_2.Properties.Resources.icons8_thermometer_32;
            this.iconTemp.Location = new System.Drawing.Point(488, 190);
            this.iconTemp.Name = "iconTemp";
            this.iconTemp.Size = new System.Drawing.Size(32, 32);
            this.iconTemp.TabIndex = 4;
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 412);
            this.Controls.Add(this.iconTemp);
            this.Controls.Add(this.iconFuel);
            this.Controls.Add(this.vpbarFuel);
            this.Controls.Add(this.vpbarTemp);
            this.Controls.Add(this.tabpanelFuel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fuel";
            this.Tag = "Fuel";
            this.Text = "Fuel";
            this.tabpanelFuel.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.subtabFuelCons.ResumeLayout(false);
            this.subtabFuelCons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabpanelFuel;
        private System.Windows.Forms.TableLayoutPanel subtabFuelCons;
        private System.Windows.Forms.Label lblTotalFuelCons;
        private System.Windows.Forms.Label lblvalTotalFuelCons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblvalTemp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblvalFuel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblRemDist;
        private System.Windows.Forms.Label lblvalRemDist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblvalDistance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInsFuelCons;
        private System.Windows.Forms.Label lblvalInsFuelCons;
        private VerticalProgressBar vpbarTemp;
        private VerticalProgressBar vpbarFuel;
        private System.Windows.Forms.Label iconFuel;
        private System.Windows.Forms.Label iconTemp;
    }
}