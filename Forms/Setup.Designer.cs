namespace Sample_2.Forms
{
    partial class Setup
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.gboxCOMPorts = new System.Windows.Forms.GroupBox();
            this.cboxCOMPorts = new System.Windows.Forms.ComboBox();
            this.gboxOBDProtocol = new System.Windows.Forms.GroupBox();
            this.cboxOBDProtocol = new System.Windows.Forms.ComboBox();
            this.gboxBaudRate = new System.Windows.Forms.GroupBox();
            this.checkboxBaudRate = new System.Windows.Forms.CheckBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.tboxBaudRate = new System.Windows.Forms.TextBox();
            this.cboxBaudRate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gboxCOMPorts.SuspendLayout();
            this.gboxOBDProtocol.SuspendLayout();
            this.gboxBaudRate.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(25)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Image = global::Sample_2.Properties.Resources.icons8_connected_32;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnConnect.Size = new System.Drawing.Size(262, 80);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Image = global::Sample_2.Properties.Resources.icons8_disconnected_32;
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisconnect.Location = new System.Drawing.Point(268, 0);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDisconnect.Size = new System.Drawing.Size(262, 80);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // gboxCOMPorts
            // 
            this.gboxCOMPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxCOMPorts.Controls.Add(this.cboxCOMPorts);
            this.gboxCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxCOMPorts.Location = new System.Drawing.Point(12, 32);
            this.gboxCOMPorts.Name = "gboxCOMPorts";
            this.gboxCOMPorts.Size = new System.Drawing.Size(530, 52);
            this.gboxCOMPorts.TabIndex = 7;
            this.gboxCOMPorts.TabStop = false;
            this.gboxCOMPorts.Text = "COM Port";
            // 
            // cboxCOMPorts
            // 
            this.cboxCOMPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCOMPorts.FormattingEnabled = true;
            this.cboxCOMPorts.Location = new System.Drawing.Point(6, 19);
            this.cboxCOMPorts.Name = "cboxCOMPorts";
            this.cboxCOMPorts.Size = new System.Drawing.Size(518, 24);
            this.cboxCOMPorts.TabIndex = 0;
            // 
            // gboxOBDProtocol
            // 
            this.gboxOBDProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxOBDProtocol.Controls.Add(this.cboxOBDProtocol);
            this.gboxOBDProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxOBDProtocol.Location = new System.Drawing.Point(12, 281);
            this.gboxOBDProtocol.Name = "gboxOBDProtocol";
            this.gboxOBDProtocol.Size = new System.Drawing.Size(530, 53);
            this.gboxOBDProtocol.TabIndex = 8;
            this.gboxOBDProtocol.TabStop = false;
            this.gboxOBDProtocol.Text = "OBD-2 Protocol";
            this.gboxOBDProtocol.Visible = false;
            // 
            // cboxOBDProtocol
            // 
            this.cboxOBDProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxOBDProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOBDProtocol.Enabled = false;
            this.cboxOBDProtocol.FormattingEnabled = true;
            this.cboxOBDProtocol.Items.AddRange(new object[] {
            "ISO 15765 (CAN bus)",
            "ISO14230-4 (KWP2000)",
            "ISO9141-2",
            "SAE J1850 (VPW)",
            "SAE J1850 (PWM)"});
            this.cboxOBDProtocol.Location = new System.Drawing.Point(6, 19);
            this.cboxOBDProtocol.Name = "cboxOBDProtocol";
            this.cboxOBDProtocol.Size = new System.Drawing.Size(518, 24);
            this.cboxOBDProtocol.TabIndex = 0;
            // 
            // gboxBaudRate
            // 
            this.gboxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxBaudRate.Controls.Add(this.checkboxBaudRate);
            this.gboxBaudRate.Controls.Add(this.labelBaudRate);
            this.gboxBaudRate.Controls.Add(this.tboxBaudRate);
            this.gboxBaudRate.Controls.Add(this.cboxBaudRate);
            this.gboxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxBaudRate.Location = new System.Drawing.Point(12, 110);
            this.gboxBaudRate.Name = "gboxBaudRate";
            this.gboxBaudRate.Size = new System.Drawing.Size(530, 145);
            this.gboxBaudRate.TabIndex = 9;
            this.gboxBaudRate.TabStop = false;
            this.gboxBaudRate.Text = "Baud Rate";
            // 
            // checkboxBaudRate
            // 
            this.checkboxBaudRate.AutoSize = true;
            this.checkboxBaudRate.Location = new System.Drawing.Point(6, 66);
            this.checkboxBaudRate.Name = "checkboxBaudRate";
            this.checkboxBaudRate.Size = new System.Drawing.Size(207, 21);
            this.checkboxBaudRate.TabIndex = 4;
            this.checkboxBaudRate.Text = "Enter a particular Baud Rate";
            this.checkboxBaudRate.UseVisualStyleBackColor = true;
            this.checkboxBaudRate.CheckedChanged += new System.EventHandler(this.checkboxBaudRate_CheckedChanged);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.BackColor = System.Drawing.SystemColors.Control;
            this.labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaudRate.ForeColor = System.Drawing.Color.Gray;
            this.labelBaudRate.Location = new System.Drawing.Point(6, 125);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(99, 13);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Integer values only!";
            // 
            // tboxBaudRate
            // 
            this.tboxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxBaudRate.Location = new System.Drawing.Point(6, 99);
            this.tboxBaudRate.Name = "tboxBaudRate";
            this.tboxBaudRate.Size = new System.Drawing.Size(518, 23);
            this.tboxBaudRate.TabIndex = 2;
            this.tboxBaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxBaudRate_KeyPress);
            // 
            // cboxBaudRate
            // 
            this.cboxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaudRate.FormattingEnabled = true;
            this.cboxBaudRate.ItemHeight = 16;
            this.cboxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400",
            "460800",
            "576000",
            "921600"});
            this.cboxBaudRate.Location = new System.Drawing.Point(6, 22);
            this.cboxBaudRate.Name = "cboxBaudRate";
            this.cboxBaudRate.Size = new System.Drawing.Size(518, 24);
            this.cboxBaudRate.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisconnect, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 349);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 80);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gboxBaudRate);
            this.Controls.Add(this.gboxOBDProtocol);
            this.Controls.Add(this.gboxCOMPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setup_FormClosed);
            this.Load += new System.EventHandler(this.Setup_Load);
            this.gboxCOMPorts.ResumeLayout(false);
            this.gboxOBDProtocol.ResumeLayout(false);
            this.gboxBaudRate.ResumeLayout(false);
            this.gboxBaudRate.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox gboxCOMPorts;
        private System.Windows.Forms.ComboBox cboxCOMPorts;
        private System.Windows.Forms.GroupBox gboxOBDProtocol;
        private System.Windows.Forms.ComboBox cboxOBDProtocol;
        private System.Windows.Forms.GroupBox gboxBaudRate;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox cboxBaudRate;
        private System.Windows.Forms.CheckBox checkboxBaudRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tboxBaudRate;
    }
}