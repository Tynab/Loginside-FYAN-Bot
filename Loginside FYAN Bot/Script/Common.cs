using OtpNet;
using System;
using System.Runtime.InteropServices;
using static Loginside_FYAN_Bot.Properties.Settings;
using static Loginside_FYAN_Bot.Script.Constant;
using static OtpNet.Base32Encoding;
using static System.IO.Directory;

namespace Loginside_FYAN_Bot.Script
{
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
        /// <returns></returns>
        internal static string CodeOTP() => new Totp(ToBytes(Default.Sec_Key)).ComputeTotp();
        #endregion

        #region Logon
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool LogonUserA(string username, string domain, string password, int logonType, int logonProvider, out IntPtr userToken);

        /// <summary>
        /// Logon user.
        /// </summary>
        /// <returns>State.</returns>
        internal static bool LogonUser() => LogonUserA(Default.Name_User, Default.Dom_User, Default.Pwd_User, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out var token);
        #endregion
    }
}
