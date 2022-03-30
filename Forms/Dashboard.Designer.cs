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
            this.components = new System.ComponentModel.Container();
            this.gaugeRPM = new System.Windows.Forms.AGauge();
            this.labelRPM = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.gaugeSpeed = new System.Windows.Forms.AGauge();
            this.tboxRPM = new System.Windows.Forms.TextBox();
            this.tboxSpeed = new System.Windows.Forms.TextBox();
            this.instantFuel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.avgFuel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalDistance = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picboxTemp = new System.Windows.Forms.PictureBox();
            this.vpbarTemp = new VerticalProgressBar();
            this.picboxFuel = new System.Windows.Forms.PictureBox();
            this.vpbarFuel = new VerticalProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.instantFuel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.avgFuel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.totalDistance.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFuel)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gaugeRPM
            // 
            this.gaugeRPM.BackColor = System.Drawing.Color.White;
            this.gaugeRPM.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeRPM.BaseArcRadius = 80;
            this.gaugeRPM.BaseArcStart = 135;
            this.gaugeRPM.BaseArcSweep = 270;
            this.gaugeRPM.BaseArcWidth = 2;
            this.gaugeRPM.Center = new System.Drawing.Point(100, 100);
            this.gaugeRPM.Location = new System.Drawing.Point(299, 233);
            this.gaugeRPM.MaxValue = 10F;
            this.gaugeRPM.MinValue = 0F;
            this.gaugeRPM.Name = "gaugeRPM";
            this.gaugeRPM.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeRPM.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaugeRPM.NeedleRadius = 80;
            this.gaugeRPM.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeRPM.NeedleWidth = 3;
            this.gaugeRPM.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeRPM.ScaleLinesInterInnerRadius = 73;
            this.gaugeRPM.ScaleLinesInterOuterRadius = 80;
            this.gaugeRPM.ScaleLinesInterWidth = 1;
            this.gaugeRPM.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeRPM.ScaleLinesMajorInnerRadius = 70;
            this.gaugeRPM.ScaleLinesMajorOuterRadius = 80;
            this.gaugeRPM.ScaleLinesMajorStepValue = 1F;
            this.gaugeRPM.ScaleLinesMajorWidth = 2;
            this.gaugeRPM.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeRPM.ScaleLinesMinorInnerRadius = 75;
            this.gaugeRPM.ScaleLinesMinorOuterRadius = 80;
            this.gaugeRPM.ScaleLinesMinorTicks = 9;
            this.gaugeRPM.ScaleLinesMinorWidth = 1;
            this.gaugeRPM.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeRPM.ScaleNumbersFormat = null;
            this.gaugeRPM.ScaleNumbersRadius = 95;
            this.gaugeRPM.ScaleNumbersRotation = 0;
            this.gaugeRPM.ScaleNumbersStartScaleLine = 0;
            this.gaugeRPM.ScaleNumbersStepScaleLines = 1;
            this.gaugeRPM.Size = new System.Drawing.Size(205, 184);
            this.gaugeRPM.TabIndex = 0;
            this.gaugeRPM.Value = 4.5F;
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRPM.Location = new System.Drawing.Point(368, 350);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(66, 13);
            this.labelRPM.TabIndex = 3;
            this.labelRPM.Text = "RPM x 1000";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSpeed.Location = new System.Drawing.Point(116, 350);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(36, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "KM/H";
            // 
            // gaugeSpeed
            // 
            this.gaugeSpeed.BackColor = System.Drawing.Color.White;
            this.gaugeSpeed.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeSpeed.BaseArcRadius = 80;
            this.gaugeSpeed.BaseArcStart = 135;
            this.gaugeSpeed.BaseArcSweep = 270;
            this.gaugeSpeed.BaseArcWidth = 2;
            this.gaugeSpeed.Center = new System.Drawing.Point(100, 100);
            this.gaugeSpeed.Location = new System.Drawing.Point(32, 233);
            this.gaugeSpeed.MaxValue = 320F;
            this.gaugeSpeed.MinValue = 0F;
            this.gaugeSpeed.Name = "gaugeSpeed";
            this.gaugeSpeed.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeSpeed.NeedleColor2 = System.Drawing.Color.DimGray;
            this.gaugeSpeed.NeedleRadius = 80;
            this.gaugeSpeed.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.gaugeSpeed.NeedleWidth = 3;
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
            this.gaugeSpeed.Size = new System.Drawing.Size(205, 184);
            this.gaugeSpeed.TabIndex = 4;
            this.gaugeSpeed.Value = 134F;
            // 
            // tboxRPM
            // 
            this.tboxRPM.BackColor = System.Drawing.SystemColors.Control;
            this.tboxRPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxRPM.Location = new System.Drawing.Point(381, 391);
            this.tboxRPM.Name = "tboxRPM";
            this.tboxRPM.Size = new System.Drawing.Size(40, 13);
            this.tboxRPM.TabIndex = 6;
            this.tboxRPM.Text = "4500";
            this.tboxRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tboxSpeed
            // 
            this.tboxSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.tboxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxSpeed.Location = new System.Drawing.Point(113, 391);
            this.tboxSpeed.Name = "tboxSpeed";
            this.tboxSpeed.Size = new System.Drawing.Size(40, 13);
            this.tboxSpeed.TabIndex = 7;
            this.tboxSpeed.Text = "134";
            this.tboxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instantFuel
            // 
            this.instantFuel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.instantFuel.ColumnCount = 1;
            this.instantFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.instantFuel.Controls.Add(this.label1, 0, 0);
            this.instantFuel.Controls.Add(this.label7, 0, 1);
            this.instantFuel.Location = new System.Drawing.Point(6, 6);
            this.instantFuel.Name = "instantFuel";
            this.instantFuel.RowCount = 2;
            this.instantFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.instantFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.instantFuel.Size = new System.Drawing.Size(120, 105);
            this.instantFuel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instant Fuel Cons. (l/100 km)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 72);
            this.label7.TabIndex = 1;
            this.label7.Text = "Data";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(120, 105);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 72);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fuel/Distance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgFuel
            // 
            this.avgFuel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.avgFuel.ColumnCount = 1;
            this.avgFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.avgFuel.Controls.Add(this.label8, 0, 1);
            this.avgFuel.Controls.Add(this.label2, 0, 0);
            this.avgFuel.Location = new System.Drawing.Point(132, 6);
            this.avgFuel.Name = "avgFuel";
            this.avgFuel.RowCount = 2;
            this.avgFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.avgFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.avgFuel.Size = new System.Drawing.Size(120, 105);
            this.avgFuel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 72);
            this.label8.TabIndex = 2;
            this.label8.Text = "Data";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = " Average Fuel Cons. (l/100 km)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(132, 122);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(120, 105);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 72);
            this.label11.TabIndex = 2;
            this.label11.Text = "Data";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDistance
            // 
            this.totalDistance.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.totalDistance.ColumnCount = 1;
            this.totalDistance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalDistance.Controls.Add(this.label9, 0, 1);
            this.totalDistance.Controls.Add(this.label3, 0, 0);
            this.totalDistance.Location = new System.Drawing.Point(258, 6);
            this.totalDistance.Name = "totalDistance";
            this.totalDistance.RowCount = 2;
            this.totalDistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.totalDistance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.totalDistance.Size = new System.Drawing.Size(120, 105);
            this.totalDistance.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 72);
            this.label9.TabIndex = 2;
            this.label9.Text = "Data";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Distance (km)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(258, 122);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(120, 105);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(4, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 72);
            this.label12.TabIndex = 2;
            this.label12.Text = "Data";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxTemp
            // 
            this.picboxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.picboxTemp.Image = global::Sample_2.Properties.Resources.icons8_thermometer_32;
            this.picboxTemp.Location = new System.Drawing.Point(463, 103);
            this.picboxTemp.Name = "picboxTemp";
            this.picboxTemp.Size = new System.Drawing.Size(32, 32);
            this.picboxTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxTemp.TabIndex = 18;
            this.picboxTemp.TabStop = false;
            // 
            // vpbarTemp
            // 
            this.vpbarTemp.Location = new System.Drawing.Point(454, 7);
            this.vpbarTemp.Maximum = 1000;
            this.vpbarTemp.Name = "vpbarTemp";
            this.vpbarTemp.Size = new System.Drawing.Size(50, 220);
            this.vpbarTemp.TabIndex = 16;
            // 
            // picboxFuel
            // 
            this.picboxFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.picboxFuel.Image = global::Sample_2.Properties.Resources.icons8_gas_station_32;
            this.picboxFuel.Location = new System.Drawing.Point(402, 103);
            this.picboxFuel.Name = "picboxFuel";
            this.picboxFuel.Size = new System.Drawing.Size(32, 32);
            this.picboxFuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxFuel.TabIndex = 20;
            this.picboxFuel.TabStop = false;
            // 
            // vpbarFuel
            // 
            this.vpbarFuel.Location = new System.Drawing.Point(393, 7);
            this.vpbarFuel.Maximum = 1000;
            this.vpbarFuel.Name = "vpbarFuel";
            this.vpbarFuel.Size = new System.Drawing.Size(50, 220);
            this.vpbarFuel.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 451);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tboxRPM);
            this.tabPage1.Controls.Add(this.tboxSpeed);
            this.tabPage1.Controls.Add(this.labelRPM);
            this.tabPage1.Controls.Add(this.picboxTemp);
            this.tabPage1.Controls.Add(this.gaugeRPM);
            this.tabPage1.Controls.Add(this.picboxFuel);
            this.tabPage1.Controls.Add(this.labelSpeed);
            this.tabPage1.Controls.Add(this.vpbarTemp);
            this.tabPage1.Controls.Add(this.instantFuel);
            this.tabPage1.Controls.Add(this.gaugeSpeed);
            this.tabPage1.Controls.Add(this.vpbarFuel);
            this.tabPage1.Controls.Add(this.avgFuel);
            this.tabPage1.Controls.Add(this.totalDistance);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.tableLayoutPanel6);
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Unit System";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 45);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 19);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "English";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Metric";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(164, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Fuel Unit";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "mpg";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "l/100 km";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.instantFuel.ResumeLayout(false);
            this.instantFuel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.avgFuel.ResumeLayout(false);
            this.avgFuel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.totalDistance.ResumeLayout(false);
            this.totalDistance.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFuel)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.AGauge gaugeRPM;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.AGauge gaugeSpeed;
        private System.Windows.Forms.TextBox tboxRPM;
        private System.Windows.Forms.TextBox tboxSpeed;
        private System.Windows.Forms.TableLayoutPanel instantFuel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel avgFuel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel totalDistance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private VerticalProgressBar vpbarTemp;
        private System.Windows.Forms.PictureBox picboxTemp;
        private System.Windows.Forms.PictureBox picboxFuel;
        private VerticalProgressBar vpbarFuel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.IO.Ports.SerialPort serialPort1;
    }
}