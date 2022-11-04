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
            if (Today.DayOfWeek != Sunday && Now.Hour > 0)
            {
                var sInHour = GetHourConfig(tmr_in);
                var sInMinute = GetMinuteConfig(tmr_in);
                var sOutHour = GetHourConfig(tmr_out);
                var sOutMinute = GetMinuteConfig(tmr_out);
                // on time
                if (Now.Hour == HourParse(sInHour) && Now.Minute == MinuteParse(sInMinute))
                {
                    _botService.BotStem(true);
                }
                else if (Now.Hour == HourParse(sOutHour) && Now.Minute == MinuteParse(sOutMinute))
                {
                    _botService.BotStem(false);
                }
            }
        }
        #endregion

        #region Methods
        // Get hour from config
        private string GetHourConfig(string key)
        {
            var rsltFull = _appConfigService.Getter(key).Substring(0, 2);
            var rsltRip = _appConfigService.Getter(key).Substring(0, 1);
            return int.TryParse(rsltFull, out var _) ? rsltFull : int.TryParse(rsltRip, out var _) ? rsltRip : "00";
        }

        // Get minute from config
        private string GetMinuteConfig(string key)
        {
            var rsltFull = _appConfigService.Getter(key).Substring(2);
            var rsltRip = _appConfigService.Getter(key).Substring(3);
            return int.TryParse(rsltFull, out var _) ? rsltFull : int.TryParse(rsltRip, out var _) ? rsltRip : "00";
        }
        #endregion
    }
}
