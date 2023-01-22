namespace Loginside_FYAN_Bot_Service.Script.Model;

internal abstract class ShdwBot : FyanBot
{
    #region Declares
    /// <summary>
    /// Shadow bot check in/out.
    /// </summary>
    protected internal abstract void ShdwBotChk();

    /// <summary>
    /// Shadow bot change password.
    /// </summary>
    /// <returns>Is success.</returns>
    protected internal abstract bool ShdwBotPwd();
    #endregion
}
