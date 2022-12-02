using Loginside_FYAN_Bot_GUI.Script;
using Loginside_FYAN_Bot_GUI.Script.Service;
using System;
using System.Windows.Forms;
using YANF.Control;
using YANF.Script;
using static AnimatorNS.AnimationType;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static Loginside_FYAN_Bot_GUI.Script.Common;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static Loginside_FYAN_Bot_GUI.Script.Constant.ServSts;
using static System.Drawing.Color;
using static System.IO.File;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static YANF.Script.YANConstant.MsgBoxLang;
using static YANF.Script.YANEvent;

namespace Loginside_FYAN_Bot_GUI.Screen
{
    public partial class FrmMain : Form
    {
        #region Fields
        private readonly IAppConfigService _appConfigService = new AppConfigService();
        #endregion

        #region Constructors
        public FrmMain()
        {
            InitializeComponent();
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
            // display
            nbInHour.Value = GetHourConfig(tmr_in);
            nbInMin.Value = GetMinConfig(tmr_in);
            nbOutHour.Value = GetHourConfig(tmr_out);
            nbOutMin.Value = GetMinConfig(tmr_out);
            txtId.String = _appConfigService.Getter(id_ins);
            txtPwd.String = _appConfigService.Getter(pwd_ins);
            txtSecKey.String = _appConfigService.Getter(sec_key);
            txtPwdPrev.String = _appConfigService.Getter(pwd_prev);
            var dayChgPwd = _appConfigService.Getter(day_chg_pwd);
            nbDayChgPwd.Value = string.IsNullOrWhiteSpace(dayChgPwd) ? 15 : int.TryParse(dayChgPwd, out var _) ? decimal.Parse(dayChgPwd) : 15;
            pnlMain.Select();
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
                YANMessageBox.Show("LỖI", "Quá trình cài đặt bot service không thành công!", OK, Error, VIE);
                Close();
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
            isScs = isScs && _appConfigService.Setter(tmr_in, nbInHour.Value.ToString("00") + ":" + nbInMin.Value.ToString("00"));
            // set timer out
            isScs = isScs && _appConfigService.Setter(tmr_out, nbOutHour.Value.ToString("00") + ":" + nbOutMin.Value.ToString("00"));
            // set id
            var sId = txtId.String;
            if (!string.IsNullOrWhiteSpace(sId))
            {
                isScs = isScs && _appConfigService.Setter(id_ins, sId);
            }
            // set secret key
            var sSecKey = txtSecKey.String;
            if (!string.IsNullOrWhiteSpace(sSecKey))
            {
                isScs = isScs && _appConfigService.Setter(sec_key, sSecKey);
            }
            // set day changed
            isScs = isScs && _appConfigService.Setter(day_chg_pwd, nbDayChgPwd.Value.ToString());
            // set password
            var sPwd = txtPwd.String;
            if (IsVldPwd(sPwd))
            {
                if (!string.IsNullOrWhiteSpace(sPwd))
                {
                    isScs = isScs && _appConfigService.Setter(pwd_ins, sPwd);
                }
            }
            else
            {
                YANMessageBox.Show("LỖI", "Mật khẩu phải từ 8 ký tự trở lên. Gồm chữ in, chữ thường, số và ký tự đặc biệt (@, #, $, %).", OK, Error, VIE);
                txtPwd.ResetText();
                txtPwd.Select();
                return;
            }
            // set password preventive
            var sPwdPrev = txtPwdPrev.String;
            if (IsVldPwd(sPwdPrev))
            {
                if (!string.IsNullOrWhiteSpace(sPwdPrev))
                {
                    isScs = isScs && _appConfigService.Setter(pwd_prev, sPwdPrev);
                }
            }
            else
            {
                YANMessageBox.Show("LỖI", "Mật khẩu dự phòng phải từ 8 ký tự trở lên. Gồm chữ in, chữ thường, số và ký tự đặc biệt (@, #, $, %).", OK, Error, VIE);
                txtPwdPrev.ResetText();
                txtPwdPrev.Select();
                return;
            }
            // apply
            isScs = isScs && RstServ(bot_name, TIME_OUT);
            if (isScs)
            {
                YANMessageBox.Show("THÔNG BÁO", "Thành công!", OK, Information, VIE);
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
                YANMessageBox.Show("THÔNG BÁO", "Thành công!", OK, Information, VIE);
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
                btnAct.BackColor = FromArgb(56, 73, 89);
            }
            else
            {
                btnAct.Text = "Chạy Bot";
                btnAct.BackColor = FromArgb(133, 193, 93);
            }
        }

        // Get hour from config
        private decimal GetHourConfig(string key)
        {
            var val = _appConfigService.Getter(key);
            if (!string.IsNullOrWhiteSpace(val))
            {
                var rslt = val.Split(':')[0];
                return int.TryParse(rslt, out var _) ? decimal.Parse(rslt) : 0;
            }
            else
            {
                return 0;
            }
        }

        // Get minute from config
        private decimal GetMinConfig(string key)
        {
            var val = _appConfigService.Getter(key);
            if (!string.IsNullOrWhiteSpace(val))
            {
                var rslt = val.Split(':')[1];
                return int.TryParse(rslt, out var _) ? decimal.Parse(rslt) : 0;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
