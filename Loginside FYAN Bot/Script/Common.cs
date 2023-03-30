using System;
using System.IO;
using System.Net.NetworkInformation;
using System.ServiceProcess;
using static Loginside_FYAN_Bot.Properties.Resources;
using static Loginside_FYAN_Bot.Script.Constant;
using static System.Diagnostics.Process;
using static System.IO.Directory;
using static System.Net.NetworkInformation.IPStatus;
using static System.ServiceProcess.ServiceControllerStatus;
using static System.Threading.Thread;
using static System.TimeSpan;
using static System.Windows.Forms.MessageBox;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

namespace Loginside_FYAN_Bot.Script;

internal static class Common
{
    #region Connect
    /// <summary>
    /// Check internet connection.
    /// </summary>
    /// <returns>Connection state.</returns>
    internal static bool IsNetAvail()
    {
        try
        {
            var buffer = new byte[32];
            return new Ping().Send(link_base, TIME_OUT, buffer, new PingOptions()).Status == Success;
        }
        catch (Exception)
        {
            return false;
        }
    }
    #endregion

    #region Window
    /// <summary>
    /// Stop service.
    /// </summary>
    /// <param name="name">Service name.</param>
    /// <param name="ms">Time out (milisecond).</param>
    /// <returns>Is success.</returns>
    internal static void StopServ(string name, int ms)
    {
        try
        {
            var servCtrl = new ServiceController(name);
            if (servCtrl?.Status == Running)
            {
                servCtrl?.Stop();
                servCtrl?.WaitForStatus(Stopped, FromMilliseconds(ms));
            }
        }
        catch (Exception ex)
        {
            _ = Show($"Không thể tắt windows service!\n{ex.Message}", "LỖI", OK, Error);
        }
    }
    #endregion

    #region IO
    /// <summary>
    /// Create directory advanced.
    /// </summary>
    /// <param name="path">Folder path.</param>
    internal static void CrtDirAdv(string path)
    {
        if (!Exists(path))
        {
            CreateDirectory(path);
        }
    }

    /// <summary>
    /// Delete file advanced.
    /// </summary>
    /// <param name="adr">File address.</param>
    internal static void DelFileAdv(string adr)
    {
        if (File.Exists(adr))
        {
            File.Delete(adr);
        }
    }
    #endregion

    #region Other
    /// <summary>
    /// Kill process.
    /// </summary>
    /// <param name="name">Process name.</param>
    internal static void KillPrcs(string name)
    {
        // normal close
        var procs = GetProcessesByName(name);
        foreach (var proc in procs)
        {
            if (!proc.CloseMainWindow())
            {
                Sleep(TMR_INTVL_DFLT);
                proc?.Kill();
            }
        }
        Sleep(TMR_INTVL_DFLT * 10);
        // kill
        procs = GetProcessesByName(name);
        foreach (var proc in procs)
        {
            Sleep(TMR_INTVL_DFLT);
            proc?.Kill();
        }
    }
    #endregion
}
