using System;
using System.Collections.Generic;
using System.Text;
using Galaktika.ESB.Utils.LogService;
using  System.Diagnostics;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace HelperWithStopwatch
{
    static class HelperWithStopwatch
    {
        delegate Stopwatch SelectCreateStopwatchOrNull();

        private static SelectCreateStopwatchOrNull _selector = ReturnNull;

        private static bool _enableDurationTrace;

        public static bool EnableDurationTrace
        {
            get { return _enableDurationTrace; }
            set
            {
                _enableDurationTrace = value;
                if (_enableDurationTrace)
                    _selector = ReturnStopwatch;
                else
                    _selector = ReturnNull;


            }
        }
        private static string _enableDurationTraceKey;

        
        private static Stopwatch CreateStopwatch()
        {
            return _selector();
        }

        private static Stopwatch ReturnStopwatch()
        {
            return new Stopwatch();
        }

        private static Stopwatch ReturnNull()
        {
            return (null);
        }

        public static object StartMeasure()
        {
            Stopwatch sw = CreateStopwatch();
            if (sw != null)
            {
                sw.Start();
            }

            return (object)sw;

        }
        public static ILogService WithDuration(this ILogService service, object obj)
        {
            Stopwatch sw = (Stopwatch) obj;
            if (sw != null)
            {
                return Add(service, sw);
            }
            else
            {
                return service;
            }   
        }
        private static ILogService Add(this ILogService service, Stopwatch sw)
        {
            string durationAdd = String.Format(" Duration:[{0:00}:{1:00}:{2:00}.{3:00}]",
                    sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds,
                    sw.Elapsed.Milliseconds);

            return new OurLogServiceProxy(service, durationAdd);
        }
    }

}
