using Loginside_FYAN_Bot_GUI.Script;
using System;
using System.Windows.Forms;
using YANF.Control;
using YANF.Script;
using static AnimatorNS.AnimationType;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static Loginside_FYAN_Bot_GUI.Script.Common;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static Loginside_FYAN_Bot_GUI.Script.Constant.ServSts;
using static System.IO.File;
using static YANF.Script.YANEvent;

namespace Loginside_FYAN_Bot_GUI.Screen;

public partial class FrmMain : Form
{
    #region Fields
    private readonly AppConfig _appConfig = new();
    #endregion

    #region Constructors
    public FrmMain()
    {
        InitializeComponent();
        InitItems();
        OptEvt();
        OptDisp();
    }
    #endregion

    #region Events
    // frm shown
    private void FrmMain_Shown(object sender, EventArgs e)
    {
        // display effect
        pnlMain.ShowAnimat(ScaleAndRotate, ANIMAT_SPD);
        pnlIn.ShowAnimatAsync(VertSlide, ANIMAT_SPD);
        pnlOut.ShowAnimatAsync(VertSlide, ANIMAT_SPD);
        btnCl.ShowAnimatAsync(Rotate, ANIMAT_SPD);
        pnlIns.ShowAnimatAsync(ScaleAndHorizSlide, ANIMAT_SPD);
        GetServSyncDisp();
        //sound
        SND_PRS.Play();
        // is missing data
        if (!Exists(CONFIG_ADR))
        {
#if !DEBUG
            _ = MsgEServNotFd();
            Close();
#endif
        }
    }

    // frm closing
    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) => pnlMain.HideAnimat(Leaf, ANIMAT_SPD);

    // btn Apply click
    private void BtnAdm_Click(object sender, EventArgs e)
    {
        // sound
        SND_NEXT.Play();
        // main
        var isScs = true;
        // set timer in
        isScs = isScs && _appConfig.Setter(tmr_in, nbInHour.Value.ToString("00") + ":" + nbInMin.Value.ToString("00"));
        // set timer out
        isScs = isScs && _appConfig.Setter(tmr_out, nbOutHour.Value.ToString("00") + ":" + nbOutMin.Value.ToString("00"));
        // set id
        var sId = txtId.String;
        if (sId.HasVal())
        {
            isScs = isScs && _appConfig.Setter(id_ins, sId);
        }
        // set secret key
        var sSecKey = txtSecKey.String;
        if (sSecKey.HasVal())
        {
            isScs = isScs && _appConfig.Setter(sec_key, sSecKey);
        }
        // set day changed
        isScs = isScs && _appConfig.Setter(day_chg_pwd, nbDayChgPwd.Value.ToString());
        // set password
        var sPwd = txtPwd.String;
        if (IsVldPwd(sPwd))
        {
            isScs = isScs && _appConfig.Setter(pwd_ins, sPwd);
        }
        else
        {
            _ = MsgEPwdFail();
            txtPwd.ResetText();
            txtPwd.Select();
            return;
        }
        // set password preventive
        var sPwdPrev = txtPwdPrev.String;
        if (IsVldPwd(sPwdPrev))
        {
            isScs = isScs && _appConfig.Setter(pwd_prev, sPwdPrev);
        }
        else
        {
            _ = MsgEPwdFail();
            txtPwdPrev.ResetText();
            txtPwdPrev.Select();
            return;
        }
        // apply
        isScs = isScs && RstServ(bot_name, TIME_OUT);
        if (isScs)
        {
            _ = MsgIDone();
        }
        GetServStsSyncBtn();
    }

    // btn Active click
    private void BtnAct_Click(object sender, EventArgs e)
    {
        // sound
        SND_NEXT.Play();
        // check status for action
        var isScs = true;
        switch (GetServSts(bot_name))
        {
            case Started:
            {
                isScs = StopServ(bot_name, TIME_OUT);
                break;
            }
            case Stoped:
            {
                isScs = StrtServ(bot_name, TIME_OUT);
                break;
            }
        }
        // re-sync
        if (isScs)
        {
            _ = MsgIDone();
        }
        GetServStsSyncBtn();
    }

    // btn Close click
    private void BtnCl_Click(object sender, EventArgs e)
    {
        // action
        Close();
        // sound
        SND_NEXT.PlaySync();
    }
    #endregion

    #region Methods
    // Option event
    private void OptEvt()
    {
        // move frm by pnl
        foreach (var pnl in this.GetAllObjs(typeof(Panel)))
        {
            pnl.MouseDown += MoveFrmMod_MouseDown;
            pnl.MouseMove += MoveFrm_MouseMove;
            pnl.MouseUp += MoveFrm_MouseUp;
        }
        // move frm by pnl
        foreach (var gradPnl in this.GetAllObjs(typeof(YANGradPnl)))
        {
            gradPnl.MouseDown += MoveFrmMod_MouseDown;
            gradPnl.MouseMove += MoveFrm_MouseMove;
            gradPnl.MouseUp += MoveFrm_MouseUp;
        }
        // move frm by lbl
        foreach (var lbl in this.GetAllObjs(typeof(Label)))
        {
            lbl.MouseDown += MoveFrmMod_MouseDown;
            lbl.MouseMove += MoveFrm_MouseMove;
            lbl.MouseUp += MoveFrm_MouseUp;
        }
        // txt password
        _txtPwd.ForEach(x =>
        {
            x.KeyDown += TxtPwd_KeyDown;
            x.KeyUp += TxtPwd_KeyUp;
        });
    }

    // Option display
    private void OptDisp()
    {
        nbInHour.Value = GetHourConfig(tmr_in);
        nbInMin.Value = GetMinConfig(tmr_in);
        nbOutHour.Value = GetHourConfig(tmr_out);
        nbOutMin.Value = GetMinConfig(tmr_out);
        txtId.String = _appConfig.Getter(id_ins);
        txtPwd.String = _appConfig.Getter(pwd_ins);
        txtSecKey.String = _appConfig.Getter(sec_key);
        txtPwdPrev.String = _appConfig.Getter(pwd_prev);
        var dayChgPwd = _appConfig.Getter(day_chg_pwd);
        nbDayChgPwd.Value = !dayChgPwd.HasVal() ? DFLT_DAY : dayChgPwd.IntPrs(DFLT_DAY);
        pnlMain.Select();
    }

    // Get service sync display
    private void GetServSyncDisp()
    {
        if (GetServSts(bot_name) != NotFd)
        {
            GetServStsSyncBtn();
            // show btn apply
            if (!btnAdm.Visible)
            {
                btnAdm.ShowAnimatAsync(VertBlind, ANIMAT_SPD);
            }
            // show btn active
            if (!btnAct.Visible)
            {
                btnAct.ShowAnimatAsync(VertBlind, ANIMAT_SPD);
            }
        }
    }

    // Get service status sync button active
    private void GetServStsSyncBtn()
    {
        if (GetServSts(bot_name) == Started)
        {
            btnAct.Text = "Dừng Bot";
            btnAct.BackColor = CLR_ACT_STOP;
        }
        else
        {
            btnAct.Text = "Chạy Bot";
            btnAct.BackColor = CLR_ACT_STRT;
        }
    }

    // Get hour from config
    private decimal GetHourConfig(string key)
    {
        var val = _appConfig.Getter(key);
        return val.HasVal() ? val.Split(':')[0].IntPrs(0) : 0;
    }

    // Get minute from config
    private decimal GetMinConfig(string key)
    {
        var val = _appConfig.Getter(key);
        return val.HasVal() ? val.Split(':')[1].IntPrs(0) : 0;
    }
    #endregion
}
