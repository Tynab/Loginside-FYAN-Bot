using Loginside_FYAN_Bot_Service.Script;
using Loginside_FYAN_Bot_Service.Script.Model;
using System.ServiceProcess;
using System.Timers;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static System.DateTime;
using static System.DayOfWeek;

namespace Loginside_FYAN_Bot_Service;

public partial class ServiceMain : ServiceBase
{
    #region Fields
    private readonly Logger _logger = new();
    private readonly AppConfig _appConfig = new();
    private bool _isPwdChgd = false;
    #endregion

    #region Constructors
    public ServiceMain() => InitializeComponent();
    #endregion

    #region Overridden
    protected override void OnStart(string[] args)
    {
        _logger?.WrInfo(BOT_NAME, "Started!");
        new Timer
        {
            Interval = TMR_INTVL,
            Enabled = true
        }.Elapsed += OnTmrBotEvent;
    }

    protected override void OnStop() => _logger?.WrInfo(BOT_NAME, "Stopped!");
    #endregion

    #region Events
    // On timer bot
    private void OnTmrBotEvent(object sender, ElapsedEventArgs e)
    {
        KillPrcs(cr_prcs);
        KillPrcs(ge_prcs);
        KillPrcs(ie_prcs);
        // for time
        if (Today.DayOfWeek != Sunday && Now.Hour > 0)
        {
            if (Now.Hour == HourPrs(GetHourConfig(tmr_in)) && Now.Minute == MinPrs(GetMinConfig(tmr_in)))
            {
                new FyanBot
                {
                    IsCheckIn = true
                }?.BotChk();
            }
            else if (Now.Hour == HourPrs(GetHourConfig(tmr_out)) && Now.Minute == MinPrs(GetMinConfig(tmr_out)))
            {
                new FyanBot
                {
                    IsCheckIn = false
                }?.BotChk();
            }
        }
        // for date
        if (!_isPwdChgd && Today.Day == MinDayPrs(_appConfig?.Getter(day_chg_pwd)))
        {
            new FyanBot()?.BotPwd();
            _isPwdChgd = true;
        }
    }
    #endregion

    #region Methods
    // Get hour from config
    private string GetHourConfig(string key)
    {
        var rslt = _appConfig?.Getter(key)?.Split(':')[0];
        return int.TryParse(rslt, out var _) ? rslt : "00";
    }

    // Get minute from config
    private string GetMinConfig(string key)
    {
        var rslt = _appConfig?.Getter(key)?.Split(':')[1];
        return int.TryParse(rslt, out var _) ? rslt : "00";
    }
    #endregion
}
