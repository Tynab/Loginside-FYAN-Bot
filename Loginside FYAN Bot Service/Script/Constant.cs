using System;
using static System.AppDomain;
using static System.TimeSpan;

namespace Loginside_FYAN_Bot_Service.Script;

internal static class Constant
{
    // path
    internal const string BOT_NAME = "Fyan Bot";
    internal const string BRV_ADR = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
    internal static readonly string BASE_PATH = CurrentDomain.BaseDirectory;
    internal static readonly string LOG_PATH = $@"{BASE_PATH}\log";
    internal static readonly string CR_DRV_ADR = $@"{BASE_PATH}\chromedriver.exe";

    // other
    internal const int SHDW_BOT_CNT = 5;
    internal const int LMT_ATK = 3;
    internal const int DFLT_DAY = 15;
    internal const int DELAY = 300;
    internal const int TIME_OUT = 3000;
    internal const int TIME_WAIT = 10;
    internal const int TMR_INTVL = 60000;
    internal const int TMR_INTVL_DFLT = 100;
    internal const string ENV_VAR_WEB_DRV_CR = "webdriver.chrome.driver";
    internal static readonly TimeSpan WAIT_SPAN = FromSeconds(TIME_WAIT);
}
