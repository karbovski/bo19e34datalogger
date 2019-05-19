namespace DataLogger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBoxSerial = new System.Windows.Forms.ComboBox();
            this.buttonConnectSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshSerial = new System.Windows.Forms.Button();
            this.buttonGetMeasurements = new System.Windows.Forms.Button();
            this.buttonSyncClock = new System.Windows.Forms.Button();
            this.buttonEraseData = new System.Windows.Forms.Button();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.buttonUpdateConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxSerial
            // 
            this.ComboBoxSerial.FormattingEnabled = true;
            this.ComboBoxSerial.Location = new System.Drawing.Point(12, 34);
            this.ComboBoxSerial.Name = "ComboBoxSerial";
            this.ComboBoxSerial.Size = new System.Drawing.Size(104, 21);
            this.ComboBoxSerial.TabIndex = 0;
            this.ComboBoxSerial.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerial_SelectedIndexChanged);
            // 
            // buttonConnectSerial
            // 
            this.buttonConnectSerial.Enabled = false;
            this.buttonConnectSerial.Location = new System.Drawing.Point(185, 34);
            this.buttonConnectSerial.Name = "buttonConnectSerial";
            this.buttonConnectSerial.Size = new System.Drawing.Size(75, 21);
            this.buttonConnectSerial.TabIndex = 1;
            this.buttonConnectSerial.Text = "Connect";
            this.buttonConnectSerial.UseVisualStyleBackColor = true;
            this.buttonConnectSerial.Click += new System.EventHandler(this.buttonConnectSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connect to serial port";
            // 
            // buttonRefreshSerial
            // 
            this.buttonRefreshSerial.Location = new System.Drawing.Point(122, 34);
            this.buttonRefreshSerial.Name = "buttonRefreshSerial";
            this.buttonRefreshSerial.Size = new System.Drawing.Size(57, 21);
            this.buttonRefreshSerial.TabIndex = 3;
            this.buttonRefreshSerial.Text = "Refresh";
            this.buttonRefreshSerial.UseVisualStyleBackColor = true;
            this.buttonRefreshSerial.Click += new System.EventHandler(this.buttonRefreshSerial_Click);
            // 
            // buttonGetMeasurements
            // 
            this.buttonGetMeasurements.Location = new System.Drawing.Point(12, 72);
            this.buttonGetMeasurements.Name = "buttonGetMeasurements";
            this.buttonGetMeasurements.Size = new System.Drawing.Size(248, 28);
            this.buttonGetMeasurements.TabIndex = 4;
            this.buttonGetMeasurements.Text = "Get data from SD card";
            this.buttonGetMeasurements.UseVisualStyleBackColor = true;
            this.buttonGetMeasurements.Click += new System.EventHandler(this.buttonGetMeasurements_Click);
            // 
            // buttonSyncClock
            // 
            this.buttonSyncClock.Location = new System.Drawing.Point(12, 106);
            this.buttonSyncClock.Name = "buttonSyncClock";
            this.buttonSyncClock.Size = new System.Drawing.Size(248, 28);
            this.buttonSyncClock.TabIndex = 5;
            this.buttonSyncClock.Text = "Synchronize time on Arduino";
            this.buttonSyncClock.UseVisualStyleBackColor = true;
            this.buttonSyncClock.Click += new System.EventHandler(this.ButtonSyncClock_Click);
            // 
            // buttonEraseData
            // 
            this.buttonEraseData.Location = new System.Drawing.Point(12, 140);
            this.buttonEraseData.Name = "buttonEraseData";
            this.buttonEraseData.Size = new System.Drawing.Size(248, 28);
            this.buttonEraseData.TabIndex = 6;
            this.buttonEraseData.Text = "Erase all data on SD card";
            this.buttonEraseData.UseVisualStyleBackColor = true;
            this.buttonEraseData.Click += new System.EventHandler(this.ButtonEraseData_Click);
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.AutoSize = true;
            this.labelConfiguration.Location = new System.Drawing.Point(12, 180);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(69, 13);
            this.labelConfiguration.TabIndex = 7;
            this.labelConfiguration.Text = "Configuration";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Location = new System.Drawing.Point(116, 200);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(144, 21);
            this.comboBoxInterval.TabIndex = 8;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(12, 203);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(74, 13);
            this.labelInterval.TabIndex = 9;
            this.labelInterval.Text = "Interval length";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 230);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(98, 13);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Number of intervals";
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(116, 227);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(144, 21);
            this.comboBoxNumber.TabIndex = 11;
            // 
            // buttonUpdateConfig
            // 
            this.buttonUpdateConfig.Location = new System.Drawing.Point(12, 254);
            this.buttonUpdateConfig.Name = "buttonUpdateConfig";
            this.buttonUpdateConfig.Size = new System.Drawing.Size(248, 28);
            this.buttonUpdateConfig.TabIndex = 12;
            this.buttonUpdateConfig.Text = "Update configuration";
            this.buttonUpdateConfig.UseVisualStyleBackColor = true;
            this.buttonUpdateConfig.Click += new System.EventHandler(this.ButtonUpdateConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 439);
            this.Controls.Add(this.buttonUpdateConfig);
            this.Controls.Add(this.comboBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.comboBoxInterval);
            this.Controls.Add(this.labelConfiguration);
            this.Controls.Add(this.buttonEraseData);
            this.Controls.Add(this.buttonSyncClock);
            this.Controls.Add(this.buttonGetMeasurements);
            this.Controls.Add(this.buttonRefreshSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnectSerial);
            this.Controls.Add(this.ComboBoxSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BO19-E34 Geiger datalogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxSerial;
        private System.Windows.Forms.Button buttonConnectSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshSerial;
        private System.Windows.Forms.Button buttonGetMeasurements;
        private System.Windows.Forms.Button buttonSyncClock;
        private System.Windows.Forms.Button buttonEraseData;
        private System.Windows.Forms.Label labelConfiguration;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Button buttonUpdateConfig;
    }
}

