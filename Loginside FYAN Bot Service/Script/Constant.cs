using System;
using static System.AppDomain;
using static System.TimeSpan;

namespace Loginside_FYAN_Bot_Service.Script
{
    internal static class Constant
    {
        // path
        internal static readonly string BASE_PATH = CurrentDomain.BaseDirectory;
        internal static readonly string LOG_PATH = $@"{BASE_PATH}\log";

        // other
        internal static readonly TimeSpan WAIT_SPAN = FromSeconds(TIME_WAIT);
        internal const int LMT_ATK = 3;
        internal const int TIME_WAIT = 10;
        internal const int TMR_INTVL = 60000;
    }
}
