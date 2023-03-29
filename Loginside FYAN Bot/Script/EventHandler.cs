using Loginside_FYAN_Bot.Screen;
using System;

namespace Loginside_FYAN_Bot.Script;

internal class EventHandler
{
    /// <summary>
    /// On timer main event.
    /// </summary>
    internal static void OnTmrMainEvent(object sender, EventArgs e) => new Manager().Show();
}
