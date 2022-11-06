using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using System;
using System.Threading;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static Loginside_FYAN_Bot_Service.Script.Logger;
using static OpenQA.Selenium.By;
using static System.Threading.Thread;

namespace Loginside_FYAN_Bot_Service.Script.Service
{
    public class BotService : IBotService
    {
        public void BotStem(bool isChkIn)
        {
            new Thread(() => ShdwBot("GC Bot", new AppConfigService(), new ChromeDriver(), isChkIn)).Start();
            new Thread(() => ShdwBot("FF Bot", new AppConfigService(), new FirefoxDriver(), isChkIn)).Start();
            new Thread(() => ShdwBot("ME Bot", new AppConfigService(), new EdgeDriver(), isChkIn)).Start();
            new Thread(() => ShdwBot("IE Bot", new AppConfigService(), new InternetExplorerDriver(), isChkIn)).Start();
            new Thread(() => ShdwBot("IS Bot", new AppConfigService(), new SafariDriver(), isChkIn)).Start();
        }

        public void BotPwd()
        {
            var shdwName = "Bot Pwd";
            IAppConfigService appConfigService = new AppConfigService();
            var id = appConfigService.Getter(id_ins);
            var pwd = appConfigService.Getter(pwd_ins);
            var pwdPrev = appConfigService.Getter(pwd_prev);
            var secKey = appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(pwdPrev) && !string.IsNullOrWhiteSpace(secKey))
            {
                try
                {
                    using IWebDriver driver = new ChromeDriver();
                    ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                }
                catch (Exception gcex)
                {
                    WriteLog($"{shdwName} error", gcex.Message);
                    try
                    {
                        using IWebDriver driver = new FirefoxDriver();
                        ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                    }
                    catch (Exception ffex)
                    {
                        WriteLog($"{shdwName} error", ffex.Message);
                        try
                        {
                            using IWebDriver driver = new EdgeDriver();
                            ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                        }
                        catch (Exception meex)
                        {
                            WriteLog($"{shdwName} error", meex.Message);
                            try
                            {
                                using IWebDriver driver = new InternetExplorerDriver();
                                ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                            }
                            catch (Exception ieex)
                            {
                                WriteLog($"{shdwName} error", ieex.Message);
                                try
                                {
                                    using IWebDriver driver = new SafariDriver();
                                    ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                                }
                                catch (Exception isex)
                                {
                                    WriteLog($"{shdwName} error", isex.Message);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                WriteLog(shdwName, "Missing value!");
            }
        }

        // Shadow bot
        private void ShdwBot(string shdwName, IAppConfigService appConfigService, WebDriver webDrv, bool isChkIn)
        {
            var id = appConfigService.Getter(id_ins);
            var pwd = appConfigService.Getter(pwd_ins);
            var secKey = appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(secKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    using IWebDriver driver = webDrv;
                    ShdwChkIO(shdwName, driver, isChkIn, id, pwd, secKey);
                }
                catch (Exception ex)
                {
                    counter++;
                    WriteLog($"{shdwName} error", ex.Message);
                    // limit attack
                    if (counter is > 0 and < LMT_ATK)
                    {
                        goto Attack;
                    }
                }
            }
            else
            {
                WriteLog(shdwName, "Missing value!");
            }
        }

        // Shadow login
        private void ShdwLogin(string shdwName, IWebDriver driver, string id, string pwd, string secKey)
        {
            // access link
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(link_ins);
            Sleep(TIME_OUT);
            // enter Id
            var elemId = driver.FindElement(Id(id_inp_id));
            elemId.SendKeys(id);
            Sleep(DELAY);
            // enter password
            var elemPwd = driver.FindElement(Id(id_inp_pwd));
            elemPwd.SendKeys(pwd);
            Sleep(DELAY);
            // enter OTP
            var elemOtp = driver.FindElement(Id(id_inp_otp));
            elemOtp.SendKeys(GetOTP(secKey));
            Sleep(DELAY);
            // login
            var elemBtnLogIn = driver.FindElement(Id(id_btn_login));
            elemBtnLogIn.Click();
            WriteLog(shdwName, "Logged!");
            Sleep(TIME_OUT);
        }

        // Shadow check in/out
        private void ShdwChkIO(string shdwName, IWebDriver driver, bool isChkIn, string id, string pwd, string secKey)
        {
            ShdwLogin(shdwName, driver, id, pwd, secKey);
            // check click
            var elemBtnChk = isChkIn ? driver.FindElement(Id(id_btn_chkin)) : driver.FindElement(Id(id_btn_chkout));
            elemBtnChk.Click();
            WriteLog(shdwName, isChkIn ? "Checked in!" : "Checked out!");
            Sleep(DELAY);
        }

        // Shadow change password
        private void ShdwChgPwd(string shdwName, IWebDriver driver, string id, string pwd, string pwdPrev, string secKey)
        {
            ShdwLogin(shdwName, driver, id, pwd, secKey);
            // forward
            driver.Navigate().GoToUrl(link_ins_chg_pwd);
            // enter old password
            var elemOldPwd = driver.FindElement(Id(id_old_pwd));
            elemOldPwd.SendKeys(pwd);
            Sleep(DELAY);
            // enter new password
            var elemNewPwd = driver.FindElement(Id(id_new_pwd));
            elemNewPwd.SendKeys(pwdPrev);
            Sleep(DELAY);
            // enter confirm password
            var elemCfmPwd = driver.FindElement(Id(id_cfm_pwd));
            elemCfmPwd.SendKeys(pwdPrev);
            Sleep(DELAY);
            // change password
            var elemBtnChgPwd = driver.FindElement(Id(id_btn_chg_pwd));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password changed!");
            Sleep(TIME_OUT);
            // enter old password
            elemOldPwd = driver.FindElement(Id(id_old_pwd));
            elemOldPwd.SendKeys(pwdPrev);
            Sleep(DELAY);
            // enter new password
            elemNewPwd = driver.FindElement(Id(id_new_pwd));
            elemNewPwd.SendKeys(pwd);
            Sleep(DELAY);
            // enter confirm password
            elemCfmPwd = driver.FindElement(Id(id_cfm_pwd));
            elemCfmPwd.SendKeys(pwd);
            Sleep(DELAY);
            // change password
            elemBtnChgPwd = driver.FindElement(Id(id_btn_chg_pwd));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password re-changed!");
            Sleep(TIME_OUT);
        }
    }
}
