namespace Loginside_FYAN_Bot_Service.Script
{
    public interface IBotService
    {
        /// <summary>
        /// Bot log on user and log in inside.
        /// </summary>
        /// <param name="isChkIn">Is check in action.</param>
        public void BotLogOI(bool isChkIn);
    }
}
