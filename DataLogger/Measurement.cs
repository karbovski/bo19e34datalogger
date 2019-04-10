using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger
{
    class Measurement
    {
        private DateTime startDateTime;
        private DateTime endDateTime;
        private int interval;
        private int numberOfIntervals;
        private ArrayList measuredData;

        private Measurement()
        {

        }

        // function generating Measurement objects from raw data
        static public void GenerateMeasurements(ArrayList rawDataFromSD)
        {
            if (rawDataFromSD[0].ToString().Contains("READ"))
            {
                    if (rawDataFromSD[1].ToString().Contains("START"))
                    {
                        // substring to get startDateTime

                        // go to next line to get interval and number of intervals

                        // check for data tag

                        // read until stop or new start

                        // finitio finale, get current posistion in iteration and delete range from 0 to current position
                    }
                    else
                    {
                        // rawDataFromSD is empty, exit
                    }
            }
            else
            {
                throw new Exception("#READ# is missing, data is probably corrupted!");
            }
        }

    }
}
