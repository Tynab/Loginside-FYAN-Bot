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
                    // load page
                    using IWebDriver driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(link_ins);
                    Sleep(7000);
                    // enter Id
                    var elemId = driver.FindElement(Id(id_inp_id));
                    elemId.SendKeys(id);
                    Sleep(300);
                    // enter password
                    var elemPwd = driver.FindElement(Id(id_inp_pwd));
                    elemPwd.SendKeys(pwd);
                    Sleep(300);
                    // enter OTP
                    var elemOtp = driver.FindElement(Id(id_inp_otp));
                    elemOtp.SendKeys(GetOTP(secKey));
                    Sleep(300);
                    // login
                    var elemBtnLogIn = driver.FindElement(Id(id_btn_login));
                    elemBtnLogIn.Click();
                    Sleep(7000);
                    WriteLog("Bot", "Logged!");
                    // check click
                    var elemBtnChk = isChkIn ? driver.FindElement(Id(id_btn_chkin)) : driver.FindElement(Id(id_btn_chkout));
                    elemBtnChk.Click();
                    Sleep(300);
                    WriteLog("Bot", isChkIn ? "Checked in!" : "Checked out!");
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
        #endregion
    }
}
