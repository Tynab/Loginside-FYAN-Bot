﻿using Loginside_FYAN_Bot_GUI.Screen;
using System;
using System.Threading;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static System.GC;
using static System.Windows.Forms.Application;

namespace Loginside_FYAN_Bot_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var mutex = new Mutex(true, uniq_app_id, out var result);
            if (!result)
            {
                return;
            }
            EnableVisualStyles();
            SetCompatibleTextRenderingDefault(false);
            Run(new FrmMain());
            KeepAlive(mutex);
        }
    }
}
