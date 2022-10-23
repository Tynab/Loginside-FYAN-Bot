namespace Loginside_FYAN_Bot.Script
{
    internal class Constant
    {
        #region Logon
        internal const int LOGON32_LOGON_INTERACTIVE = 2;
        internal const int LOGON32_LOGON_NETWORK = 3;
        internal const int LOGON32_LOGON_BATCH = 4;
        internal const int LOGON32_LOGON_SERVICE = 5;
        internal const int LOGON32_LOGON_UNLOCK = 7;
        internal const int LOGON32_LOGON_NETWORK_CLEARTEXT = 8;
        internal const int LOGON32_LOGON_NEW_CREDENTIALS = 9;

        internal const int LOGON32_PROVIDER_DEFAULT = 0;
        internal const int LOGON32_PROVIDER_WINNT35 = 1;
        internal const int LOGON32_PROVIDER_WINNT40 = 2;
        internal const int LOGON32_PROVIDER_WINNT50 = 3;
        internal const int LOGON32_PROVIDER_VIRTUAL = 4;
        #endregion
    }
}
