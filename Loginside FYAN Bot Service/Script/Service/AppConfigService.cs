using System;
using System.Configuration;
using static System.Configuration.ConfigurationManager;
using static System.Reflection.Assembly;
using static Loginside_FYAN_Bot_Service.Script.Logger;

namespace Loginside_FYAN_Bot_Service.Script.Service
{
    public class AppConfigService : IAppConfigService
    {
        #region Fields
        //public readonly Configuration _configuration = OpenExeConfiguration($@"{CurrentDomain.BaseDirectory}\{app_name}.exe");
        public readonly Configuration _configuration = OpenExeConfiguration(GetExecutingAssembly().Location);
        #endregion

        #region Methods
        public string Getter(string key)
        {
            try
            {
                return AppSettings[key].ToString();
            }
            catch (Exception ex)
            {
                WriteLog("Getter app config error", ex.Message);
                return null;
            }
        }

        public void Setter<T>(string key, T value)
        {
            try
            {
                _configuration.AppSettings.Settings[key].Value = value.ToString();
                _configuration.Save();
                RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                WriteLog("Setter app config error", ex.Message);
            }
        }
        #endregion
    }
}
