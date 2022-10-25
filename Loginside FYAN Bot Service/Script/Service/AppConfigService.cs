using System;
using System.Configuration;
using static Loginside_FYAN_Bot_Service.Script.Logger;
using static System.Configuration.ConfigurationManager;
using static System.Reflection.Assembly;

namespace Loginside_FYAN_Bot_Service.Script.Service
{
    public class AppConfigService : IAppConfigService
    {
        #region Fields
        private readonly Configuration _configuration = OpenExeConfiguration(GetExecutingAssembly().Location);
        #endregion

        #region Methods
        public string Getter(string key) => !string.IsNullOrWhiteSpace(AppSettings[key]) ? AppSettings[key].ToString() : "";

        public void Setter<T>(string key, T value)
        {
            if (value != null)
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
        }
        #endregion
    }
}
