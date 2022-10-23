using Loginside_FYAN_Bot.Script.Service;
using System.ServiceProcess;

namespace Loginside_FYAN_Bot
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceMain(new BotService())
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
