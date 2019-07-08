using System;

namespace Galaktika.ESB.Utils.LogService
{
    public interface ILogService  
    {
        //LogMessageDef GetMessageDef(int messageId);

        void Debug(string msg, params object[] args);
        Exception Error(Exception e, string msg = null, params object[] args);
        void Error(string msg, params object[] args);
        Exception Fatal(Exception e, string msg = null, params object[] args);
        void Fatal(string msg, params object[] args);
        void Info(string msg, params object[] args);
        void Trace(string msg, params object[] args);
        void Warn(string msg, params object[] args);

        void Throw(Exception e);
    }
}