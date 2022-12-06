using Loginside_FYAN_Bot_Service.Script.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static Loginside_FYAN_Bot_Service.Script.Logger;
using static OpenQA.Selenium.By;
using static System.Environment;
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
            new Thread(() => ShdwBotCB(isChkIn)).Start();
        }

        public void BotPwd()
        {
            var shdwName = "Bot Pwd";
            IAppConfigService appConfigService = new AppConfigService();
            var acctIns = new AcctIns
            {
                Id = appConfigService.Getter(id_ins),
                Pwd = appConfigService.Getter(pwd_ins),
                PwdPrev = appConfigService.Getter(pwd_prev),
                SecKey = appConfigService.Getter(sec_key)
            };
            if (!string.IsNullOrWhiteSpace(acctIns.Id) && !string.IsNullOrWhiteSpace(acctIns.Pwd) && !string.IsNullOrWhiteSpace(acctIns.PwdPrev) && !string.IsNullOrWhiteSpace(acctIns.SecKey))
            {
                try
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    using IWebDriver driver = new ChromeDriver();
                    ShdwChgPwd(shdwName, driver, acctIns);
                }
                catch (Exception gcex)
                {
                    WriteLog($"{shdwName} error", gcex.Message);
                    try
                    {
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        using IWebDriver driver = new FirefoxDriver();
                        ShdwChgPwd(shdwName, driver, acctIns);
                    }
                    catch (Exception ffex)
                    {
                        WriteLog($"{shdwName} error", ffex.Message);
                        try
                        {
                            new DriverManager().SetUpDriver(new EdgeConfig());
                            using IWebDriver driver = new EdgeDriver();
                            ShdwChgPwd(shdwName, driver, acctIns);
                        }
                        catch (Exception meex)
                        {
                            WriteLog($"{shdwName} error", meex.Message);
                            try
                            {
                                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                                using IWebDriver driver = new InternetExplorerDriver();
                                ShdwChgPwd(shdwName, driver, acctIns);
                            }
                            catch (Exception ieex)
                            {
                                WriteLog($"{shdwName} error", ieex.Message);
                                try
                                {
                                    SetEnvironmentVariable("webdriver.chrome.driver", $@"{BASE_PATH}\chromedriver.exe");
                                    new DriverManager().SetUpDriver(new ChromeConfig());
                                    var options = new ChromeOptions
                                    {
                                        BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"
                                    };
                                    using IWebDriver driver = new ChromeDriver(BASE_PATH, options);
                                    ShdwChgPwd(shdwName, driver, acctIns);
                                }
                                catch (Exception cbex)
                                {
                                    WriteLog($"{shdwName} error", cbex.Message);
                                    try
                                    {
                                        new DriverManager().SetUpDriver(new ChromeConfig());
                                        using IWebDriver driver = new ChromeDriver();
                                        ShdwChgPwdNextGenSt(shdwName, driver, acctIns);
                                    }
                                    catch (Exception gcex1)
                                    {
                                        WriteLog($"{shdwName} next gen 1st error", gcex1.Message);
                                        try
                                        {
                                            new DriverManager().SetUpDriver(new FirefoxConfig());
                                            using IWebDriver driver = new FirefoxDriver();
                                            ShdwChgPwdNextGenSt(shdwName, driver, acctIns);
                                        }
                                        catch (Exception ffex1)
                                        {
                                            WriteLog($"{shdwName} next gen 1st error", ffex1.Message);
                                            try
                                            {
                                                new DriverManager().SetUpDriver(new EdgeConfig());
                                                using IWebDriver driver = new EdgeDriver();
                                                ShdwChgPwdNextGenSt(shdwName, driver, acctIns);
                                            }
                                            catch (Exception meex1)
                                            {
                                                WriteLog($"{shdwName} next gen 1st error", meex1.Message);
                                                try
                                                {
                                                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                                                    using IWebDriver driver = new InternetExplorerDriver();
                                                    ShdwChgPwdNextGenSt(shdwName, driver, acctIns);
                                                }
                                                catch (Exception ieex1)
                                                {
                                                    WriteLog($"{shdwName} next gen 1st error", ieex1.Message);
                                                    try
                                                    {
                                                        SetEnvironmentVariable("webdriver.chrome.driver", $@"{BASE_PATH}\chromedriver.exe");
                                                        new DriverManager().SetUpDriver(new ChromeConfig());
                                                        var options = new ChromeOptions
                                                        {
                                                            BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"
                                                        };
                                                        using IWebDriver driver = new ChromeDriver(BASE_PATH, options);
                                                        ShdwChgPwdNextGenSt(shdwName, driver, acctIns);
                                                    }
                                                    catch (Exception cbex1)
                                                    {
                                                        WriteLog($"{shdwName} next gen 1st error", cbex1.Message);
                                                        try
                                                        {
                                                            new DriverManager().SetUpDriver(new ChromeConfig());
                                                            using IWebDriver driver = new ChromeDriver();
                                                            ShdwChgPwdNextGenNd(shdwName, driver, acctIns);
                                                        }
                                                        catch (Exception gcex2)
                                                        {
                                                            WriteLog($"{shdwName} next gen 2nd error", gcex2.Message);
                                                            try
                                                            {
                                                                new DriverManager().SetUpDriver(new FirefoxConfig());
                                                                using IWebDriver driver = new FirefoxDriver();
                                                                ShdwChgPwdNextGenNd(shdwName, driver, acctIns);
                                                            }
                                                            catch (Exception ffex2)
                                                            {
                                                                WriteLog($"{shdwName} next gen 2nd error", ffex2.Message);
                                                                try
                                                                {
                                                                    new DriverManager().SetUpDriver(new EdgeConfig());
                                                                    using IWebDriver driver = new EdgeDriver();
                                                                    ShdwChgPwdNextGenNd(shdwName, driver, acctIns);
                                                                }
                                                                catch (Exception meex2)
                                                                {
                                                                    WriteLog($"{shdwName} next gen 2nd error", meex2.Message);
                                                                    try
                                                                    {
                                                                        new DriverManager().SetUpDriver(new InternetExplorerConfig());
                                                                        using IWebDriver driver = new InternetExplorerDriver();
                                                                        ShdwChgPwdNextGenNd(shdwName, driver, acctIns);
                                                                    }
                                                                    catch (Exception ieex2)
                                                                    {
                                                                        WriteLog($"{shdwName} next gen 2nd error", ieex2.Message);
                                                                        try
                                                                        {
                                                                            SetEnvironmentVariable("webdriver.chrome.driver", $@"{BASE_PATH}\chromedriver.exe");
                                                                            new DriverManager().SetUpDriver(new ChromeConfig());
                                                                            var options = new ChromeOptions
                                                                            {
                                                                                BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"
                                                                            };
                                                                            using IWebDriver driver = new ChromeDriver(BASE_PATH, options);
                                                                            ShdwChgPwdNextGenNd(shdwName, driver, acctIns);
                                                                        }
                                                                        catch (Exception cbex2)
                                                                        {
                                                                            WriteLog($"{shdwName} next gen 2nd error", cbex2.Message);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
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

        // Shadow bot Chrome
        private void ShdwBotGC(bool isChkIn)
        {
            var shdwName = "GC Bot";
            IAppConfigService appConfigService = new AppConfigService();
            var acctIns = new AcctIns
            {
                Id = appConfigService.Getter(id_ins),
                Pwd = appConfigService.Getter(pwd_ins),
                SecKey = appConfigService.Getter(sec_key)
            };
            if (!string.IsNullOrWhiteSpace(acctIns.Id) && !string.IsNullOrWhiteSpace(acctIns.Pwd) && !string.IsNullOrWhiteSpace(acctIns.SecKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    using IWebDriver driver = new ChromeDriver();
                    ShdwChkIO(shdwName, driver, isChkIn, acctIns);
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
                    try
                    {
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        using IWebDriver driver = new ChromeDriver();
                        ShdwChkIONextGenSt(shdwName, driver, isChkIn, acctIns);
                    }
                    catch (Exception ex1)
                    {
                        WriteLog($"{shdwName} next gen 1st error", ex1.Message);
                        try
                        {
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            using IWebDriver driver = new ChromeDriver();
                            ShdwChkIONextGenNd(shdwName, driver, isChkIn, acctIns);
                        }
                        catch (Exception ex2)
                        {
                            WriteLog($"{shdwName} next gen 2nd error", ex2.Message);
                        }
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
            var acctIns = new AcctIns
            {
                Id = appConfigService.Getter(id_ins),
                Pwd = appConfigService.Getter(pwd_ins),
                SecKey = appConfigService.Getter(sec_key)
            };
            if (!string.IsNullOrWhiteSpace(acctIns.Id) && !string.IsNullOrWhiteSpace(acctIns.Pwd) && !string.IsNullOrWhiteSpace(acctIns.SecKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    using IWebDriver driver = new FirefoxDriver();
                    ShdwChkIO(shdwName, driver, isChkIn, acctIns);
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
                    try
                    {
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        using IWebDriver driver = new FirefoxDriver();
                        ShdwChkIONextGenSt(shdwName, driver, isChkIn, acctIns);
                    }
                    catch (Exception ex1)
                    {
                        WriteLog($"{shdwName} next gen 1st error", ex1.Message);
                        try
                        {
                            new DriverManager().SetUpDriver(new FirefoxConfig());
                            using IWebDriver driver = new FirefoxDriver();
                            ShdwChkIONextGenNd(shdwName, driver, isChkIn, acctIns);
                        }
                        catch (Exception ex2)
                        {
                            WriteLog($"{shdwName} next gen 2nd error", ex2.Message);
                        }
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
            var acctIns = new AcctIns
            {
                Id = appConfigService.Getter(id_ins),
                Pwd = appConfigService.Getter(pwd_ins),
                SecKey = appConfigService.Getter(sec_key)
            };
            if (!string.IsNullOrWhiteSpace(acctIns.Id) && !string.IsNullOrWhiteSpace(acctIns.Pwd) && !string.IsNullOrWhiteSpace(acctIns.SecKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    using IWebDriver driver = new EdgeDriver();
                    ShdwChkIO(shdwName, driver, isChkIn, acctIns);
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
                    try
                    {
                        new DriverManager().SetUpDriver(new EdgeConfig());
                        using IWebDriver driver = new EdgeDriver();
                        ShdwChkIONextGenSt(shdwName, driver, isChkIn, acctIns);
                    }
                    catch (Exception ex1)
                    {
                        WriteLog($"{shdwName} next gen 1st error", ex1.Message);
                        try
                        {
                            new DriverManager().SetUpDriver(new EdgeConfig());
                            using IWebDriver driver = new EdgeDriver();
                            ShdwChkIONextGenNd(shdwName, driver, isChkIn, acctIns);
                        }
                        catch (Exception ex2)
                        {
                            WriteLog($"{shdwName} next gen 2nd error", ex2.Message);
                        }
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
            var acctIns = new AcctIns
            {
                Id = appConfigService.Getter(id_ins),
                Pwd = appConfigService.Getter(pwd_ins),
                SecKey = appConfigService.Getter(sec_key)
            };
            if (!string.IsNullOrWhiteSpace(acctIns.Id) && !string.IsNullOrWhiteSpace(acctIns.Pwd) && !string.IsNullOrWhiteSpace(acctIns.SecKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    using IWebDriver driver = new InternetExplorerDriver();
                    ShdwChkIO(shdwName, driver, isChkIn, acctIns);
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
                    try
                    {
                        new DriverManager().SetUpDriver(new InternetExplorerConfig());
                        using IWebDriver driver = new InternetExplorerDriver();
                        ShdwChkIONextGenSt(shdwName, driver, isChkIn, acctIns);
                    }
                    catch (Exception ex1)
                    {
                        WriteLog($"{shdwName} next gen 1st error", ex1.Message);
                        try
                        {
                            new DriverManager().SetUpDriver(new InternetExplorerConfig());
                            using IWebDriver driver = new InternetExplorerDriver();
                            ShdwChkIONextGenNd(shdwName, driver, isChkIn, acctIns);
                        }
                        catch (Exception ex2)
                        {
                            WriteLog($"{shdwName} next gen 2nd error", ex2.Message);
                        }
                    }
                }
            }
            else
            {
                WriteLog(shdwName, "Missing value!");
            }
        }

        // Shadow bot Brave
        private void ShdwBotCB(bool isChkIn)
        {
            var shdwName = "CB Bot";
            IAppConfigService appConfigService = new AppConfigService();
            var acctIns = new AcctIns
            {
                Id = appConfigService.Getter(id_ins),
                Pwd = appConfigService.Getter(pwd_ins),
                SecKey = appConfigService.Getter(sec_key)
            };
            if (!string.IsNullOrWhiteSpace(acctIns.Id) && !string.IsNullOrWhiteSpace(acctIns.Pwd) && !string.IsNullOrWhiteSpace(acctIns.SecKey))
            {
                var counter = 0;
            Attack:
                try
                {
                    SetEnvironmentVariable("webdriver.chrome.driver", $@"{BASE_PATH}\chromedriver.exe");
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var options = new ChromeOptions
                    {
                        BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"
                    };
                    using IWebDriver driver = new ChromeDriver(BASE_PATH, options);
                    ShdwChkIO(shdwName, driver, isChkIn, acctIns);
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
                    try
                    {
                        SetEnvironmentVariable("webdriver.chrome.driver", $@"{BASE_PATH}\chromedriver.exe");
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        var options = new ChromeOptions
                        {
                            BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"
                        };
                        using IWebDriver driver = new ChromeDriver(BASE_PATH, options);
                        ShdwChkIONextGenSt(shdwName, driver, isChkIn, acctIns);
                    }
                    catch (Exception ex1)
                    {
                        WriteLog($"{shdwName} next gen 1st error", ex1.Message);
                        try
                        {
                            SetEnvironmentVariable("webdriver.chrome.driver", $@"{BASE_PATH}\chromedriver.exe");
                            new DriverManager().SetUpDriver(new ChromeConfig());
                            var options = new ChromeOptions
                            {
                                BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"
                            };
                            using IWebDriver driver = new ChromeDriver(BASE_PATH, options);
                            ShdwChkIONextGenNd(shdwName, driver, isChkIn, acctIns);
                        }
                        catch (Exception ex2)
                        {
                            WriteLog($"{shdwName} next gen 2nd error", ex2.Message);
                        }
                    }
                }
            }
            else
            {
                WriteLog(shdwName, "Missing value!");
            }
        }

        // Shadow login
        private void ShdwLogin(string shdwName, IWebDriver driver, AcctIns acctIns)
        {
            // access link
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(link_ins);
            Sleep(TIME_OUT);
            // enter Id
            var elemId = driver.FindElement(Id(id_inp_id));
            elemId.SendKeys(acctIns.Id);
            Sleep(DELAY);
            // enter password
            var elemPwd = driver.FindElement(Id(id_inp_pwd));
            elemPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter OTP
            var elemOtp = driver.FindElement(Id(id_inp_otp));
            elemOtp.SendKeys(GetOTP(acctIns.SecKey));
            Sleep(DELAY);
            // login
            var elemBtnLogIn = driver.FindElement(Id(id_btn_login));
            elemBtnLogIn.Click();
            WriteLog(shdwName, "Logged!");
            Sleep(TIME_OUT);
        }

        // Shadow login next generation
        private void ShdwLoginNextGen(string shdwName, IWebDriver driver, AcctIns acctIns)
        {
            // access link
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(link_ins);
            Sleep(TIME_OUT);
            // enter Id
            var elemId = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_inp_id.Remove(0))));
            elemId.SendKeys(acctIns.Id);
            Sleep(DELAY);
            // enter password
            var elemPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_inp_pwd.Remove(0))));
            elemPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter OTP
            var elemOtp = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_inp_otp.Remove(0))));
            elemOtp.SendKeys(GetOTP(acctIns.SecKey));
            Sleep(DELAY);
            // login
            var elemBtnLogIn = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_login.Remove(0))));
            elemBtnLogIn.Click();
            WriteLog(shdwName, "Logged!");
            Sleep(TIME_OUT);
        }

        // Shadow check in/out
        private void ShdwChkIO(string shdwName, IWebDriver driver, bool isChkIn, AcctIns acctIns)
        {
            ShdwLogin(shdwName, driver, acctIns);
            // check click
            var elemBtnChk = isChkIn ? driver.FindElement(Id(id_btn_chkin)) : driver.FindElement(Id(id_btn_chkout));
            elemBtnChk.Click();
            WriteLog(shdwName, isChkIn ? "Checked in!" : "Checked out!");
            Sleep(DELAY);
        }

        // Shadow check in/out next generation first
        private void ShdwChkIONextGenSt(string shdwName, IWebDriver driver, bool isChkIn, AcctIns acctIns)
        {
            ShdwLogin(shdwName, driver, acctIns);
            // check click
            var elemBtnChk = isChkIn ? new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chkin.Remove(0)))) : new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chkout.Remove(0))));
            elemBtnChk.Click();
            WriteLog(shdwName, isChkIn ? "Checked in!" : "Checked out!");
            Sleep(DELAY);
        }

        // Shadow check in/out next generation second
        private void ShdwChkIONextGenNd(string shdwName, IWebDriver driver, bool isChkIn, AcctIns acctIns)
        {
            ShdwLoginNextGen(shdwName, driver, acctIns);
            // check click
            var elemBtnChk = isChkIn ? new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chkin.Remove(0)))) : new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chkout.Remove(0))));
            elemBtnChk.Click();
            WriteLog(shdwName, isChkIn ? "Checked in!" : "Checked out!");
            Sleep(DELAY);
        }

        // Shadow change password
        private void ShdwChgPwd(string shdwName, IWebDriver driver, AcctIns acctIns)
        {
            ShdwLogin(shdwName, driver, acctIns);
            // forward
            driver.Navigate().GoToUrl(link_ins_chg_pwd);
            // enter old password
            var elemOldPwd = driver.FindElement(Id(id_old_pwd));
            elemOldPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter new password
            var elemNewPwd = driver.FindElement(Id(id_new_pwd));
            elemNewPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // enter confirm password
            var elemCfmPwd = driver.FindElement(Id(id_cfm_pwd));
            elemCfmPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // change password
            var elemBtnChgPwd = driver.FindElement(Id(id_btn_chg_pwd));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password changed!");
            Sleep(TIME_OUT);
            // enter old password
            elemOldPwd = driver.FindElement(Id(id_old_pwd));
            elemOldPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // enter new password
            elemNewPwd = driver.FindElement(Id(id_new_pwd));
            elemNewPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter confirm password
            elemCfmPwd = driver.FindElement(Id(id_cfm_pwd));
            elemCfmPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // change password
            elemBtnChgPwd = driver.FindElement(Id(id_btn_chg_pwd));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password re-changed!");
            Sleep(TIME_OUT);
        }

        // Shadow change password next generation first
        private void ShdwChgPwdNextGenSt(string shdwName, IWebDriver driver, AcctIns acctIns)
        {
            ShdwLoginNextGen(shdwName, driver, acctIns);
            // forward
            driver.Navigate().GoToUrl(link_ins_chg_pwd);
            // enter old password
            var elemOldPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_old_pwd.Remove(0))));
            elemOldPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter new password
            var elemNewPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_new_pwd.Remove(0))));
            elemNewPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // enter confirm password
            var elemCfmPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_cfm_pwd.Remove(0))));
            elemCfmPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // change password
            var elemBtnChgPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chg_pwd.Remove(0))));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password changed!");
            Sleep(TIME_OUT);
            // enter old password
            elemOldPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_old_pwd.Remove(0))));
            elemOldPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // enter new password
            elemNewPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_new_pwd.Remove(0))));
            elemNewPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter confirm password
            elemCfmPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_cfm_pwd.Remove(0))));
            elemCfmPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // change password
            elemBtnChgPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chg_pwd.Remove(0))));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password re-changed!");
            Sleep(TIME_OUT);
        }

        // Shadow change password next generation second
        private void ShdwChgPwdNextGenNd(string shdwName, IWebDriver driver, AcctIns acctIns)
        {
            ShdwLogin(shdwName, driver, acctIns);
            // forward
            driver.Navigate().GoToUrl(link_ins_chg_pwd);
            // enter old password
            var elemOldPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_old_pwd.Remove(0))));
            elemOldPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter new password
            var elemNewPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_new_pwd.Remove(0))));
            elemNewPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // enter confirm password
            var elemCfmPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_cfm_pwd.Remove(0))));
            elemCfmPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // change password
            var elemBtnChgPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chg_pwd.Remove(0))));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password changed!");
            Sleep(TIME_OUT);
            // enter old password
            elemOldPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_old_pwd.Remove(0))));
            elemOldPwd.SendKeys(acctIns.PwdPrev);
            Sleep(DELAY);
            // enter new password
            elemNewPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_new_pwd.Remove(0))));
            elemNewPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // enter confirm password
            elemCfmPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_cfm_pwd.Remove(0))));
            elemCfmPwd.SendKeys(acctIns.Pwd);
            Sleep(DELAY);
            // change password
            elemBtnChgPwd = new WebDriverWait(driver, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chg_pwd.Remove(0))));
            elemBtnChgPwd.Click();
            WriteLog(shdwName, "Password re-changed!");
            Sleep(TIME_OUT);
        }
    }
}
