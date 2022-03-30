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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gboxBaudRate = new System.Windows.Forms.GroupBox();
            this.checkboxBaudRate = new System.Windows.Forms.CheckBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.tboxBaudRate = new System.Windows.Forms.TextBox();
            this.cboxBaudRate = new System.Windows.Forms.ComboBox();
            this.gboxCOMPorts.SuspendLayout();
            this.gboxOBDProtocol.SuspendLayout();
            this.gboxBaudRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(25)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Image = global::Sample_2.Properties.Resources.icons8_connected_32;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.Location = new System.Drawing.Point(12, 360);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnConnect.Size = new System.Drawing.Size(262, 70);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Image = global::Sample_2.Properties.Resources.icons8_disconnected_32;
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisconnect.Location = new System.Drawing.Point(280, 360);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDisconnect.Size = new System.Drawing.Size(262, 70);
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
            this.cboxCOMPorts.Size = new System.Drawing.Size(512, 24);
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
            // 
            // cboxOBDProtocol
            // 
            this.cboxOBDProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxOBDProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOBDProtocol.FormattingEnabled = true;
            this.cboxOBDProtocol.Items.AddRange(new object[] {
            "ISO 15765 (CAN bus)",
            "ISO14230-4 (KWP2000)",
            "ISO9141-2",
            "SAE J1850 (VPW)",
            "SAE J1850 (PWM)"});
            this.cboxOBDProtocol.Location = new System.Drawing.Point(6, 19);
            this.cboxOBDProtocol.Name = "cboxOBDProtocol";
            this.cboxOBDProtocol.Size = new System.Drawing.Size(512, 24);
            this.cboxOBDProtocol.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 450);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(554, 1);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
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
            this.checkboxBaudRate.Location = new System.Drawing.Point(6, 72);
            this.checkboxBaudRate.Name = "checkboxBaudRate";
            this.checkboxBaudRate.Size = new System.Drawing.Size(207, 21);
            this.checkboxBaudRate.TabIndex = 4;
            this.checkboxBaudRate.Text = "Enter a particular Baud Rate";
            this.checkboxBaudRate.UseVisualStyleBackColor = true;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.BackColor = System.Drawing.SystemColors.Control;
            this.labelBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaudRate.ForeColor = System.Drawing.Color.Gray;
            this.labelBaudRate.Location = new System.Drawing.Point(6, 125);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(134, 13);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Only accepts integer value!";
            // 
            // tboxBaudRate
            // 
            this.tboxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxBaudRate.Location = new System.Drawing.Point(6, 99);
            this.tboxBaudRate.Name = "tboxBaudRate";
            this.tboxBaudRate.Size = new System.Drawing.Size(512, 23);
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
            this.cboxBaudRate.Size = new System.Drawing.Size(512, 24);
            this.cboxBaudRate.TabIndex = 0;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.gboxBaudRate);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gboxOBDProtocol);
            this.Controls.Add(this.gboxCOMPorts);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gboxBaudRate;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.TextBox tboxBaudRate;
        private System.Windows.Forms.ComboBox cboxBaudRate;
        private System.Windows.Forms.CheckBox checkboxBaudRate;
    }
}