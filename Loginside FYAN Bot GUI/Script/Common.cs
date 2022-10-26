using System.ServiceProcess;
using static System.Environment;
using static System.ServiceProcess.ServiceControllerStatus;
using static System.TimeSpan;

namespace Loginside_FYAN_Bot_GUI.Script
{
    internal class Common
    {
        /// <summary>
        /// Parse to hour.
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>Valid hour.</returns>
        internal static int HourParse(string s)
        {
            _ = int.TryParse(s, out var rslt);
            return rslt is > 0 and < 24 ? rslt : 0;
        }

        /// <summary>
        /// Parse to minute.
        /// </summary>
        /// <param name="s">String.</param>
        /// <returns>Valid minute</returns>
        internal static int MinuteParse(string s)
        {
            _ = int.TryParse(s, out var rslt);
            return rslt is > 0 and < 60 ? rslt : 0;
        }

        /// <summary>
        /// Restart service.
        /// </summary>
        /// <param name="name">Service name.</param>
        /// <param name="ms">Time out (milisecond).</param>
        internal static void RestartService(string name, int ms)
        {
            try
            {
                var service = new ServiceController(name);
                var msStop = TickCount;
                var timeout = FromMilliseconds(ms);
                service.Stop();
                service.WaitForStatus(Stopped, timeout);
                var msStart = TickCount;
                timeout = FromMilliseconds(ms - (msStart - msStop));
                service.Start();
                service.WaitForStatus(Running, timeout);
            }
            catch (Exception ex)
            {
                new Page().DisplayAlert("LỖI", ex.Message, "Đóng");
            }
        }
    }
}
