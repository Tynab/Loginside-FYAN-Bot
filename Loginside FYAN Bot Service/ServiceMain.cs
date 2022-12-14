using Loginside_FYAN_Bot_Service.Script;
using Loginside_FYAN_Bot_Service.Script.Service;
using System.ServiceProcess;
using System.Timers;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static Loginside_FYAN_Bot_Service.Script.Logger;
using static System.DateTime;
using static System.DayOfWeek;

namespace Loginside_FYAN_Bot_Service
{
    public partial class ServiceMain : ServiceBase
    {
        #region Fields
        private readonly IAppConfigService _appConfigService;
        private readonly IBotService _botService;
        private bool _isPwdChgd = false;
        #endregion

        #region Constructors
        public ServiceMain()
        {
            InitializeComponent();
            _appConfigService = new AppConfigService();
            _botService = new BotService();
        }
        #endregion

        #region Overridden
        protected override void OnStart(string[] args)
        {
            WriteLog("Bot", "Started!");
            var tmrBot = new Timer
            {
                Interval = TMR_INTVL,
                Enabled = true
            };
            tmrBot.Elapsed += OnTmrBotEvent;
        }

        protected override void OnStop() => WriteLog("Bot", "Stopped!");
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
                var sInHour = GetHourConfig(tmr_in);
                var sInMin = GetMinConfig(tmr_in);
                var sOutHour = GetHourConfig(tmr_out);
                var sOutMin = GetMinConfig(tmr_out);
                // on time
                if (Now.Hour == HourPrs(sInHour) && Now.Minute == MinPrs(sInMin))
                {
                    _botService.BotStem(true);
                }
                else if (Now.Hour == HourPrs(sOutHour) && Now.Minute == MinPrs(sOutMin))
                {
                    _botService.BotStem(false);
                }
            }
            // for date
            if (!_isPwdChgd && Today.Day == MinDayPrs(_appConfigService.Getter(day_chg_pwd)))
            {
                _botService.BotPwd();
                _isPwdChgd = true;
            }
        }
        #endregion

        #region Methods
        // Get hour from config
        private string GetHourConfig(string key)
        {
            var rslt = _appConfigService.Getter(key).Split(':')[0];
            return int.TryParse(rslt, out var _) ? rslt : "00";
        }

        // Get minute from config
        private string GetMinConfig(string key)
        {
            var rslt = _appConfigService.Getter(key).Split(':')[1];
            return int.TryParse(rslt, out var _) ? rslt : "00";
        }
        #endregion
    }
}
