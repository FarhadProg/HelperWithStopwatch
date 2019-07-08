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
            Stopwatch sw = HelperWithStopwatch.CreateStopwatch();
            if (sw != null)
            {
                sw.Start();
                Thread.Sleep(500);
                sw.Stop();
                ILogService interf = new OurImplementationILogService();
                interf = HelperWithStopwatch.Add(interf, sw);
                interf.Error("Error");
            }
            else
            {
                Console.WriteLine("Замер времени не проводился");
            }

            Console.ReadKey();

        }

    }
}
