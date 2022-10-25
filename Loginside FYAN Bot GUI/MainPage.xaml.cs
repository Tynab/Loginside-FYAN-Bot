using Loginside_FYAN_Bot_GUI.Script;
using Loginside_FYAN_Bot_GUI.Script.Service;
using static Loginside_FYAN_Bot_GUI.Script.Constant;

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
            txtInHour.Text = _appConfigService.Getter(TMR_IN)[..2];
            txtInMinute.Text = _appConfigService.Getter(TMR_IN).Substring(3, 2);
            txtOutHour.Text = _appConfigService.Getter(TMR_OUT)[..2];
            txtOutMinute.Text = _appConfigService.Getter(TMR_OUT).Substring(3, 2);
            txtSecKey.Text = _appConfigService.Getter(SEC_KEY);
            txtId.Text = _appConfigService.Getter(ID_INS);
            txtPwd.Text = _appConfigService.Getter(PWD_INS);
        }
        #endregion

        #region Events
        // Button Set click
        private void OnBtnSetClicked(object sender, EventArgs e)
        {
            try
            {
                // check in
                var inHour = HourParse(txtInHour.Text);
                var inMinute = MinuteParse(txtInMinute.Text);
                _appConfigService.Setter(TMR_IN, $"{inHour}:{inMinute}");
                // check out
                var outHour = HourParse(txtOutHour.Text);
                var outMinute = MinuteParse(txtOutMinute.Text);
                _appConfigService.Setter(TMR_OUT, $"{outHour}:{outMinute}");
                // account inside
                _appConfigService.Setter(ID_INS, txtId.Text);
                _appConfigService.Setter(PWD_INS, txtPwd.Text);
                _appConfigService.Setter(SEC_KEY, txtSecKey.Text);
                DisplayAlert("THÔNG BÁO", "Thiết lập thành công!", "Đóng");
                // default
                txtInHour.Text = inHour.ToString();
                txtInMinute.Text = inMinute.ToString();
                txtOutHour.Text = outHour.ToString();
                txtOutMinute.Text = outMinute.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("LỖI", ex.Message, "Đóng");
            }
        }
        #endregion

        #region Methods
        // Parse to hour
        private static int HourParse(string s)
        {
            _ = int.TryParse(s, out var rslt);
            return rslt = rslt is > 0 and < 24 ? rslt : 0;
        }

        // Parse to minute
        private static int MinuteParse(string s)
        {
            _ = int.TryParse(s, out var rslt);
            return rslt = rslt is > 0 and < 60 ? rslt : 0;
        }
        #endregion
    }
}