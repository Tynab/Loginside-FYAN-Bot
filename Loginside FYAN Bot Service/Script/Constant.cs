using static System.AppDomain;
using static System.DateTime;

namespace Loginside_FYAN_Bot_Service.Script
{
    internal static class Constant
    {
        // path
        internal static readonly string LOG_PATH = $@"{CurrentDomain.BaseDirectory}\log";

        // other
        internal const int LMT_ATK = 3;
        internal const int DELAY = 300;
        internal const int TIME_OUT = 3000;
        internal const int TMR_INTVL = 60000;
    }
}
