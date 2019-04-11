using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogger
{
    class GeigerHandler
    {
        // c20190219120800# gir 19.02.1997 12:09:00
        public static void SyncClockOnArduino(SerialHandler serialHandler)
        {
            serialHandler.SendCommand("c" + DateTime.Now.ToString("yyyyMMddHHmmss") + "#");
        }
        
        public static void EraseSDCard(SerialHandler serialHandler)
        {
            serialHandler.SendCommand("e#");
        }

        // configure geiger counter (interval, number of intervals)

        // erase SD card

    }
}
