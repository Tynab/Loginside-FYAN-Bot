using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Configuration.ConfigurationManager;

namespace Loginside_FYAN_Bot_GUI.Script.Service
{
    internal class AppConfigService
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
