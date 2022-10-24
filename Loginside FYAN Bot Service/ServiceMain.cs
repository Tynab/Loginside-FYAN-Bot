using Loginside_FYAN_Bot_Service.Script;
using Loginside_FYAN_Bot_Service.Script.Service;
using System.ServiceProcess;
using System.Timers;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
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

        #region Contsructors
        /// <summary>
        /// Main
        /// </summary>
        public ServiceMain()
        {
            InitializeComponent();
            _appConfigService = new AppConfigService();
            _botService = new BotService(_appConfigService);
        }
        #endregion

        #region Overridden
        protected override void OnStart(string[] args)
        {
            WriteLog("Bot", "Started!");
            var tmrBot = new Timer
            {
                Interval = 60 * 1000,
                Enabled = true
            };
            tmrBot.Elapsed += OnTmrBotEvent;
        }

        protected override void OnStop()
        {
            _botService.Dispose();
            WriteLog("Bot", "Stopped!");
        }
        #endregion

        #region Events
        // On timer bot
        private void OnTmrBotEvent(object sender, ElapsedEventArgs e)
        {
            if (Today.DayOfWeek != Sunday)
            {
                var tmrIn = _appConfigService.Getter(tmr_in);
                var tmrOut = _appConfigService.Getter(tmr_out);
                if (Now.Hour == GetHourFromAppConfig(tmrIn) && Now.Minute == GetMinuteFromAppConfig(tmrIn))
                {
                    _botService.BotLogOI(true);
                }
                else if (Now.Hour == GetHourFromAppConfig(tmrOut) && Now.Minute == GetHourFromAppConfig(tmrOut))
                {
                    _botService.BotLogOI(false);
                }
            }
        }
        #endregion
    }
}
