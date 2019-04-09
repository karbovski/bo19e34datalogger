using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger
{
    public partial class Form1 : Form
    {
        SerialHandler SerialHandler;

        public Form1()
        {
            InitializeComponent();
            SerialHandler = new SerialHandler();
            UpdateAvailablePorts();
        }

        

        private void UpdateAvailablePorts()
        {
            ComboBoxSerial.Items.Clear();

            foreach (string availablePort in SerialHandler.GetAvailablePorts())
                ComboBoxSerial.Items.Add(availablePort);
        }

        private void buttonRefreshSerial_Click(object sender, EventArgs e)
        {
            UpdateAvailablePorts();
        }

        private void buttonConnectSerial_Click(object sender, EventArgs e)
        {
            buttonConnectSerial.Enabled = false;
            try
            {
                string port = ComboBoxSerial.SelectedItem.ToString();
                SerialHandler.ConnectToSerial(port);
            } catch (Exception)
            {
                MessageBox.Show("Could not connect to serial port!");
                UpdateAvailablePorts();
                
            }
            
        }

        private async void buttonGetMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                buttonGetMeasurements.Enabled = false;
                Task<bool> measurementsTask = Task.Run(() => SerialHandler.ReadMeasurements());
                
                await measurementsTask;
               
                Console.WriteLine(measurementsTask.Result.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           //Thread thread = new Thread(SerialHandler.ReadMeasurements);
           //thread.Start();
      
        }

        private void ComboBoxSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSerial.SelectedItem != null) buttonConnectSerial.Enabled = true;
            
        }
    }
}
