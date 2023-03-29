using Serilog;
using System;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static Serilog.Log;
using static System.DateTime;

namespace Loginside_FYAN_Bot_Service.Script;

internal class Logger
{
    #region Methods
    /// <summary>
    /// Write log infomation.
    /// </summary>
    /// <param name="cap">Caption.</param>
    /// <param name="msg">Message.</param>
    internal void WrInfo(string cap, string msg)
    {
        Log.Logger = new LoggerConfiguration()?.WriteTo?.File($@"{LOG_PATH}\{Today:dd-MM-yyyy}.log")?.CreateLogger();
        Information($"{cap}: {msg}");
        CloseAndFlush();
    }

    /// <summary>
    /// Write log error.
    /// </summary>
    /// <param name="cap">Caption.</param>
    /// <param name="exc">Exception.</param>
    internal void WrErr(string cap, Exception exc)
    {
        Log.Logger = new LoggerConfiguration()?.WriteTo?.File($@"{LOG_PATH}\{Today:dd-MM-yyyy}.log")?.CreateLogger();
        Error(exc, cap);
        CloseAndFlush();
    }
    #endregion
}
