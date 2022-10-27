using System.Configuration;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.AppDomain;
using static System.Configuration.ConfigurationManager;
using static System.Configuration.ConfigurationUserLevel;
using static System.IO.Directory;

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
                ExeConfigFilename = $@"{GetParent(CurrentDomain.BaseDirectory)}\{BOT_NAME}.exe.config"
            };
            _configuration = OpenMappedExeConfiguration(exeConfigurationFileMap, None);
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
                new Page().DisplayAlert("LỖI", ex.Message, "Đóng");
                // try add new
                try
                {
                    _configuration.AppSettings.Settings.Add(key, value?.ToString());
                    _configuration.Save();
                }
                catch (Exception e)
                {
                    new Page().DisplayAlert("LỖI", e.Message, "Đóng");
                }
            }
        }
        #endregion
    }
}
