﻿using System;
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
        }

        private void EnableFeaturesButtons()
        {
            buttonEraseData.Enabled = true;
            buttonSyncClock.Enabled = true;
            buttonGetMeasurements.Enabled = true;
        }

        private void DisableFeaturesButtons()
        {
            buttonEraseData.Enabled = false;
            buttonSyncClock.Enabled = false;
            buttonGetMeasurements.Enabled = false;
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
    }
}
