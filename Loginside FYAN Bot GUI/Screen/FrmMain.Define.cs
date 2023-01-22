using System.Collections.Generic;
using YANF.Control;

namespace Loginside_FYAN_Bot_GUI.Screen;

public partial class FrmMain
{
    // Initialize items
    private void InitItems() => InitTxtPwd();

    #region Txt
    private List<YANTxt> _txtPwd;
    // Initialize list txtPwd
    private void InitTxtPwd() => _txtPwd = new List<YANTxt>()
        {
            txtPwd,
            txtPwdPrev
        };
    #endregion
}
