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
        private string startDateTime; //DateTime
        //private DateTime endDateTime;
        private int interval;
        private int numberOfIntervals;
        private List<string> measuredData;

        public Measurement(string startDateTime,  int interval, int numberOfIntervals, List<string> measuredData)
        {
            this.startDateTime = startDateTime;
            //this.endDateTime = endDateTime;
            this.interval = interval;
            this.numberOfIntervals = numberOfIntervals;
            this.measuredData = measuredData;
        }

        

        // function generating Measurement objects from raw data
        static public List<Measurement> GenerateMeasurements(List<string> rawDataFromSD)
        {
            List<Measurement> measurements = new List<Measurement>();
            List<int> startPos=new List<int>();
            for (int i = 0; i<rawDataFromSD.Count ; i++)
            {
                if (rawDataFromSD[i].Contains("START")) startPos.Add(i);
            }

            for(int i=0;i<startPos.Count;i++)
            {
                string dateTime = rawDataFromSD[startPos[i] + 1];
                int interval = int.Parse( rawDataFromSD[startPos[i] + 2] );
                int numberOfIntervals = int.Parse(rawDataFromSD[startPos[i] + 3]);
                List<string> data;
                if (i == startPos.Count - 1)
                    data = rawDataFromSD.GetRange(startPos[i]+4, rawDataFromSD.Count - 1 - startPos[i] - 4);
                else
                    data = rawDataFromSD.GetRange(startPos[i] + 4, startPos[i + 1] - startPos[i] - 4);

                measurements.Add( new Measurement(dateTime, interval, numberOfIntervals, data) );   
            }










           //if (rawDataFromSD[0].ToString().Contains("READ"))
           //{
           //    
           //    for(int i=1;i<rawDataFromSD.Count;i++)
           //    { 
           //        if (rawDataFromSD[i].ToString().Contains("START"))
           //        {
           //            DateTime myDate = DateTime.ParseExact("5/4/2019/14/5/41", "dd/MM/yyyy/HH/mm/ss", 
           //                System.Globalization.CultureInfo.InvariantCulture);
           //            int interval = int.Parse(rawDataFromSD[++i]);
           //            int numberOfIntervals = int.Parse(rawDataFromSD[++i]);
           //            List<int> data=new List<int>();
           //            bool done = false;
           //            
           //            while(!done)
           //            {
           //                i++;
           //                if(rawDataFromSD[i].Contains("STOP"))
           //                {
           //                    DateTime myDateEnd = DateTime.ParseExact("5/4/2019/14/5/41", "dd/MM/yyyy/HH/mm/ss", 
           //                        System.Globalization.CultureInfo.InvariantCulture);
           //                    measurements.Add(new Measurement(myDate, myDateEnd, interval, numberOfIntervals, data));
           //                    done = true;
           //                }
           //                else if(rawDataFromSD[i].Contains("START"))
           //                {
           //                    done = true;
           //                    i--;
           //                }
           //                else()
           //
           //
           //            }
           //            
           //
           //
           //
           //            //Measurement measurement = new Measurement();
           //            
           //        }
           //        else
           //        {
           //            // rawDataFromSD is empty, exit
           //        }
           //    }
           // }
           // else
           
            return measurements;
        }

    }
}
