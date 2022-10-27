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
        public string Getter(string key) => _configuration.AppSettings.Settings[key].Value?.ToString();

        public void Setter<T>(string key, T value)
        {
            try
            {
                _configuration.AppSettings.Settings[key].Value = value?.ToString();
                _configuration.Save();
            }
            catch (Exception ex)
            {
                WriteLog("Bot error", ex.Message);
                // try add new
                try
                {
                    _configuration.AppSettings.Settings.Add(key, value?.ToString());
                    _configuration.Save();
                }
                catch (Exception e)
                {
                    WriteLog("Bot error", e.Message);
                }
            }
        }
        #endregion
    }
}
