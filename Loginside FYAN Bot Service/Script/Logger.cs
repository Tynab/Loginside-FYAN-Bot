using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static System.DateTime;
using static System.IO.File;

namespace Loginside_FYAN_Bot_Service.Script;

internal class Logger
{
    #region Methods
    /// <summary>
    /// Write log.
    /// </summary>
    /// <param name="cap">Caption.</param>
    /// <param name="msg">Message.</param>
    internal void WrLog(string cap, string msg)
    {
        CrtDirAdv(LOG_PATH);
        var logAdr = $@"{LOG_PATH}\" + Today.ToString("dd-MM-yyyy") + ".txt";
        // create or mod
        if (Exists(logAdr))
        {
            using var writer = AppendText(logAdr);
            writer.WriteLine(Now.ToString("HH:mm:ss") + $" {cap}: {msg}");
        }
        else
        {
            using var writer = CreateText(logAdr);
            writer.WriteLine(Now.ToString("HH:mm:ss") + $" {cap}: {msg}");
        }
    }
    #endregion
}
