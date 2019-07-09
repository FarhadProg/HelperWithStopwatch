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
            ExecutionTimeMonitoring.EnableDurationTrace = true;
            ILogService interf = new OurImplementationILogService();
            object timeMesureObj = ExecutionTimeMonitoring.StartMeasure();
            Thread.Sleep(500);
            interf = ExecutionTimeMonitoring.WithDuration(interf, timeMesureObj);
            interf.Error("Error");
            Thread.Sleep(500);
            interf = ExecutionTimeMonitoring.WithDuration(interf, timeMesureObj);
            interf.Error("Error");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(500);
            sw.Stop();
            Console.WriteLine("Первый стоп: {0}", sw.Elapsed.Milliseconds);
            Thread.Sleep(500);
            sw.Stop();
            Console.WriteLine("Второй стоп: {0}", sw.Elapsed.Milliseconds);
            Console.ReadKey();

        }

    }
}
