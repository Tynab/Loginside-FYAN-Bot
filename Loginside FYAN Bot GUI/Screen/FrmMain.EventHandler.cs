using System.Windows.Forms;
using YANF.Control;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.Windows.Forms.Keys;
using static YANF.Script.YANEvent;

namespace Loginside_FYAN_Bot_GUI.Screen;

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

    #region Txt
    // txt Password key down
    private void TxtPwd_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Escape)
        {
            ((YANTxt)sender).PasswordChar = false;
        }
    }

    // txt Password key up
    private void TxtPwd_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Escape)
        {
            ((YANTxt)sender).PasswordChar = true;
        }
    }
    #endregion
}
