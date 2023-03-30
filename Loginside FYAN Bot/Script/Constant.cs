using Loginside_FYAN_Bot.Screen;
using static Loginside_FYAN_Bot.Properties.Resources;
using static System.AppDomain;
using static System.Environment;
using static System.Environment.SpecialFolder;

namespace Loginside_FYAN_Bot.Script;

internal static class Constant
{
    // screen
    internal static Manager mMgr;

    // path
    internal static readonly string BACK_PATH = GetFolderPath(ApplicationData);
    internal static readonly string FRNT_PATH = $@"{BACK_PATH}\{co_name}";
    internal static readonly string FILE_SETUP_NAME = $"{bot_name} Setup.msi";
    internal static readonly string FILE_SETUP_ADR = $@"{FRNT_PATH}\{FILE_SETUP_NAME}";
    internal static readonly string APP_ADR = $@"{CurrentDomain.BaseDirectory}\{app_name}.exe";

    // setting
    internal const int TIME_OUT = 7000;
    internal const int TMR_INTVL_DFLT = 100;
    internal const int TMR_INTVL = 60000;
}
