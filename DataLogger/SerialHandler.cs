using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Collections;

namespace DataLogger
{
    public class SerialHandler
    {
        public SerialPort serialPort = new SerialPort();

        public SerialHandler()
        {

        }

        // update ports
        public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        // connect to port

        public void ConnectToSerial(string port)
        {
            try
            {
                serialPort.BaudRate = 115200;
                serialPort.PortName = port;
                serialPort.Open();
            }
            catch (Exception)
            {
                throw new Exception();
            }

        }

        // send command 
        public void SendCommand(string command)
        {
            if (serialPort.IsOpen)
                serialPort.WriteLine(command);
        }

        public bool ReadMeasurements()
        {
            List<string> rawDataFromSD = new List<string>();

            bool doneIsDetected = false;
            SendCommand("r#");

            while (!doneIsDetected)
            {
                string line = serialPort.ReadLine();
                if (!line.Contains("Done"))
                    rawDataFromSD.Add(line);
                else
                    doneIsDetected = true;
            }

            if (rawDataFromSD.Count > 0)
            {
                CSVBuilder.BuildCSVFile(Measurement.GenerateMeasurements(rawDataFromSD));
                return true;
            }
            else
                return false;
        }

    }
}
