using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using YANF.Script;
using YANF.Script.Service;
using static Loginside_FYAN_Bot.Properties.Resources;
using static Loginside_FYAN_Bot.Script.Common;
using static Loginside_FYAN_Bot.Script.Constant;
using static System.Diagnostics.Process;
using static System.Drawing.Color;
using static System.Math;
using static System.Windows.Forms.Application;
using static System.Windows.Forms.FormStartPosition;
using static System.Windows.Forms.Keys;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static YANF.Script.YANConstant;

namespace Loginside_FYAN_Bot.Screen;

internal class Manager : Form
{
    #region Fields
    private IYANDlvScrService _dlvScrService;
    private readonly Timer _tmrMain;
    private readonly Timer _tmrUp;
    private int _pct;
    #endregion

    #region Constructors
    internal Manager()
    {
        InitializeComponent();
        _tmrUp = new Timer
        {
            Interval = TMR_INTVL_DFLT,
            Enabled = true
        };
        _tmrUp.Tick += TmrUpd_Tick;
        Load += Manager_Load;
    }

    internal Manager(Timer tmrMain)
    {
        _tmrMain = tmrMain;
        InitializeComponent();
        _tmrUp = new Timer
        {
            Interval = TMR_INTVL_DFLT,
            Enabled = true
        };
        _tmrUp.Tick += TmrUpd_Tick;
        Load += Manager_Load;
    }
    #endregion

    #region Overridden
    // Hide sub windows
    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x80;
            return cp;
        }
    }

    // Disable close
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) => keyData == (Alt | F4) || base.ProcessCmdKey(ref msg, keyData);
    #endregion

    #region Events
    // Load
    private void Manager_Load(object sender, EventArgs e)
    {
        if (!IsUpd())
        {
            Close();
        }
    }

    // Timer update
    private void TmrUpd_Tick(object sender, EventArgs e)
    {
        if (_pct >= 100)
        {
            _tmrUp.StopAdv();
            StopServ(bot_name, TIME_OUT);
            KillPrcs(app_name);
            _dlvScrService.OffLoader();
            _ = Start(FILE_SETUP_ADR);
            Exit();
        }
    }

    // Update download progress changed
    private void Upd_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        _pct = e.ProgressPercentage;
        _ = Invoke((MethodInvoker)delegate
        {
            _dlvScrService.PublishValue(_pct, string.Format("{0} MB / {1} MB", (e.BytesReceived / 1024d / 1024d).ToString("0.00"), (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00")), (int)Ceiling(_pct * W_UPDATE_SCR / 100d));
        });
    }
    #endregion

    #region Methods
    // Is update
    private bool IsUpd()
    {
        if (IsNetAvail())
        {
            using var wc = new WebClient();
            if (!wc.DownloadString(link_ver).Contains(app_ver))
            {
                _tmrMain?.StopAdv();
                _ = MessageBox.Show($"{bot_name} đã có phiên bản mới!", "CẬP NHẬT", OK, Information);
                _dlvScrService = new YANUpdScrService();
                _dlvScrService.OnLoader(this);
                _pct = 0;
                _tmrUp.StartAdv();
                CrtDirAdv(FRNT_PATH);
                DelFileAdv(FILE_SETUP_ADR);
                wc.DownloadFileAsync(new Uri(wc.DownloadString(link_app)), FILE_SETUP_ADR);
                wc.DownloadProgressChanged += Upd_DownloadProgressChanged;
                return true;
            }
        }
        return false;
    }
    #endregion

    #region Design
    // Init
    private void InitializeComponent()
    {
        ComponentResourceManager resources = new(typeof(Manager));
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.None;
        BackColor = FromArgb(64, 0, 64);
        ClientSize = new Size(284, 261);
        ControlBox = false;
        Enabled = false;
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Manager";
        Opacity = 0D;
        ShowInTaskbar = false;
        StartPosition = Manual;
        TransparencyKey = FromArgb(64, 0, 64);
        Width = 0;
        Height = 0;
        ResumeLayout(false);
    }
    #endregion
}
