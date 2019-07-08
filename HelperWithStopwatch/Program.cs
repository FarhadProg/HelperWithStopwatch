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
            HelperWithStopwatch.EnableDurationTrace = true;
            ILogService interf = new OurImplementationILogService();
            object timeMesureObj = HelperWithStopwatch.StartMeasure();
            Thread.Sleep(500);
            interf = HelperWithStopwatch.WithDuration(interf, timeMesureObj);
            interf.Error("Error");
            

            Console.ReadKey();

        }

    }
}
