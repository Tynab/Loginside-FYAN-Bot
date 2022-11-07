using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
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
            new Thread(() => ShdwBotGC(isChkIn)).Start();
            new Thread(() => ShdwBotFF(isChkIn)).Start();
            new Thread(() => ShdwBotME(isChkIn)).Start();
            new Thread(() => ShdwBotIE(isChkIn)).Start();
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
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    using IWebDriver driver = new ChromeDriver();
                    ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                }
                catch (Exception gcex)
                {
                    WriteLog($"{shdwName} error", gcex.Message);
                    try
                    {
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        using IWebDriver driver = new FirefoxDriver();
                        ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                    }
                    catch (Exception ffex)
                    {
                        WriteLog($"{shdwName} error", ffex.Message);
                        try
                        {
                            new DriverManager().SetUpDriver(new EdgeConfig());
                            using IWebDriver driver = new EdgeDriver();
                            ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                        }
                        catch (Exception meex)
                        {
                            WriteLog($"{shdwName} error", meex.Message);
                            try
                            {
                                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                                using IWebDriver driver = new InternetExplorerDriver();
                                ShdwChgPwd(shdwName, driver, id, pwd, pwdPrev, secKey);
                            }
                            catch (Exception ieex)
                            {
                                WriteLog($"{shdwName} error", ieex.Message);
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

        // Shadow bot Chrome
        private void ShdwBotGC(bool isChkIn)
        {
            var shdwName = "GC Bot";
            IAppConfigService appConfigService = new AppConfigService();
            var id = appConfigService.Getter(id_ins);
            var pwd = appConfigService.Getter(pwd_ins);
            var secKey = appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(secKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    using IWebDriver driver = new ChromeDriver();
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

        // Shadow bot FireFox
        private void ShdwBotFF(bool isChkIn)
        {
            var shdwName = "FF Bot";
            IAppConfigService appConfigService = new AppConfigService();
            var id = appConfigService.Getter(id_ins);
            var pwd = appConfigService.Getter(pwd_ins);
            var secKey = appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(secKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    using IWebDriver driver = new FirefoxDriver();
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

        // Shadow bot Edge
        private void ShdwBotME(bool isChkIn)
        {
            var shdwName = "ME Bot";
            IAppConfigService appConfigService = new AppConfigService();
            var id = appConfigService.Getter(id_ins);
            var pwd = appConfigService.Getter(pwd_ins);
            var secKey = appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(secKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    using IWebDriver driver = new EdgeDriver();
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

        // Shadow bot Internet Explorer
        private void ShdwBotIE(bool isChkIn)
        {
            var shdwName = "IE Bot";
            IAppConfigService appConfigService = new AppConfigService();
            var id = appConfigService.Getter(id_ins);
            var pwd = appConfigService.Getter(pwd_ins);
            var secKey = appConfigService.Getter(sec_key);
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(pwd) && !string.IsNullOrWhiteSpace(secKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    using IWebDriver driver = new InternetExplorerDriver();
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
