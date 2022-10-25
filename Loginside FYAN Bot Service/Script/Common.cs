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
        /// Get hour from app config.
        /// </summary>
        /// <param name="time">Time string.</param>
        /// <returns>Hour.</returns>
        internal static int? GetHourFromAppConfig(string time)
        {
            try
            {
                return int.Parse(time.Substring(0, 2));
            }
            catch (Exception ex)
            {
                WriteLog("Getter hour error", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Get minute from app config.
        /// </summary>
        /// <param name="time">Time string.</param>
        /// <returns>Minute.</returns>
        internal static int? GetMinuteFromAppConfig(string time)
        {
            try
            {
                return int.Parse(time.Substring(3, 2));
            }
            catch (Exception ex)
            {
                WriteLog("Getter minute error", ex.Message);
                return null;
            }
        }
        #endregion
    }
}
