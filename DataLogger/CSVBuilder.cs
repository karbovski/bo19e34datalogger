using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger
{
    class CSVBuilder
    {
        public static void BuildCSVFile(List<Measurement> measurementList)
        {
            foreach (Measurement measurement in measurementList)
            {
                string filePath = measurement.startDateTime;
                // replace all / with - Windows does not allow / in filenames
                filePath = filePath.Replace('/', '-');
                filePath = filePath.Substring(0, filePath.Length - 1) + ".csv";
                var csv = new StringBuilder();
                csv.AppendLine(measurement.startDateTime + ";" + measurement.interval + ";" + measurement.numberOfIntervals);
                foreach (string data in measurement.measuredData)
                {
                    csv.AppendLine(data.Substring(0,data.Length-1));
                }
                File.WriteAllText(filePath, csv.ToString());
            }

        }
    }
}
