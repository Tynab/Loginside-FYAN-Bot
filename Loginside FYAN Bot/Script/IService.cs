using System;

namespace Loginside_FYAN_Bot.Script
{
    public interface IService : IDisposable
    {
        #region Bot Service
        /// <summary>
        /// Bot log on user and log in inside.
        /// </summary>
        /// <param name="isChkIn">Is check in action.</param>
        public void BotLogOI(bool isChkIn);
        #endregion
    }
}
