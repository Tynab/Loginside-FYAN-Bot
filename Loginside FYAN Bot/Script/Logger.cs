using System;
using static Loginside_FYAN_Bot.Script.Common;
using static System.DateTime;
using static System.IO.File;

namespace Loginside_FYAN_Bot.Script
{
    internal static class Logger
    {
        /// <summary>
        /// Log writer
        /// </summary>
        /// <param name="message">Message.</param>
        internal static void WriteLog(string message)
        {
            var logPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Log";
            var logAdr = logPath + "\\" + Today.ToString("dd-MM-yyyy") + ".txt";
            CrtDirAdv(logPath);
            if (Exists(logAdr))
            {
                using (var writer = AppendText(logAdr))
                {
                    writer.WriteLine(message);
                }
            }
            else
            {
                using (var writer = CreateText(logAdr))
                {
                    writer.WriteLine(message);
                }
            }
        }
    }
}
