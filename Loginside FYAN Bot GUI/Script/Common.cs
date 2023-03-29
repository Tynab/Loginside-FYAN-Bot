using AnimatorNS;
using System;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static Loginside_FYAN_Bot_GUI.Script.Constant.ServSts;
using static System.Environment;
using static System.Security.Principal.WindowsBuiltInRole;
using static System.Security.Principal.WindowsIdentity;
using static System.ServiceProcess.ServiceControllerStatus;
using static System.TimeSpan;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static YANF.Script.YANConstant.MsgBoxLang;
using static YANF.Script.YANMessageBox;

namespace Loginside_FYAN_Bot_GUI.Script;

internal static class Common
{
    #region Text
    /// <summary>
    /// Has value.
    /// </summary>
    /// <param name="s">String.</param>
    /// <returns>String has value or not.</returns>
    internal static bool HasVal(this string s) => !string.IsNullOrWhiteSpace(s);

    /// <summary>
    /// Default for string.
    /// </summary>
    /// <param name="s">String.</param>
    /// <param name="dflt">Default string.</param>
    /// <returns>String has value.</returns>
    internal static string Dflt4(this string s, string dflt) => string.IsNullOrWhiteSpace(s) ? dflt : s;
    #endregion

    #region Numeric
    /// <summary>
    /// Parse int with default value if failed.
    /// </summary>
    /// <param name="s">String.</param>
    /// <param name="dfltVal">Default value.</param>
    /// <returns>Int number.</returns>
    internal static int IntPrs(this string s, int dfltVal) => int.TryParse(s, out var num) ? num : dfltVal;

    /// <summary>
    /// Parse to hour.
    /// </summary>
    /// <param name="s">String</param>
    /// <returns>Valid hour.</returns>
    internal static int HourPrs(string s)
    {
        _ = int.TryParse(s, out var rslt);
        return rslt is > 0 and < 24 ? rslt : 0;
    }

    /// <summary>
    /// Parse to minute.
    /// </summary>
    /// <param name="s">String.</param>
    /// <returns>Valid minute</returns>
    internal static int MinPrs(string s)
    {
        _ = int.TryParse(s, out var rslt);
        return rslt is > 0 and < 60 ? rslt : 0;
    }
    #endregion

    #region Windows
    /// <summary>
    /// Get service status.
    /// </summary>
    /// <param name="name">Service name.</param>
    /// <returns>Service status.</returns>
    internal static ServSts GetServSts(string name)
    {
        try
        {
            return new ServiceController(name)?.Status == Running ? Started : Stoped;
        }
        catch
        {
            return NotFd;
        }
    }

    /// <summary>
    /// Start service.
    /// </summary>
    /// <param name="name">Service name.</param>
    /// <param name="ms">Time out (milisecond).</param>
    /// <returns>Is success.</returns>
    internal static bool StrtServ(string name, int ms)
    {
        try
        {
            var servCtrl = new ServiceController(name);
            if (servCtrl?.Status != Running)
            {
                servCtrl?.Start();
                servCtrl?.WaitForStatus(Running, FromMilliseconds(ms));
            }
            return true;
        }
        catch (Exception ex)
        {
            _ = MsgEFree(ex?.Message);
            return false;
        }
    }

    /// <summary>
    /// Stop service.
    /// </summary>
    /// <param name="name">Service name.</param>
    /// <param name="ms">Time out (milisecond).</param>
    /// <returns>Is success.</returns>
    internal static bool StopServ(string name, int ms)
    {
        try
        {
            var servCtrl = new ServiceController(name);
            if (servCtrl?.Status == Running)
            {
                servCtrl?.Stop();
                servCtrl?.WaitForStatus(Stopped, FromMilliseconds(ms));
            }
            return true;
        }
        catch (Exception ex)
        {
            _ = MsgEFree(ex?.Message);
            return false;
        }
    }

