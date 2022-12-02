using System.Windows.Forms;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static YANF.Script.YANEvent;

namespace Loginside_FYAN_Bot_GUI.Screen
{
    public partial class FrmMain
    {
        #region Ctrl
        // Mod MoveFrm event
        private void MoveFrmMod_MouseDown(object sender, MouseEventArgs e)
        {
            // base
            MoveFrm_MouseDown(sender, e);
            // sound
            SND_CHG.Play();
        }
        #endregion
    }
}
