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
            // option
            GetServSyncDisp();
            nbInHour.Value = GetHourConfig(tmr_in);
            nbInMin.Value = GetMinConfig(tmr_in);
            nbOutHour.Value = GetHourConfig(tmr_out);
            nbOutMin.Value = GetMinConfig(tmr_out);
            pnlMain.Select();
        }
        #endregion

        #region Events
        // frm shown
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            pnlMain.ShowAnimat(ScaleAndRotate, ANIMAT_SPD);
            pnlIn.ShowAnimatAsync(VertSlide, ANIMAT_SPD);
            pnlOut.ShowAnimatAsync(VertSlide, ANIMAT_SPD);
            btnCl.ShowAnimatAsync(Rotate, ANIMAT_SPD);
            pnlIns.ShowAnimatAsync(ScaleAndHorizSlide, ANIMAT_SPD);
            SND_PRS.Play();
        }

        // frm closing
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) => pnlMain.HideAnimat(Leaf, ANIMAT_SPD);

        // btn Apply click
        private void BtnAdm_Click(object sender, EventArgs e)
        {
            SND_NEXT.Play();

        }

        // btn Active click
        private void BtnAct_Click(object sender, EventArgs e)
        {
            SND_NEXT.Play();
            switch (GetServSts(serv_name))
            {
                case Started:
                {
                    StopServ(serv_name, TIME_OUT);
                    break;
                }
                case Stoped:
                {
                    StrtServ(serv_name, TIME_OUT);
                    break;
                }
            }
            GetServSyncDisp();
        }

        // btn Close click
        private void BtnCl_Click(object sender, EventArgs e)
        {
            Close();
            SND_NEXT.PlaySync();
        }

        // Mod MoveFrm event
        private void MoveFrmMod_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrm_MouseDown(sender, e);
            SND_CHG.Play();
        }
        #endregion

        #region Methods
        // Get service sync display
        private void GetServSyncDisp()
        {
            var sts = GetServSts(serv_name);
            if (sts == NotFd)
            {
                if (btnAdm.Visible)
                {
                    btnAdm.HideAnimatAsync(Particles, ANIMAT_SPD);
                }
                if (btnAct.Visible)
                {
                    btnAct.HideAnimatAsync(Particles, ANIMAT_SPD);
                }
            }
            else
            {
                if (!btnAdm.Visible)
                {
                    btnAdm.ShowAnimatAsync(VertBlind, ANIMAT_SPD);
                }
                if (!btnAct.Visible)
                {
                    btnAct.ShowAnimatAsync(VertBlind, ANIMAT_SPD);
                }
                if (sts == Started)
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
        }

        // Get hour from config
        private decimal GetHourConfig(string key)
        {
            var val = _appConfigService.Getter(key);
            if (!string.IsNullOrWhiteSpace(val))
            {
                var rsltFull = val.Substring(0, 2);
                var rsltRip = val.Substring(0, 1);
                return int.TryParse(rsltFull, out var _) ? decimal.Parse(rsltFull) : int.TryParse(rsltRip, out var _) ? decimal.Parse(rsltRip) : 0;
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
                var rsltFull = val.Substring(2);
                var rsltRip = val.Substring(3);
                return int.TryParse(rsltFull, out var _) ? decimal.Parse(rsltFull) : int.TryParse(rsltRip, out var _) ? decimal.Parse(rsltRip) : 0;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
