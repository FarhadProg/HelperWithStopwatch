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

        private static SelectCreateStopwatchOrNull _selector;

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


        static HelperWithStopwatch()
        {

            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings[_enableDurationTraceKey]))
            {
                if (!bool.TryParse(ConfigurationManager.AppSettings[_enableDurationTraceKey], out _enableDurationTrace))
                {
                    _enableDurationTrace = false;
                }
            }

            if (_enableDurationTrace)
            {
                _selector = ReturnStopwatch;
            }
            else
            {
                _selector = ReturnNull;

            }
        }

        public static Stopwatch CreateStopwatch()
        {
            return (_selector());
        }

        private static Stopwatch ReturnStopwatch()
        {
            return (new Stopwatch());
        }

        private static Stopwatch ReturnNull()
        {
            return (null);
        }

        public static ILogService Add(this ILogService service, Stopwatch sw)
        {
            string durationAdd = String.Format(" Duration:[{0:00}:{1:00}:{2:00}.{3:00}]",
                    sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds,
                    sw.Elapsed.Milliseconds );

            return new OurLogServiceProxy(service, durationAdd);
        }
    }

}
