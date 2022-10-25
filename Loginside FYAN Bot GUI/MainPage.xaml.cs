using Loginside_FYAN_Bot_GUI.Script;
using Loginside_FYAN_Bot_GUI.Script.Service;
using System.Configuration;
using static Loginside_FYAN_Bot_GUI.Script.Constant;
using static System.Configuration.ConfigurationManager;

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
            txtId.Text = _appConfigService.Getter(ID_INS);
            txtSecKey.Text = _appConfigService.Getter(SEC_KEY);
        }
        #endregion

        #region Events
        private void OnBtnSetClicked(object sender, EventArgs e)
        {
            try
            {
                //_appConfigService.Setter(ID_INS, txtId.Text);
                //_appConfigService.Setter(PWD_INS, txtPwd.Text);
                //_appConfigService.Setter(SEC_KEY, txtSecKey.Text);
                var _configuration = OpenExeConfiguration("D:\\aa.exe.config");
                //_configuration.AppSettings.Settings[ID_INS].Value = txtId.Text;
                //_configuration.Save();
                _configuration.AppSettings.Settings["x"].Value = txtId.Text;
                _configuration.Save();
                DisplayAlert("THÔNG BÁO", "Thiết lập thành công!", "Đóng");
            }
            catch (Exception ex)
            {
                DisplayAlert("LỖI", ex.Message, "Đóng");
            }
        }
        #endregion
    }
}