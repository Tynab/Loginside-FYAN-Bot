using System.Linq;
using System.Windows.Forms;
using static Loginside_FYAN_Bot.Properties.Resources;
using static Loginside_FYAN_Bot.Script.Constant;
using static Loginside_FYAN_Bot.Script.EventHandler;
using static Loginside_FYAN_Bot.Script.Root;
using static System.Diagnostics.Process;
using static System.Environment;
using static System.Windows.Forms.Application;

HideConsole();
// check app running
if (GetProcessesByName(app_name).Count() < 1)
{
    _ = Start(APP_ADR);
}
// check manager running
if (GetProcessesByName(bot_name).Count() > 1)
{
    Exit();
}
else
{
    new Timer
    {
        Interval = TMR_INTVL,
        Enabled = true
    }.Tick += OnTmrMainEvent;
    Run();
}
