using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Logger;
using static OpenQA.Selenium.By;
using static System.Threading.Thread;

namespace Loginside_FYAN_Bot_Service.Script.Service
{
    public class BotService : IBotService
    {
        #region Fields
        public readonly IWebDriver _driver = new ChromeDriver();
        private readonly IAppConfigService _appConfigService;
        #endregion

        #region Constructors
        public BotService(IAppConfigService appConfigService) => _appConfigService = appConfigService;
        #endregion

        #region Methods
        public void BotLogOI(bool isChkIn) => new Thread(() =>
        {
            var id = _appConfigService.Getter(id_ins);
            var pwd = _appConfigService.Getter(pwd_ins);
            var secKey = _appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(secKey))
            {
                try
                {
                    _driver.Navigate().GoToUrl(link_ins);
                    Sleep(3000);
                    var elemId = _driver.FindElement(Id(id_inp_id));
                    elemId.SendKeys(id);
                    Sleep(300);
                    var elemPwd = _driver.FindElement(Id(id_inp_pwd));
                    elemPwd.SendKeys(pwd);
                    Sleep(300);
                    var elemOtp = _driver.FindElement(Id(id_inp_otp));
                    elemOtp.SendKeys(GetOTP(secKey));
                    Sleep(300);
                    var elemBtnLogIn = _driver.FindElement(Id(id_btn_login));
                    elemBtnLogIn.Click();
                    Sleep(3000);
                    var elemBtnChk = isChkIn ? _driver.FindElement(Id(id_btn_chkin)) : _driver.FindElement(Id(id_btn_chkout));
                    elemBtnChk.Click();
                    Sleep(300);
                    WriteLog("Bot", "Checked!");
                }
                catch (Exception ex)
                {
                    WriteLog("Bot error", ex.Message);
                }
            }
            else
            {
                WriteLog("Bot", "Missing value!");
            }
        }).Start();

        public void Dispose() => _driver.Dispose();
        #endregion
    }
}
