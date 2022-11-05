using OtpNet;
using System;
using static Loginside_FYAN_Bot_Service.Script.Logger;
using static OtpNet.Base32Encoding;
using static System.IO.Directory;

namespace Loginside_FYAN_Bot_Service.Script
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
        /// <param name="secKey">Secret key.</param>
        /// <returns>OTP.</returns>
        internal static string GetOTP(string secKey)
        {
            try
            {
                return new Totp(ToBytes(secKey)).ComputeTotp();
            }
            catch (Exception ex)
            {
                WriteLog("Getter OTP error", ex.Message);
                return null;
            }
        }
        #endregion

        #region Numeric
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
    }
}
