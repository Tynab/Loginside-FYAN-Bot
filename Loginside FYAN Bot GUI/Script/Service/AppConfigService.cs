using System;
using System.Configuration;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static System.AppDomain;
using static System.Configuration.ConfigurationManager;
using static System.IO.Directory;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static YANF.Script.YANConstant.MsgBoxLang;
using static YANF.Script.YANMessageBox;

namespace Loginside_FYAN_Bot_GUI.Script.Service
{
    public class AppConfigService : IAppConfigService
    {
        #region Fields
        private readonly Configuration _configuration;
        #endregion

        #region Constructors
        public AppConfigService()
        {
            var exeConfigurationFileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = $@"{GetParent(CurrentDomain.BaseDirectory)}\{serv_name}.exe.config"
            };
            _configuration = OpenMappedExeConfiguration(exeConfigurationFileMap, ConfigurationUserLevel.None);
        }
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
                _ = Show("LỖI", ex.Message, OK, Error, VIE);
                // try add new
                try
                {
                    _configuration.AppSettings.Settings.Add(key, value?.ToString());
                    _configuration.Save();
                }
                catch (Exception e)
                {
                    _ = Show("LỖI", e.Message, OK, Error, VIE);
                }
            }
        }
        #endregion
    }
}
