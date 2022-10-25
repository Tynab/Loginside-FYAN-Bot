namespace Loginside_FYAN_Bot_GUI.Script
{
    public interface IAppConfigService
    {
        /// <summary>
        /// Get value from app config.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>String value.</returns>
        public string Getter(string key);

        /// <summary>
        /// Set value to app config.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">String value.</param>
        public void Setter(string key, string value);
    }
}
