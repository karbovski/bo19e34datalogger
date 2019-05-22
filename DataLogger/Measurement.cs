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
        public string startDateTime;
        public int interval;
        public int numberOfIntervals;
        public List<string> measuredData;

        public Measurement(string startDateTime,  int interval, int numberOfIntervals, List<string> measuredData)
        {
            this.startDateTime = startDateTime;
            this.interval = interval;
            this.numberOfIntervals = numberOfIntervals;
            this.measuredData = measuredData;
        }

        static public List<Measurement> GenerateMeasurements(List<string> rawDataFromSD)
        {
            List<Measurement> measurements = new List<Measurement>();
            List<int> startPos=new List<int>();

            for (int i = 0; i < rawDataFromSD.Count; i++)
                if (rawDataFromSD[i].Contains("START")) startPos.Add(i);

            for (int i = 0; i < startPos.Count; i++)
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

            return measurements;
        }
    }
}