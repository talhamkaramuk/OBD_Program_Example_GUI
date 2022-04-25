namespace Sample_2.Forms.DashboardForms
{
    partial class Gauges
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
            this.tabpanelTachometers = new System.Windows.Forms.TableLayoutPanel();
            this.panelSpeed = new System.Windows.Forms.Panel();
            this.tboxSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.gaugeSpeed = new System.Windows.Forms.AGauge();
            this.panelRev = new System.Windows.Forms.Panel();
            this.tboxRev = new System.Windows.Forms.TextBox();
            this.lblRev = new System.Windows.Forms.Label();
            this.gaugeRev = new System.Windows.Forms.AGauge();
            this.panelOilTemp = new System.Windows.Forms.Panel();
            this.tboxOilTemp = new System.Windows.Forms.TextBox();
            this.lblOilTemp = new System.Windows.Forms.Label();
            this.gaugeOilTemp = new System.Windows.Forms.AGauge();
            this.panelOilPress = new System.Windows.Forms.Panel();
            this.tboxOilPress = new System.Windows.Forms.TextBox();
            this.lblOilPress = new System.Windows.Forms.Label();
            this.gaugeOilPress = new System.Windows.Forms.AGauge();
            this.iconOil = new System.Windows.Forms.Label();
            this.iconOilTemp = new System.Windows.Forms.Label();
            this.iconOilPress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpanelTachometers.SuspendLayout();
            this.panelSpeed.SuspendLayout();
            this.panelRev.SuspendLayout();
            this.panelOilTemp.SuspendLayout();
            this.panelOilPress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpanelTachometers
            // 
            this.tabpanelTachometers.ColumnCount = 2;
            this.tabpanelTachometers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpanelTachometers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpanelTachometers.Controls.Add(this.panelSpeed, 0, 0);
            this.tabpanelTachometers.Controls.Add(this.panelRev, 1, 0);
            this.tabpanelTachometers.Controls.Add(this.panelOilTemp, 0, 1);
            this.tabpanelTachometers.Controls.Add(this.panelOilPress, 1, 1);
            this.tabpanelTachometers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanelTachometers.Location = new System.Drawing.Point(0, 0);
            this.tabpanelTachometers.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelTachometers.Name = "tabpanelTachometers";
            this.tabpanelTachometers.RowCount = 2;
            this.tabpanelTachometers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpanelTachometers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabpanelTachometers.Size = new System.Drawing.Size(554, 412);
            this.tabpanelTachometers.TabIndex = 0;
            // 
            // panelSpeed
            // 
            this.panelSpeed.Controls.Add(this.label1);
            this.panelSpeed.Controls.Add(this.tboxSpeed);
            this.panelSpeed.Controls.Add(this.lblSpeed);
            this.panelSpeed.Controls.Add(this.gaugeSpeed);
            this.panelSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpeed.Location = new System.Drawing.Point(0, 0);
            this.panelSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.panelSpeed.Name = "panelSpeed";
            this.panelSpeed.Size = new System.Drawing.Size(277, 206);
            this.panelSpeed.TabIndex = 0;
            // 
            // tboxSpeed
            // 
            this.tboxSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.tboxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxSpeed.Location = new System.Drawing.Point(123, 178);
            this.tboxSpeed.Name = "tboxSpeed";
            this.tboxSpeed.Size = new System.Drawing.Size(31, 19);
            this.tboxSpeed.TabIndex = 5;
            this.tboxSpeed.Text = "0";
            this.tboxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(120, 158);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(36, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "KM/H";
            // 
            // gaugeSpeed
            // 
            this.gaugeSpeed.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeSpeed.BaseArcRadius = 80;
            this.gaugeSpeed.BaseArcStart = 135;
            this.gaugeSpeed.BaseArcSweep = 270;
            this.gaugeSpeed.BaseArcWidth = 2;
            this.gaugeSpeed.Center = new System.Drawing.Point(138, 110);
            this.gaugeSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeSpeed.Location = new System.Drawing.Point(0, 0);
            this.gaugeSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeSpeed.MaxValue = 360F;
            this.gaugeSpeed.MinValue = 0F;
            this.gaugeSpeed.Name = "gaugeSpeed";
            this.gaugeSpeed.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeSpeed.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaugeSpeed.NeedleRadius = 80;
            this.gaugeSpeed.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeSpeed.NeedleWidth = 2;
            this.gaugeSpeed.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeSpeed.ScaleLinesInterInnerRadius = 73;
            this.gaugeSpeed.ScaleLinesInterOuterRadius = 80;
            this.gaugeSpeed.ScaleLinesInterWidth = 1;
            this.gaugeSpeed.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeSpeed.ScaleLinesMajorInnerRadius = 70;
            this.gaugeSpeed.ScaleLinesMajorOuterRadius = 80;
            this.gaugeSpeed.ScaleLinesMajorStepValue = 30F;
            this.gaugeSpeed.ScaleLinesMajorWidth = 2;
            this.gaugeSpeed.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeSpeed.ScaleLinesMinorInnerRadius = 75;
            this.gaugeSpeed.ScaleLinesMinorOuterRadius = 80;
            this.gaugeSpeed.ScaleLinesMinorTicks = 9;
            this.gaugeSpeed.ScaleLinesMinorWidth = 1;
            this.gaugeSpeed.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeSpeed.ScaleNumbersFormat = null;
            this.gaugeSpeed.ScaleNumbersRadius = 95;
            this.gaugeSpeed.ScaleNumbersRotation = 0;
            this.gaugeSpeed.ScaleNumbersStartScaleLine = 0;
            this.gaugeSpeed.ScaleNumbersStepScaleLines = 1;
            this.gaugeSpeed.Size = new System.Drawing.Size(277, 206);
            this.gaugeSpeed.TabIndex = 3;
            this.gaugeSpeed.Text = "aGauge1";
            this.gaugeSpeed.Value = 0F;
            // 
            // panelRev
            // 
            this.panelRev.Controls.Add(this.label2);
            this.panelRev.Controls.Add(this.tboxRev);
            this.panelRev.Controls.Add(this.lblRev);
            this.panelRev.Controls.Add(this.gaugeRev);
            this.panelRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRev.Location = new System.Drawing.Point(277, 0);
            this.panelRev.Margin = new System.Windows.Forms.Padding(0);
            this.panelRev.Name = "panelRev";
            this.panelRev.Size = new System.Drawing.Size(277, 206);
            this.panelRev.TabIndex = 1;
            // 
            // tboxRev
            // 
            this.tboxRev.BackColor = System.Drawing.SystemColors.Control;
            this.tboxRev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxRev.Location = new System.Drawing.Point(123, 178);
            this.tboxRev.Name = "tboxRev";
            this.tboxRev.Size = new System.Drawing.Size(31, 19);
            this.tboxRev.TabIndex = 7;
            this.tboxRev.Text = "0";
            this.tboxRev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRev
            // 
            this.lblRev.AutoSize = true;
            this.lblRev.Location = new System.Drawing.Point(123, 158);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(31, 13);
            this.lblRev.TabIndex = 6;
            this.lblRev.Text = "RPM";
            // 
            // gaugeRev
            // 
            this.gaugeRev.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeRev.BaseArcRadius = 80;
            this.gaugeRev.BaseArcStart = 135;
            this.gaugeRev.BaseArcSweep = 270;
            this.gaugeRev.BaseArcWidth = 2;
            this.gaugeRev.Center = new System.Drawing.Point(138, 110);
            this.gaugeRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeRev.Location = new System.Drawing.Point(0, 0);
            this.gaugeRev.MaxValue = 10F;
            this.gaugeRev.MinValue = 0F;
            this.gaugeRev.Name = "gaugeRev";
            this.gaugeRev.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeRev.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaugeRev.NeedleRadius = 80;
            this.gaugeRev.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeRev.NeedleWidth = 2;
            this.gaugeRev.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeRev.ScaleLinesInterInnerRadius = 73;
            this.gaugeRev.ScaleLinesInterOuterRadius = 80;
            this.gaugeRev.ScaleLinesInterWidth = 1;
            this.gaugeRev.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeRev.ScaleLinesMajorInnerRadius = 70;
            this.gaugeRev.ScaleLinesMajorOuterRadius = 80;
            this.gaugeRev.ScaleLinesMajorStepValue = 1F;
            this.gaugeRev.ScaleLinesMajorWidth = 2;
            this.gaugeRev.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeRev.ScaleLinesMinorInnerRadius = 75;
            this.gaugeRev.ScaleLinesMinorOuterRadius = 80;
            this.gaugeRev.ScaleLinesMinorTicks = 9;
            this.gaugeRev.ScaleLinesMinorWidth = 1;
            this.gaugeRev.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeRev.ScaleNumbersFormat = null;
            this.gaugeRev.ScaleNumbersRadius = 95;
            this.gaugeRev.ScaleNumbersRotation = 0;
            this.gaugeRev.ScaleNumbersStartScaleLine = 0;
            this.gaugeRev.ScaleNumbersStepScaleLines = 1;
            this.gaugeRev.Size = new System.Drawing.Size(277, 206);
            this.gaugeRev.TabIndex = 5;
            this.gaugeRev.Text = "aGauge2";
            this.gaugeRev.Value = 0F;
            // 
            // panelOilTemp
            // 
            this.panelOilTemp.Controls.Add(this.iconOil);
            this.panelOilTemp.Controls.Add(this.iconOilTemp);
            this.panelOilTemp.Controls.Add(this.tboxOilTemp);
            this.panelOilTemp.Controls.Add(this.lblOilTemp);
            this.panelOilTemp.Controls.Add(this.gaugeOilTemp);
            this.panelOilTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOilTemp.Location = new System.Drawing.Point(0, 206);
            this.panelOilTemp.Margin = new System.Windows.Forms.Padding(0);
            this.panelOilTemp.Name = "panelOilTemp";
            this.panelOilTemp.Size = new System.Drawing.Size(277, 206);
            this.panelOilTemp.TabIndex = 2;
            // 
            // tboxOilTemp
            // 
            this.tboxOilTemp.BackColor = System.Drawing.SystemColors.Control;
            this.tboxOilTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxOilTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxOilTemp.Location = new System.Drawing.Point(123, 178);
            this.tboxOilTemp.Name = "tboxOilTemp";
            this.tboxOilTemp.Size = new System.Drawing.Size(31, 19);
            this.tboxOilTemp.TabIndex = 7;
            this.tboxOilTemp.Text = "0";
            this.tboxOilTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOilTemp
            // 
            this.lblOilTemp.AutoSize = true;
            this.lblOilTemp.Location = new System.Drawing.Point(129, 158);
            this.lblOilTemp.Name = "lblOilTemp";
            this.lblOilTemp.Size = new System.Drawing.Size(18, 13);
            this.lblOilTemp.TabIndex = 6;
            this.lblOilTemp.Text = "°C";
            // 
            // gaugeOilTemp
            // 
            this.gaugeOilTemp.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeOilTemp.BaseArcRadius = 80;
            this.gaugeOilTemp.BaseArcStart = 135;
            this.gaugeOilTemp.BaseArcSweep = 270;
            this.gaugeOilTemp.BaseArcWidth = 2;
            this.gaugeOilTemp.Center = new System.Drawing.Point(138, 110);
            this.gaugeOilTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeOilTemp.Location = new System.Drawing.Point(0, 0);
            this.gaugeOilTemp.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeOilTemp.MaxValue = 250F;
            this.gaugeOilTemp.MinValue = 0F;
            this.gaugeOilTemp.Name = "gaugeOilTemp";
            this.gaugeOilTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeOilTemp.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaugeOilTemp.NeedleRadius = 80;
            this.gaugeOilTemp.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeOilTemp.NeedleWidth = 2;
            this.gaugeOilTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeOilTemp.ScaleLinesInterInnerRadius = 73;
            this.gaugeOilTemp.ScaleLinesInterOuterRadius = 80;
            this.gaugeOilTemp.ScaleLinesInterWidth = 1;
            this.gaugeOilTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeOilTemp.ScaleLinesMajorInnerRadius = 70;
            this.gaugeOilTemp.ScaleLinesMajorOuterRadius = 80;
            this.gaugeOilTemp.ScaleLinesMajorStepValue = 50F;
            this.gaugeOilTemp.ScaleLinesMajorWidth = 2;
            this.gaugeOilTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeOilTemp.ScaleLinesMinorInnerRadius = 75;
            this.gaugeOilTemp.ScaleLinesMinorOuterRadius = 80;
            this.gaugeOilTemp.ScaleLinesMinorTicks = 9;
            this.gaugeOilTemp.ScaleLinesMinorWidth = 1;
            this.gaugeOilTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeOilTemp.ScaleNumbersFormat = null;
            this.gaugeOilTemp.ScaleNumbersRadius = 95;
            this.gaugeOilTemp.ScaleNumbersRotation = 0;
            this.gaugeOilTemp.ScaleNumbersStartScaleLine = 0;
            this.gaugeOilTemp.ScaleNumbersStepScaleLines = 1;
            this.gaugeOilTemp.Size = new System.Drawing.Size(277, 206);
            this.gaugeOilTemp.TabIndex = 5;
            this.gaugeOilTemp.Text = "aGauge1";
            this.gaugeOilTemp.Value = 0F;
            // 
            // panelOilPress
            // 
            this.panelOilPress.Controls.Add(this.iconOilPress);
            this.panelOilPress.Controls.Add(this.tboxOilPress);
            this.panelOilPress.Controls.Add(this.lblOilPress);
            this.panelOilPress.Controls.Add(this.gaugeOilPress);
            this.panelOilPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOilPress.Location = new System.Drawing.Point(277, 206);
            this.panelOilPress.Margin = new System.Windows.Forms.Padding(0);
            this.panelOilPress.Name = "panelOilPress";
            this.panelOilPress.Size = new System.Drawing.Size(277, 206);
            this.panelOilPress.TabIndex = 3;
            // 
            // tboxOilPress
            // 
            this.tboxOilPress.BackColor = System.Drawing.SystemColors.Control;
            this.tboxOilPress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxOilPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxOilPress.Location = new System.Drawing.Point(123, 178);
            this.tboxOilPress.Name = "tboxOilPress";
            this.tboxOilPress.Size = new System.Drawing.Size(31, 19);
            this.tboxOilPress.TabIndex = 9;
            this.tboxOilPress.Text = "0";
            this.tboxOilPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOilPress
            // 
            this.lblOilPress.AutoSize = true;
            this.lblOilPress.Location = new System.Drawing.Point(127, 158);
            this.lblOilPress.Name = "lblOilPress";
            this.lblOilPress.Size = new System.Drawing.Size(23, 13);
            this.lblOilPress.TabIndex = 8;
            this.lblOilPress.Text = "Bar";
            // 
            // gaugeOilPress
            // 
            this.gaugeOilPress.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeOilPress.BaseArcRadius = 80;
            this.gaugeOilPress.BaseArcStart = 135;
            this.gaugeOilPress.BaseArcSweep = 270;
            this.gaugeOilPress.BaseArcWidth = 2;
            this.gaugeOilPress.Center = new System.Drawing.Point(138, 110);
            this.gaugeOilPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeOilPress.Location = new System.Drawing.Point(0, 0);
            this.gaugeOilPress.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeOilPress.MaxValue = 7F;
            this.gaugeOilPress.MinValue = 0F;
            this.gaugeOilPress.Name = "gaugeOilPress";
            this.gaugeOilPress.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeOilPress.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaugeOilPress.NeedleRadius = 80;
            this.gaugeOilPress.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeOilPress.NeedleWidth = 2;
            this.gaugeOilPress.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeOilPress.ScaleLinesInterInnerRadius = 73;
            this.gaugeOilPress.ScaleLinesInterOuterRadius = 80;
            this.gaugeOilPress.ScaleLinesInterWidth = 1;
            this.gaugeOilPress.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeOilPress.ScaleLinesMajorInnerRadius = 70;
            this.gaugeOilPress.ScaleLinesMajorOuterRadius = 80;
            this.gaugeOilPress.ScaleLinesMajorStepValue = 1F;
            this.gaugeOilPress.ScaleLinesMajorWidth = 2;
            this.gaugeOilPress.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeOilPress.ScaleLinesMinorInnerRadius = 75;
            this.gaugeOilPress.ScaleLinesMinorOuterRadius = 80;
            this.gaugeOilPress.ScaleLinesMinorTicks = 9;
            this.gaugeOilPress.ScaleLinesMinorWidth = 1;
            this.gaugeOilPress.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeOilPress.ScaleNumbersFormat = null;
            this.gaugeOilPress.ScaleNumbersRadius = 95;
            this.gaugeOilPress.ScaleNumbersRotation = 0;
            this.gaugeOilPress.ScaleNumbersStartScaleLine = 0;
            this.gaugeOilPress.ScaleNumbersStepScaleLines = 1;
            this.gaugeOilPress.Size = new System.Drawing.Size(277, 206);
            this.gaugeOilPress.TabIndex = 7;
            this.gaugeOilPress.Text = "aGauge1";
            this.gaugeOilPress.Value = 0F;
            // 
            // iconOil
            // 
            this.iconOil.Image = global::Sample_2.Properties.Resources.icons8_engine_oil_28;
            this.iconOil.Location = new System.Drawing.Point(12, 15);
            this.iconOil.Name = "iconOil";
            this.iconOil.Size = new System.Drawing.Size(28, 28);
            this.iconOil.TabIndex = 9;
            // 
            // iconOilTemp
            // 
            this.iconOilTemp.Image = global::Sample_2.Properties.Resources.icons8_temperature_22;
            this.iconOilTemp.Location = new System.Drawing.Point(127, 60);
            this.iconOilTemp.Name = "iconOilTemp";
            this.iconOilTemp.Size = new System.Drawing.Size(22, 22);
            this.iconOilTemp.TabIndex = 8;
            // 
            // iconOilPress
            // 
            this.iconOilPress.Image = global::Sample_2.Properties.Resources.icons8_pressure_22;
            this.iconOilPress.Location = new System.Drawing.Point(127, 60);
            this.iconOilPress.Name = "iconOilPress";
            this.iconOilPress.Size = new System.Drawing.Size(22, 22);
            this.iconOilPress.TabIndex = 10;
            this.iconOilPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::Sample_2.Properties.Resources.icons8_speedometer_22;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(119, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "x 1000";
            // 
            // Tachometers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 412);
            this.Controls.Add(this.tabpanelTachometers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tachometers";
            this.Tag = "Tachometers";
            this.Text = "Tachometers";
            this.tabpanelTachometers.ResumeLayout(false);
            this.panelSpeed.ResumeLayout(false);
            this.panelSpeed.PerformLayout();
            this.panelRev.ResumeLayout(false);
            this.panelRev.PerformLayout();
            this.panelOilTemp.ResumeLayout(false);
            this.panelOilTemp.PerformLayout();
            this.panelOilPress.ResumeLayout(false);
            this.panelOilPress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabpanelTachometers;
        private System.Windows.Forms.Panel panelSpeed;
        private System.Windows.Forms.Panel panelRev;
        private System.Windows.Forms.Panel panelOilTemp;
        private System.Windows.Forms.Panel panelOilPress;
        private System.Windows.Forms.TextBox tboxSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.AGauge gaugeSpeed;
        private System.Windows.Forms.TextBox tboxRev;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.AGauge gaugeRev;
        private System.Windows.Forms.TextBox tboxOilTemp;
        private System.Windows.Forms.Label lblOilTemp;
        private System.Windows.Forms.AGauge gaugeOilTemp;
        private System.Windows.Forms.TextBox tboxOilPress;
        private System.Windows.Forms.Label lblOilPress;
        private System.Windows.Forms.AGauge gaugeOilPress;
        private System.Windows.Forms.Label iconOilPress;
        private System.Windows.Forms.Label iconOilTemp;
        private System.Windows.Forms.Label iconOil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}