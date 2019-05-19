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
        SerialHandler serialHandler;

        public Form1()
        {
            InitializeComponent();
            serialHandler = new SerialHandler();
            UpdateAvailablePorts();
            DisableFeaturesButtons();
            comboBoxInterval.Items.Add("60000");
            comboBoxNumber.Items.Add("00010");
            comboBoxNumber.Items.Add("00060");
            comboBoxNumber.Items.Add("00120");
            comboBoxNumber.Items.Add("00480");
            comboBoxNumber.Items.Add("01440");
            comboBoxNumber.Items.Add("60000");
        }

        private void EnableFeaturesButtons()
        {
            buttonEraseData.Enabled = true;
            buttonSyncClock.Enabled = true;
            buttonGetMeasurements.Enabled = true;

            buttonUpdateConfig.Enabled = true;
            labelConfiguration.Enabled = true;
            labelInterval.Enabled = true;
            labelNumber.Enabled = true;
            comboBoxInterval.Enabled = true;
            comboBoxNumber.Enabled = true;
        }

        private void DisableFeaturesButtons()
        {
            buttonEraseData.Enabled = false;
            buttonSyncClock.Enabled = false;
            buttonGetMeasurements.Enabled = false;

            buttonUpdateConfig.Enabled = false;
            labelConfiguration.Enabled = false;
            labelInterval.Enabled = false;
            labelNumber.Enabled = false;
            comboBoxInterval.Enabled = false;
            comboBoxNumber.Enabled = false;
        }

        private void UpdateAvailablePorts()
        {
            ComboBoxSerial.Items.Clear();

            foreach (string availablePort in serialHandler.GetAvailablePorts())
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
                serialHandler.ConnectToSerial(port);
                EnableFeaturesButtons();
                MessageBox.Show("Succesfully connected to " + port);
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
                Task<bool> measurementsTask = Task.Run(() => serialHandler.ReadMeasurements());
                
                await measurementsTask;
               
                Console.WriteLine(measurementsTask.Result.ToString());
                MessageBox.Show("OK!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ComboBoxSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSerial.SelectedItem != null) buttonConnectSerial.Enabled = true; 
        }

        private void ButtonSyncClock_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialHandler.serialPort.IsOpen == true)
                {
                    GeigerHandler.SyncClockOnArduino(serialHandler);
                    MessageBox.Show("Clock has been succesfully synchronized!");
                } else
                {
                    DisableFeaturesButtons();
                    UpdateAvailablePorts();
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void ButtonEraseData_Click(object sender, EventArgs e)
        {
            try
            {
                GeigerHandler.EraseSDCard(serialHandler);
                MessageBox.Show("SD Card succesfully erased!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUpdateConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxInterval.SelectedIndex > -1) && (comboBoxNumber.SelectedIndex > -1))
                {
                    GeigerHandler.ConfigureGeiger(serialHandler, comboBoxInterval.SelectedItem.ToString(), comboBoxNumber.SelectedItem.ToString());
                    MessageBox.Show("Geiger succesfully configured!");
                }
                else
                {
                    MessageBox.Show("Error! You need to choose configuration parameters before update");
                }

            }
            catch (Exception)
            {
                throw new Exception("Could not configure counter!");
            }
        }
    }
}