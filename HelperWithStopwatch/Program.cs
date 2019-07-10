using System;
using  System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Galaktika.ESB.Utils.LogService;
namespace HelperWithStopwatch
{
    class Program 
    {
        static void Main(string[] args)
        {
            ExecutionTimeMonitoring.EnableDurationTrace = false;
            ILogService interf = new OurImplementationILogService();
            
            Stopwatch sw = ExecutionTimeMonitoring.StartMeasure();

            Thread.Sleep(500);
            interf = null;
            interf.WithDuration(sw).Error("error");





            Console.ReadKey();

        }

    }
}
