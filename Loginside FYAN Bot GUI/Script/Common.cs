using System.Security.Principal;
using System.ServiceProcess;
using static System.Environment;
using static System.Security.Principal.WindowsBuiltInRole;
using static System.Security.Principal.WindowsIdentity;
using static System.ServiceProcess.ServiceControllerStatus;
using static System.TimeSpan;

namespace Loginside_FYAN_Bot_GUI.Script
{
    internal class Common
    {
        #region Numeric
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
        #endregion

        #region Windows
        /// <summary>
        /// Restart service.
        /// </summary>
        /// <param name="name">Service name.</param>
        /// <param name="ms">Time out (milisecond).</param>
        internal static void RestartService(string name, int ms)
        {
            try
            {
                var servCtrl = new ServiceController(name);
                var timeout = FromMilliseconds(ms);
                if (servCtrl.Status == Running)
                {
                    var msStop = TickCount;
                    servCtrl.Stop();
                    servCtrl.WaitForStatus(Stopped, timeout);
                    var msStart = TickCount;
                    timeout = FromMilliseconds(ms - (msStart - msStop));
                    servCtrl.Start();
                    servCtrl.WaitForStatus(Running, timeout);
                }
                else
                {
                    servCtrl.Start();
                    servCtrl.WaitForStatus(Stopped, timeout);
                }
            }
            catch (Exception ex)
            {
                new Page().DisplayAlert("LỖI", ex.Message, "Đóng");
            }
        }

        /// <summary>
        /// Check app run admin.
        /// </summary>
        /// <returns>App run as admin.</returns>
        public static bool IsAdministrator() => new WindowsPrincipal(GetCurrent()).IsInRole(Administrator);
        #endregion
    }
}
