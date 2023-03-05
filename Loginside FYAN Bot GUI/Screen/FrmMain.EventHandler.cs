using System;
using System.Windows.Forms;
using YANF.Control;
using static Loginside_FYAN_Bot_GUI.Script.Common;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.Drawing.Color;
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
        SND_CHG?.Play();
    }
    #endregion

    #region Txt
    // txt Password key down
    private void TxtPwd_KeyDown(object sender, KeyEventArgs e)
    {
        if (e?.KeyCode == Escape)
        {
            ((YANTxt)sender).PasswordChar = false;
        }
    }

    // txt Password key up
    private void TxtPwd_KeyUp(object sender, KeyEventArgs e)
    {
        if (e?.KeyCode == Escape)
        {
            ((YANTxt)sender).PasswordChar = true;
        }
    }

    // txt Password string changed
    private void TxtPwd_StringChanged(object sender, EventArgs e)
    {
        var txtPwd = (YANTxt)((TextBox)sender).Parent;
        txtPwd.BorderFocusColor = IsVldPwd(txtPwd.String) ? ForestGreen : OrangeRed;
        Refresh();
    }
    #endregion
}
