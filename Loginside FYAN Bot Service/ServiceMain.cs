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
    private bool _isPwdChgd = false;
    #endregion

    #region Constructors
    public ServiceMain() => InitializeComponent();
    #endregion

    #region Overridden
    protected override void OnStart(string[] args)
    {
        new Logger().WrLog("Bot", "Started!");
        var tmrBot = new Timer
        {
            Interval = TMR_INTVL,
            Enabled = true
        };
        tmrBot.Elapsed += OnTmrBotEvent;
    }

    protected override void OnStop() => new Logger().WrLog("Bot", "Stopped!");
    #endregion

    #region Events
    // On timer bot
    private void OnTmrBotEvent(object sender, ElapsedEventArgs e)
    {
        KillPrcs(cr_prcs);
        KillPrcs(ge_prcs);
        KillPrcs(ie_prcs);
        var bot = new FyanBot();
        // for time
        if (Today.DayOfWeek != Sunday && Now.Hour > 0)
        {
            var sInHour = GetHourConfig(tmr_in);
            var sInMin = GetMinConfig(tmr_in);
            var sOutHour = GetHourConfig(tmr_out);
            var sOutMin = GetMinConfig(tmr_out);
            // on time
            if (Now.Hour == HourPrs(sInHour) && Now.Minute == MinPrs(sInMin))
            {
                bot.IsCheckIn = true;
                bot.BotChk();
            }
            else if (Now.Hour == HourPrs(sOutHour) && Now.Minute == MinPrs(sOutMin))
            {
                bot.IsCheckIn = false;
                bot.BotChk();
            }
        }
        // for date
        if (!_isPwdChgd && Today.Day == MinDayPrs(new AppConfig().Getter(day_chg_pwd)))
        {
            bot.BotPwd();
            _isPwdChgd = true;
        }
    }
    #endregion

    #region Methods
    // Get hour from config
    private string GetHourConfig(string key)
    {
        var rslt = new AppConfig().Getter(key).Split(':')[0];
        return int.TryParse(rslt, out var _) ? rslt : "00";
    }

    // Get minute from config
    private string GetMinConfig(string key)
    {
        var rslt = new AppConfig().Getter(key).Split(':')[1];
        return int.TryParse(rslt, out var _) ? rslt : "00";
    }
    #endregion
}
