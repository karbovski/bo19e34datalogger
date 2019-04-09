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

            bool result=true;
            
            try
            {
                SendCommand("r#");
                serialPort.ReadLine();

                using (StreamWriter writer = new StreamWriter("test.txt"))
                {
                    bool doneCommandDetected = false;
                    string doneBreakPoint = "DONE";
                    string line;
                   
                    while (!doneCommandDetected)
                    {
                        line = serialPort.ReadLine();
                        Console.WriteLine(line);
                        if (!line.Contains(doneBreakPoint))
                            writer.Write(line);
                        else
                        {
                            doneCommandDetected = true;
                        }
                    }
                    
                }
            }catch (Exception)
            {
                Console.WriteLine("Catched");
                result = false;   
            }


            return result;
        }

    }
}
