using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Galaktika.ESB.Utils.LogService;

namespace HelperWithStopwatch
{
    public  class OurImplementationILogService : ILogService
    {
        void ILogService.Debug(string msg, params object[] args)
        {
            Console.WriteLine(msg);
        }
        Exception ILogService.Error(Exception e, string msg = null, params object[] args)
        {
            throw new NotImplementedException();
        }

        void ILogService.Error(string msg, params object[] args)
        {
            Console.WriteLine(msg);
        }
        Exception ILogService.Fatal(Exception e, string msg = null, params object[] args)
        {
            throw new NotImplementedException();
        }

        void ILogService.Fatal(string msg, params object[] args)
        {
            Console.WriteLine(msg);
        }
        void ILogService.Info(string msg, params object[] args)
        {
            Console.WriteLine(msg);
        }
        void ILogService.Trace(string msg, params object[] args)
        {
            Console.WriteLine(msg);
        }
        void ILogService.Warn(string msg, params object[] args)
        {
            Console.WriteLine(msg);
        }
        void ILogService.Throw(Exception e)
        {
            throw new NotImplementedException();
        }
    }
}