using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace DataLogger
{
    public class SerialHandler
    {
        static SerialPort serialPort = new SerialPort();

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
                serialPort.BaudRate = 9600;
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

        public void ReadMeasurements()
        {
            

            try
            {
                SendCommand("r#");
            } catch (Exception)
            {
                throw new Exception("Check serial connection!");
            }
            
            try
            {
                using (StreamWriter writer = new StreamWriter("test.txt"))
                {
                    bool doneCommandDetected = false;
                    string doneBreakPoint = "#DONE#";

                    while (!doneCommandDetected)
                    {
                        string line = serialPort.ReadLine();
                        if (!line.Equals(doneBreakPoint))
                            writer.Write(line);
                    }
                }
            }catch (Exception)
            {
                throw new Exception("Something went wrong while reading data!");
            }
            

        }

    }
}
