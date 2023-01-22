using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static OtpNet.Base32Encoding;
using static System.Diagnostics.Process;
using static System.IO.Directory;
using static System.Threading.Tasks.Task;
using static System.Threading.Tasks.TaskStatus;
using static System.Threading.Thread;

namespace Loginside_FYAN_Bot_Service.Script;

internal static class Common
{
    #region Directory
    /// <summary>
    /// Create folder advanced.
    /// </summary>
    /// <param name="path">Folder path.</param>
    internal static void CrtDirAdv(string path)
    {
        if (!Exists(path))
        {
            CreateDirectory(path);
        }
    }
    #endregion

    #region OTP
    /// <summary>
    /// Get OTP.
    /// </summary>
    /// <param name="secKey">Secret key.</param>
    /// <returns>OTP.</returns>
    internal static string GetOtp(string secKey)
    {
        try
        {
            return new Totp(ToBytes(secKey)).ComputeTotp();
        }
        catch (Exception ex)
        {
            new Logger().WrLog("Getter OTP error", ex.Message);
            return string.Empty;
        }
    }
    #endregion

    #region Text
    /// <summary>
    /// Has values.
    /// </summary>
    /// <param name="ss">String params.</param>
    /// <returns>Params has value.</returns>
    internal static bool HasVals(params string[] ss) => ss.All(s => !string.IsNullOrWhiteSpace(s));
    #endregion

    #region Numeric
    /// <summary>
    /// Parse to min day.
    /// </summary>
    /// <param name="s">String</param>
    /// <returns>Valid hour.</returns>
    internal static int MinDayPrs(string s)
    {
        _ = int.TryParse(s, out var rslt);
        return rslt is > 1 and < 28 ? rslt : DFLT_DAY;
    }

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

    #region Other
    /// <summary>
    /// Kill process.
    /// </summary>
    /// <param name="name">Process name.</param>
    internal static void KillPrcs(string name)
    {
        if (GetProcessesByName(name).Count() > 0)
        {
            foreach (var prc in GetProcessesByName(name))
            {
                prc.Kill();
                Sleep(TMR_INTVL_DFLT);
            }
        }
    }
    #endregion

    #region Task
    /// <summary>
    /// Wait any with condition.
    /// </summary>
    /// <typeparam name="T">Datatype.</typeparam>
    /// <param name="tasks">Tasks.</param>
    /// <param name="goodRslt">Good result.</param>
    /// <returns></returns>
    internal static async Task<T> WaitAnyWithCond<T>(this IEnumerable<Task<T>> tasks, T goodRslt)
    {
        var taskList = new List<Task<T>>(tasks);
        var fstCmpl = default(Task<T>);
        while (taskList.Count > 0)
        {
            var curCmpl = await WhenAny(taskList);
            if (curCmpl.Status == RanToCompletion && curCmpl.Result.Equals(goodRslt))
            {
                fstCmpl = curCmpl;
                break;
            }
            else
            {
                taskList.Remove(curCmpl);
            }
        }
        return (fstCmpl != default(Task<T>)) ? fstCmpl.Result : default;
    }
    #endregion
}
