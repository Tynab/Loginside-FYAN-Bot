using Loginside_FYAN_Bot_GUI.Screen;
using System;
using System.Threading;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.GC;
using static System.IO.File;
using static System.Windows.Forms.Application;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static YANF.Script.YANConstant.MsgBoxLang;
using static YANF.Script.YANMessageBox;

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
            if (!Exists(CONFIG_ADR))
            {
                _ = Show("LỖI", "Quá trình cài đặt bot service không thành công!", OK, Error, VIE);
                Exit();
            }
            else
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
}
