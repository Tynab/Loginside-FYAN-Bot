using static Loginside_FYAN_Bot_Service.Script.Common;
using static System.AppDomain;
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
            var logPath = $@"{CurrentDomain.BaseDirectory}\Log";
            var logAdr = $@"{logPath}\" + Today.ToString("dd-MM-yyyy") + ".txt";
            CrtDirAdv(logPath);
            if (Exists(logAdr))
            {
                using var writer = AppendText(logAdr);
                writer.WriteLine(Now.ToString("HH:mm:ss") + $"{caption}: {message}");
            }
            else
            {
                using var writer = CreateText(logAdr);
                writer.WriteLine(Now.ToString("HH:mm:ss") + $"{caption}: {message}");
            }
        }
    }
}
