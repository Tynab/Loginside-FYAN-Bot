using Loginside_FYAN_Bot_GUI.Screen;
using System;
using System.Threading;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static System.GC;
using static System.Windows.Forms.Application;

namespace Loginside_FYAN_Bot_GUI;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // mutex
        var mutex = new Mutex(true, app_name, out var rslt);
        if (!rslt)
        {
            return;
        }
        EnableVisualStyles();
        SetCompatibleTextRenderingDefault(false);
        Run(new FrmMain());
        KeepAlive(mutex);
    }
}
