namespace Loginside_FYAN_Bot_GUI.Script
{
    public interface IAppConfigService
    {
        /// <summary>
        /// Get value from app config.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>Value as string.</returns>
        public string Getter(string key);

        /// <summary>
        /// Set value to app config.
        /// </summary>
        /// <typeparam name="T">Datatype.</typeparam>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        /// <returns>Is success.</returns>
        public bool Setter<T>(string key, T value);
    }
}
