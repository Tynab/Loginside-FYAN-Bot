﻿using System;
using System.Configuration;
using static Loginside_FYAN_Bot_GUI.Script.Common;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.Configuration.ConfigurationManager;
using static System.IO.File;

namespace Loginside_FYAN_Bot_GUI.Script;

internal class AppConfig
{
    #region Fields
    private readonly Configuration _cfg;
    #endregion

    #region Constructors
    internal AppConfig() => _cfg = OpenMappedExeConfiguration(new ExeConfigurationFileMap
    {
        ExeConfigFilename = CONFIG_ADR
    }, ConfigurationUserLevel.None);
    #endregion

    #region Methods
    /// <summary>
    /// Get value from app config.
    /// </summary>
    /// <param name="key">Key.</param>
    /// <returns>Value as string.</returns>
    internal string Getter(string key) => Exists(CONFIG_ADR) ? _cfg?.AppSettings?.Settings[key]?.Value?.ToString() : null;

    /// <summary>
    /// Set value to app config.
    /// </summary>
    /// <typeparam name="T">Datatype.</typeparam>
    /// <param name="key">Key.</param>
    /// <param name="value">Value.</param>
    /// <returns>Is success.</returns>
    internal bool Setter<T>(string key, T value)
    {
        try
        {
            _cfg.AppSettings.Settings[key].Value = value?.ToString();
            _cfg?.Save();
            return true;
        }
        catch (Exception ex)
        {
            _ = MsgEFree(ex?.Message);
            try
            {
                _cfg.AppSettings.Settings.Add(key, value?.ToString());
                _cfg?.Save();
                return true;
            }
            catch (Exception e)
            {
                _ = MsgEFree(e?.Message);
                return false;
            }
        }
    }
    #endregion
}
