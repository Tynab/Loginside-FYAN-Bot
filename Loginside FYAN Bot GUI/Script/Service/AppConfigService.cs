using System.Configuration;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.AppDomain;
using static System.Configuration.ConfigurationManager;

namespace Loginside_FYAN_Bot_GUI.Script.Service
{
    internal class AppConfigService : IAppConfigService
    {
        #region Fields
        //private readonly Configuration _configuration = OpenExeConfiguration($@"{CurrentDomain.BaseDirectory}\{BOT_NAME}.exe.config");
        //private Configuration _configuration = OpenExeConfiguration(@"D:\cc.exe.config");
        #endregion

        #region Methods
        public string Getter(string key) => !string.IsNullOrWhiteSpace(AppSettings[key]) ? AppSettings[key].ToString() : "";

        public void Setter(string key, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                try
                {
                    Configuration _configuration = OpenExeConfiguration(@"D:\cc.exe");
                    _configuration.AppSettings.Settings[key].Value = value;
                    _configuration.Save();
                    //RefreshSection("appSettings");
                }
                catch (Exception ex)
                {
                    new Page().DisplayAlert("LỖI", ex.Message, "Đóng");
                }
            }
        }
        #endregion
    }
}
