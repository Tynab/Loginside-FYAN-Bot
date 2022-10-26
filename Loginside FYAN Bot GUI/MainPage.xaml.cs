using Loginside_FYAN_Bot_GUI.Script;
using Loginside_FYAN_Bot_GUI.Script.Service;
using static Loginside_FYAN_Bot_GUI.Script.Common;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static Microsoft.Maui.Controls.Application;
using static System.Threading.Tasks.Task;

namespace Loginside_FYAN_Bot_GUI
{
    public partial class MainPage : ContentPage
    {
        #region Fields
        private readonly IAppConfigService _appConfigService = new AppConfigService();
        #endregion

        #region Constructors
        public MainPage()
        {
            InitializeComponent();
            txtInHour.Text = GetHourConfig(TMR_IN);
            txtInMinute.Text = GetMinuteConfig(TMR_IN);
            txtOutHour.Text = GetHourConfig(TMR_OUT);
            txtOutMinute.Text = GetMinuteConfig(TMR_OUT);
            txtSecKey.Text = _appConfigService.Getter(SEC_KEY);
            txtId.Text = _appConfigService.Getter(ID_INS);
            txtPwd.Text = _appConfigService.Getter(PWD_INS);
        }
        #endregion

        #region Events
        // Button Set click
        private async void OnBtnSetClicked(object sender, EventArgs e)
        {
            try
            {
                // check in
                var inHour = HourParse(txtInHour.Text);
                var inMinute = MinuteParse(txtInMinute.Text);
                _appConfigService.Setter(TMR_IN, inHour.ToString("00") + ":" + inMinute.ToString("00"));
                // check out
                var outHour = HourParse(txtOutHour.Text);
                var outMinute = MinuteParse(txtOutMinute.Text);
                _appConfigService.Setter(TMR_OUT, outHour.ToString("00") + ":" + outMinute.ToString("00"));
                // account inside
                _appConfigService.Setter(ID_INS, txtId.Text);
                _appConfigService.Setter(PWD_INS, txtPwd.Text);
                _appConfigService.Setter(SEC_KEY, txtSecKey.Text);
                // apply to service
                var taskServ = Run(() => RestartService(BOT_NICK, 3000));
                await DisplayAlert("THÔNG BÁO", "Thiết lập thành công!", "Đóng");
                // re-default
                btnSet.IsEnabled = false;
                txtInHour.Text = inHour.ToString("00");
                txtInMinute.Text = inMinute.ToString("00");
                txtOutHour.Text = outHour.ToString("00");
                txtOutMinute.Text = outMinute.ToString("00");
                // closing
                await this.FadeTo(0, 1000);
                taskServ.Wait();
                Current.Quit();
            }
            catch (Exception ex)
            {
                _ = DisplayAlert("LỖI", ex.Message, "Đóng");
            }
        }
        #endregion

        #region Methods
        // Get hour from config
        private string GetHourConfig(string key)
        {
            var rsltFull = _appConfigService.Getter(key)[..2];
            var rsltRip = _appConfigService.Getter(key)[..1];
            return int.TryParse(rsltFull, out var _) ? rsltFull : int.TryParse(rsltRip, out var _) ? rsltRip : "00";
        }

        // Get minute from config
        private string GetMinuteConfig(string key)
        {
            var rsltFull = _appConfigService.Getter(key)[2..];
            var rsltRip = _appConfigService.Getter(key)[3..];
            return int.TryParse(rsltFull, out var _) ? rsltFull : int.TryParse(rsltRip, out var _) ? rsltRip : "00";
        }
        #endregion
    }
}