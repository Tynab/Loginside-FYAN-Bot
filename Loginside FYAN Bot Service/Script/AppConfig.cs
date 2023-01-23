using System;
using System.Configuration;
using static System.Configuration.ConfigurationManager;
using static System.Reflection.Assembly;

namespace Loginside_FYAN_Bot_Service.Script;

internal class AppConfig
{
    #region Fields
    private readonly Logger _logger = new();
    private readonly Configuration _cfg = OpenExeConfiguration(GetExecutingAssembly().Location);
    #endregion

    #region Methods
    /// <summary>
    /// Get value from app config.
    /// </summary>
    /// <param name="key">Key.</param>
    /// <returns>Value as string.</returns>
    internal string Getter(string key) => _cfg.AppSettings.Settings[key].Value?.ToString();

    /// <summary>
    /// Set value to app config.
    /// </summary>
    /// <typeparam name="T">Datatype.</typeparam>
    /// <param name="key">Key.</param>
    /// <param name="value">Value.</param>
    internal void Setter<T>(string key, T value)
    {
        try
        {
            _cfg.AppSettings.Settings[key].Value = value?.ToString();
            _cfg.Save();
        }
        catch (Exception ex1)
        {
            _logger.WrLog("Bot error", ex1.Message);
            // try add new
            try
            {
                _cfg.AppSettings.Settings.Add(key, value?.ToString());
                _cfg.Save();
            }
            catch (Exception ex2)
            {
                _logger.WrLog("Bot error", ex2.Message);
            }
        }
    }
    #endregion
}
