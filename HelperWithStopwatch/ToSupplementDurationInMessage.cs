using System;
using System.Net.Configuration;
using Galaktika.ESB.Utils.LogService;

namespace HelperWithStopwatch
{
    public class ToSupplementDurationInMessage : ILogService
    {
        private readonly ILogService _logService;
        private readonly string _duration;
        public ToSupplementDurationInMessage(ILogService logService, string duration)
        {
            _logService = logService;
            _duration = duration;
        }
        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="args">Arguments to format.</param>
        public void Debug(string msg, params object[] args)
        {
            _logService.Debug(msg+_duration, args);
        }

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Error</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="e">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        public Exception Error(Exception e, string msg = null, params object[] args)
        {
            return _logService.Error(e, msg + _duration, args);
        }
        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="args">Arguments to format.</param>
        public void Error(string msg, params object[] args)
        {
            _logService.Error(msg + _duration, args);
        }

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="e">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        public Exception Fatal(Exception e, string msg = null, params object[] args)
        {
            return _logService.Fatal(e, msg + _duration, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="args">Arguments to format.</param>
        public void Fatal(string msg, params object[] args)
        {
            _logService.Fatal(msg + _duration, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="args">Arguments to format.</param>
        public void Info(string msg, params object[] args)
        {
            _logService.Info(msg + _duration, args);
        }

        /// <summary>
        /// Launch debugger and throw exception
        /// </summary>
        /// <param name="e">Exception</param>
        public void Throw(Exception e)
        {
            _logService.Throw(e);
        }

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="args">Arguments to format.</param>
        public void Trace(string msg, params object[] args)
        {
            _logService.Trace(msg + _duration, args);
        }
        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary>
        /// <param name="msg">A <see langword="string" /> to be written.</param>
        /// <param name="args">Arguments to format.</param>
        public void Warn(string msg, params object[] args)
        {
            _logService.Warn(msg + _duration, args);
        }

    }
}