using System.Diagnostics;
using static Loginside_FYAN_Bot_GUI.Script.Common;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.AppDomain;
using static System.Diagnostics.Process;
using static System.IO.Directory;

namespace Loginside_FYAN_Bot_GUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // run as administrator
            if (IsAdmin())
            {
                MainPage = new AppShell();
            }
            else
            {
                var info = new ProcessStartInfo($@"{GetParent(CurrentDomain.BaseDirectory)}\{APP_NAME}.exe")
                {
                    UseShellExecute = true,
                    Verb = "runas"
                };
                Start(info);
                Current.Quit();
            }
        }
    }
}