    /// <summary>
    /// Restart service.
    /// </summary>
    /// <param name="name">Service name.</param>
    /// <param name="ms">Time out (milisecond).</param>
    /// <returns>Is success.</returns>
    internal static bool RstServ(string name, int ms)
    {
        try
        {
            var servCtrl = new ServiceController(name);
            var timeout = FromMilliseconds(ms);
            if (servCtrl?.Status == Running)
            {
                var msStop = TickCount;
                servCtrl?.Stop();
                servCtrl?.WaitForStatus(Stopped, timeout);
                var msStart = TickCount;
                timeout = FromMilliseconds(ms - (msStart - msStop));
                servCtrl?.Start();
                servCtrl?.WaitForStatus(Running, timeout);
            }
            else
            {
                servCtrl?.Start();
                servCtrl?.WaitForStatus(Running, timeout);
            }
            return true;
        }
        catch (Exception ex)
        {
            _ = MsgEFree(ex?.Message);
            return false;
        }
    }

    /// <summary>
    /// Check app run admin.
    /// </summary>
    /// <returns>App run as admin.</returns>
    internal static bool IsAdmin() => new WindowsPrincipal(GetCurrent()).IsInRole(Administrator);
    #endregion

    #region Animator
    /// <summary>
    /// Show animation.
    /// </summary>
    /// <param name="type">Effect type.</param>
    /// <param name="spd">Frame per milisecond.</param>
    internal static void ShowAnimat(this Control ctrl, AnimationType type, float spd) => new Animator
    {
        TimeStep = spd,
        AnimationType = type
    }?.ShowSync(ctrl);

    /// <summary>
    /// Hide animation.
    /// </summary>
    /// <param name="type">Effect type.</param>
    /// <param name="spd">Frame per milisecond.</param>
    internal static void HideAnimat(this Control ctrl, AnimationType type, float spd) => new Animator
    {
        TimeStep = spd,
        AnimationType = type
    }?.HideSync(ctrl);

    /// <summary>
    /// Show animation async.
    /// </summary>
    /// <param name="type">Effect type.</param>
    /// <param name="spd">Frame per milisecond.</param>
    internal static void ShowAnimatAsync(this Control ctrl, AnimationType type, float spd) => new Animator
    {
        TimeStep = spd,
        AnimationType = type
    }?.Show(ctrl);

    /// <summary>
    /// Hide animation async.
    /// </summary>
    /// <param name="type">Effect type.</param>
    /// <param name="spd">Frame per milisecond.</param>
    internal static void HideAnimatAsync(this Control ctrl, AnimationType type, float spd) => new Animator
    {
        TimeStep = spd,
        AnimationType = type
    }?.Hide(ctrl);
    #endregion

    #region MsgBox
    /// <summary>
    /// Quá trình cài đặt bot service không thành công.
    /// </summary>
    /// <returns>Dialog result.</returns>
    internal static DialogResult MsgEServNotFd() => Show("LỖI", "Quá trình cài đặt bot service không thành công!", OK, Error, VIE);

    /// <summary>
    /// Mật khẩu phải từ 8 ký tự trở lên. Gồm chữ in, chữ thường, số và ký tự đặc biệt (@, #, $, %).
    /// </summary>
    /// <returns>Dialog result.</returns>
    internal static DialogResult MsgEPwdFail() => Show("LỖI", "Mật khẩu phải từ 8 ký tự trở lên. Gồm chữ in, chữ thường, số và ký tự đặc biệt (@, #, $, %).", OK, Error, VIE);

    /// <summary>
    /// Free message error.
    /// </summary>
    /// <param name="msg">Messsage.</param>
    /// <returns>Dialog result.</returns>
    internal static DialogResult MsgEFree(string msg) => Show("LỖI", msg, OK, Error, VIE);

    /// <summary>
    /// Thành công.
    /// </summary>
    /// <returns>Dialog result.</returns>
    internal static DialogResult MsgIDone() => Show("THÔNG BÁO", "Thành công!", OK, Information, VIE);
    #endregion

    #region Other
    /// <summary>
    /// Check valid password.
    /// </summary>
    /// <param name="s">Password.</param>
    /// <returns>Is valid.</returns>
    internal static bool IsVldPwd(string s) => s.HasVal() && s?.Length >= 8 && new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$").IsMatch(s);
    #endregion
}
