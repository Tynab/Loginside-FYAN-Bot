﻿using Loginside_FYAN_Bot.Screen;
using System.Linq;
using System.Windows.Forms;
using static Loginside_FYAN_Bot.Properties.Resources;
using static Loginside_FYAN_Bot.Script.Constant;
using static Loginside_FYAN_Bot.Script.EventHandler;
using static Loginside_FYAN_Bot.Script.Root;
using static System.Diagnostics.Process;
using static System.Environment;
using static System.IO.File;
using static System.Windows.Forms.Application;

HideConsole();
// check manager running
if (GetProcessesByName(bot_name).Count() > 1)
{
    Exit();
}
else
{
    // startup
    if (CurrentDirectory != STD_PATH)
    {
        Start(TOOL_ADR);
        Exit();
    }
    // check app running
    if (GetProcessesByName(app_name).Count() < 1)
    {
        if (Exists(APP_ADR))
        {
            Start(APP_ADR);
        }
        else
        {
            new Manager().Show();
        }
    }
    new Timer
    {
        Interval = TMR_INTVL,
        Enabled = true
    }.Tick += OnTmrMainEvent;
    Run();
}
