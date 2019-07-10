using System;
using System.Collections.Generic;
using System.Text;
using Galaktika.ESB.Utils.LogService;
using  System.Diagnostics;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace HelperWithStopwatch
{
    static class ExecutionTimeMonitoring
    {


        public static bool EnableDurationTrace {get; set; }

        public static Stopwatch StartMeasure()
        {
            Stopwatch sw = new Stopwatch();
            if (EnableDurationTrace)
            {
                sw.Start();
                
            }
            return sw;
        }
        public static ILogService WithDuration(this ILogService service, Stopwatch sw)
        {
            if (service != null && sw!= null && sw.IsRunning)
            {
                sw.Stop();
                return new ToSupplementDurationInMessage(service, String.Format(" Duration:[{0:00}:{1:00}:{2:00}.{3:00}]", sw.Elapsed.Hours,
                    sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds));
            }
            else
            {
                return service;
            }
        }

    }

}
