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
            this.ComboBoxSerial = new System.Windows.Forms.ComboBox();
            this.buttonConnectSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshSerial = new System.Windows.Forms.Button();
            this.buttonGetMeasurements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxSerial
            // 
            this.ComboBoxSerial.FormattingEnabled = true;
            this.ComboBoxSerial.Location = new System.Drawing.Point(12, 29);
            this.ComboBoxSerial.Name = "ComboBoxSerial";
            this.ComboBoxSerial.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSerial.TabIndex = 0;
            // 
            // buttonConnectSerial
            // 
            this.buttonConnectSerial.Location = new System.Drawing.Point(139, 29);
            this.buttonConnectSerial.Name = "buttonConnectSerial";
            this.buttonConnectSerial.Size = new System.Drawing.Size(121, 21);
            this.buttonConnectSerial.TabIndex = 1;
            this.buttonConnectSerial.Text = "Connect";
            this.buttonConnectSerial.UseVisualStyleBackColor = true;
            this.buttonConnectSerial.Click += new System.EventHandler(this.buttonConnectSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connect to serial";
            // 
            // buttonRefreshSerial
            // 
            this.buttonRefreshSerial.Location = new System.Drawing.Point(12, 56);
            this.buttonRefreshSerial.Name = "buttonRefreshSerial";
            this.buttonRefreshSerial.Size = new System.Drawing.Size(121, 21);
            this.buttonRefreshSerial.TabIndex = 3;
            this.buttonRefreshSerial.Text = "Refresh";
            this.buttonRefreshSerial.UseVisualStyleBackColor = true;
            this.buttonRefreshSerial.Click += new System.EventHandler(this.buttonRefreshSerial_Click);
            // 
            // buttonGetMeasurements
            // 
            this.buttonGetMeasurements.Location = new System.Drawing.Point(139, 56);
            this.buttonGetMeasurements.Name = "buttonGetMeasurements";
            this.buttonGetMeasurements.Size = new System.Drawing.Size(121, 21);
            this.buttonGetMeasurements.TabIndex = 4;
            this.buttonGetMeasurements.Text = "Get data from SD card";
            this.buttonGetMeasurements.UseVisualStyleBackColor = true;
            this.buttonGetMeasurements.Click += new System.EventHandler(this.buttonGetMeasurements_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.buttonGetMeasurements);
            this.Controls.Add(this.buttonRefreshSerial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnectSerial);
            this.Controls.Add(this.ComboBoxSerial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxSerial;
        private System.Windows.Forms.Button buttonConnectSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshSerial;
        private System.Windows.Forms.Button buttonGetMeasurements;
    }
}

