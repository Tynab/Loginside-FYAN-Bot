using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static System.DateTime;
using static System.IO.File;

namespace Loginside_FYAN_Bot_Service.Script
{
    internal static class Logger
    {
        /// <summary>
        /// Log writer
        /// </summary>
        /// <param name="message">Message.</param>
        internal static void WriteLog(string caption, string message)
        {
            CrtDirAdv(LOG_PATH);
            // create or mod
            if (Exists(LOG_ADR))
            {
                using var writer = AppendText(LOG_ADR);
                writer.WriteLine(Now.ToString("HH:mm:ss") + $" {caption}: {message}");
            }
            else
            {
                using var writer = CreateText(LOG_ADR);
                writer.WriteLine(Now.ToString("HH:mm:ss") + $" {caption}: {message}");
            }
        }
    }
}
