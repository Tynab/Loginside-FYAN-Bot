using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Threading.Tasks;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static OpenQA.Selenium.By;
using static System.Threading.Tasks.Task;
using static System.Threading.Thread;

namespace Loginside_FYAN_Bot_Service.Script.Model;

internal class FyanBot
{
    #region Fields
    private readonly Logger _logger = new();
    private readonly AppConfig _appConfig = new();
    #endregion

    #region Porperties
    internal string Name { get; } = BOT_NAME;
    internal bool IsCheckIn { get; set; } = true;
    #endregion

    #region Methods
    /// <summary>
    /// Bot check in/out.
    /// </summary>
    internal void BotChk()
    {
        var shdwBot = new ShdwBot[SHDW_BOT_CNT]
        {
            new GcBot(this),
            new FfBot(this),
            new MeBot(this),
            new IeBot(this),
            new CbBot(this)
        };
        for (var i = 0; i < SHDW_BOT_CNT; i++)
        {
            new Thread(() => shdwBot[i].ShdwBotChk()).Start();
            Sleep(100);
        }
    }

    /// <summary>
    /// Bot change password.
    /// </summary>
    internal void BotPwd()
    {
        var tasks = new Task<bool>[SHDW_BOT_CNT]
        {
            Run(() => new GcBot().ShdwBotPwd()),
            Run(() => new FfBot().ShdwBotPwd()),
            Run(() => new MeBot().ShdwBotPwd()),
            Run(() => new IeBot().ShdwBotPwd()),
            Run(() => new CbBot().ShdwBotPwd())
        };
        if (tasks.WaitAnyWithCond(true).Result)
        {
            var pwd = _appConfig.Getter(pwd_ins);
            _appConfig.Setter(pwd_ins, _appConfig.Getter(pwd_prev));
            _appConfig.Setter(pwd_prev, pwd);
        }
    }

    // Shadow login
    private void ShdwLogin(string shdwName, IWebDriver drv, WebDriverWait webDrWait, AccountInside acctIns)
    {
        // access link
        drv.Manage().Window.Maximize();
        drv.Navigate().GoToUrl(link_ins);
        Sleep(TIME_OUT);
        // enter Id
        var elemId = webDrWait.Until(e => e.FindElement(Id(id_inp_id)));
        elemId.SendKeys(acctIns.Id);
        Sleep(DELAY);
        // enter password
        var elemPwd = webDrWait.Until(e => e.FindElement(Id(id_inp_pwd)));
        elemPwd.SendKeys(acctIns.Pwd);
        Sleep(DELAY);
        // enter OTP
        var elemOtp = webDrWait.Until(e => e.FindElement(Id(id_inp_otp)));
        elemOtp.SendKeys(GetOtp(acctIns.SecKey));
        Sleep(DELAY);
        // login
        var elemBtnLogIn = webDrWait.Until(e => e.FindElement(Id(id_btn_login)));
        elemBtnLogIn.Click();
        _logger.WrLog(shdwName, "Logged!");
        Sleep(TIME_OUT);
    }

    /// <summary>
    /// Shadow check in/out.
    /// </summary>
    /// <param name="shdwName"></param>
    /// <param name="drv"></param>
    /// <param name="acctIns"></param>
    protected void ShdwChkIO(string shdwName, IWebDriver drv, AccountInside acctIns)
    {
        var webElem = new WebDriverWait(drv, WAIT_SPAN);
        ShdwLogin(shdwName, drv, webElem, acctIns);
        // check click
        var elemBtnChk = IsCheckIn ? webElem.Until(e => e.FindElement(Id(id_btn_chkin))) : webElem.Until(e => e.FindElement(Id(id_btn_chkout)));
        elemBtnChk.Click();
        _logger.WrLog(shdwName, IsCheckIn ? "Checked in!" : "Checked out!");
        Sleep(DELAY);
    }

    /// <summary>
    /// Shadow change password.
    /// </summary>
    /// <param name="shdwName"></param>
    /// <param name="drv"></param>
    /// <param name="acctIns"></param>
    protected void ShdwChgPwd(string shdwName, IWebDriver drv, AccountInside acctIns)
    {
        var webElem = new WebDriverWait(drv, WAIT_SPAN);
        ShdwLogin(shdwName, drv, webElem, acctIns);
        // forward
        drv.Navigate().GoToUrl(link_ins_chg_pwd);
        // enter old password
        var elemOldPwd = webElem.Until(e => e.FindElement(Id(id_old_pwd)));
        elemOldPwd.SendKeys(acctIns.Pwd);
        Sleep(DELAY);
        // enter new password
        var elemNewPwd = webElem.Until(e => e.FindElement(Id(id_new_pwd)));
        elemNewPwd.SendKeys(acctIns.PwdPrev);
        Sleep(DELAY);
        // enter confirm password
        var elemCfmPwd = webElem.Until(e => e.FindElement(Id(id_cfm_pwd)));
        elemCfmPwd.SendKeys(acctIns.PwdPrev);
        Sleep(DELAY);
        // change password
        var elemBtnChgPwd = webElem.Until(e => e.FindElement(Id(id_btn_chg_pwd)));
        elemBtnChgPwd.Click();
        _logger.WrLog(shdwName, "Password changed!");
        Sleep(TIME_OUT);
    }
    #endregion
}
