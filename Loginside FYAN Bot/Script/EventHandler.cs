using Loginside_FYAN_Bot.Screen;
using System;
using System.Windows.Forms;
using static Loginside_FYAN_Bot.Script.Constant;

namespace Loginside_FYAN_Bot.Script;

internal static class EventHandler
{
    /// <summary>
    /// On timer main event.
    /// </summary>
    internal static void OnTmrMainEvent(object sender, EventArgs e)
    {
        mMgr ??= new Manager((Timer)sender);
        mMgr.Show();
    }
}
