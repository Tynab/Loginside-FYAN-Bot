using Loginside_FYAN_Bot.Script;
using System.ServiceProcess;
using System.Timers;
using static Loginside_FYAN_Bot.Properties.Settings;
using static Loginside_FYAN_Bot.Script.Logger;
using static System.DateTime;

namespace Loginside_FYAN_Bot
{
    public partial class ServiceMain : ServiceBase
    {
        #region Fields
        private readonly IService _service;
        #endregion

        #region Contsructors
        /// <summary>
        /// Main
        /// </summary>
        public ServiceMain(IService service)
        {
            InitializeComponent();
            _service = service;
        }
        #endregion

        #region Overridden
        protected override void OnStart(string[] args)
        {
            WriteLog("Service started at: " + Now.ToString("HH:mm:ss"));
            var tmrBot = new Timer
            {
                Interval = 60 * 1000,
                Enabled = true
            };
            tmrBot.Elapsed += OnTmrBotEvent;
        }

        protected override void OnStop()
        {
            _service.Dispose();
            WriteLog("Service stopped at: " + Now.ToString("HH:mm:ss"));
        }
        #endregion

        #region Events
        // On timer bot
        private void OnTmrBotEvent(object sender, ElapsedEventArgs e)
        {
            //if (Today.DayOfWeek != DayOfWeek.Sunday)
            //{
            if (Now.Hour == int.Parse(Default.Tmr_In.Substring(0, 2)) && Now.Minute == int.Parse(Default.Tmr_In.Substring(3, 2)))
            {
                _service.BotLogOI(true);
            }
            else if (Now.Hour == int.Parse(Default.Tmr_Out.Substring(0, 2)) && Now.Minute == int.Parse(Default.Tmr_Out.Substring(3, 2)))
            {
                _service.BotLogOI(false);
            }
            //}
        }
        #endregion
    }
}
