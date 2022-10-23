using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static Loginside_FYAN_Bot.Properties.Resources;
using static Loginside_FYAN_Bot.Script.Common;
using static Loginside_FYAN_Bot.Script.Logger;
using static System.DateTime;

namespace Loginside_FYAN_Bot.Script.Service
{
    public class BotService : IService
    {
        #region Fields
        public readonly IWebDriver _driver = new ChromeDriver();
        #endregion

        #region Methods
        public void BotLogOI(bool isChkIn)
        {
            //var state = LogonUser() ? "succeeded" : "failed";
            //WriteLog("Service logon user " + state + " in at: " + Now.ToString("HH:mm:ss"));
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(link_ins);
            WriteLog("Service open chrome at: " + Now.ToString("HH:mm:ss"));
            //var elemId = driver.FindElement(By.Id(id_inp_id));
            //elemId.SendKeys(Default.Id_Ins);
            //var elemPwd = driver.FindElement(By.Id(id_inp_pwd));
            //elemPwd.SendKeys(Default.Pwd_Ins);
            //var elemOtp = driver.FindElement(By.Id(id_inpt_otp));
            //elemOtp.SendKeys(CodeOTP());
            //var elemBtnLogIn = driver.FindElement(By.Id(id_btn_login));
            //elemBtnLogIn.Click();
            //var elemBtnChk = isChkIn ? driver.FindElement(By.Id(id_btn_chkin)) : driver.FindElement(By.Id(id_btn_chkout));
            //elemBtnChk.Click();
        }

        public void Dispose() => _driver.Dispose();
        #endregion
    }
}
