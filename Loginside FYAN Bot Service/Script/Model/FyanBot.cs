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
    internal string Name { get; } = "Fyan Bot";
    internal bool IsCheckIn { get; set; } = true;
    #endregion

    #region Methods
    /// <summary>
    /// Bot check in/out.
    /// </summary>
    internal void BotChk()
    {
        new Thread(() => new GcBot().ShdwBotChk()).Start();
        new Thread(() => new FfBot().ShdwBotChk()).Start();
        new Thread(() => new MeBot().ShdwBotChk()).Start();
        new Thread(() => new IeBot().ShdwBotChk()).Start();
        new Thread(() => new CbBot().ShdwBotChk()).Start();
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
    private void ShdwLogin(string shdwName, IWebDriver dvr, AccountInside acctIns)
    {
        // access link
        dvr.Manage().Window.Maximize();
        dvr.Navigate().GoToUrl(link_ins);
        Sleep(TIME_OUT);
        // enter Id
        var elemId = new WebDriverWait(dvr, WAIT_SPAN).Until(e => e.FindElement(Id(id_inp_id)));
        elemId.SendKeys(acctIns.Id);
        Sleep(DELAY);
        // enter password
        var elemPwd = new WebDriverWait(dvr, WAIT_SPAN).Until(e => e.FindElement(Id(id_inp_pwd)));
        elemPwd.SendKeys(acctIns.Pwd);
        Sleep(DELAY);
        // enter OTP
        var elemOtp = new WebDriverWait(dvr, WAIT_SPAN).Until(e => e.FindElement(Id(id_inp_otp)));
        elemOtp.SendKeys(GetOtp(acctIns.SecKey));
        Sleep(DELAY);
        // login
        var elemBtnLogIn = new WebDriverWait(dvr, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_login)));
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
        ShdwLogin(shdwName, drv, acctIns);
        // check click
        var elemBtnChk = IsCheckIn ? new WebDriverWait(drv, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chkin))) : new WebDriverWait(drv, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chkout)));
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
        ShdwLogin(shdwName, drv, acctIns);
        // forward
        drv.Navigate().GoToUrl(link_ins_chg_pwd);
        // enter old password
        var elemOldPwd = new WebDriverWait(drv, WAIT_SPAN).Until(e => e.FindElement(Id(id_old_pwd)));
        elemOldPwd.SendKeys(acctIns.Pwd);
        Sleep(DELAY);
        // enter new password
        var elemNewPwd = new WebDriverWait(drv, WAIT_SPAN).Until(e => e.FindElement(Id(id_new_pwd)));
        elemNewPwd.SendKeys(acctIns.PwdPrev);
        Sleep(DELAY);
        // enter confirm password
        var elemCfmPwd = new WebDriverWait(drv, WAIT_SPAN).Until(e => e.FindElement(Id(id_cfm_pwd)));
        elemCfmPwd.SendKeys(acctIns.PwdPrev);
        Sleep(DELAY);
        // change password
        var elemBtnChgPwd = new WebDriverWait(drv, WAIT_SPAN).Until(e => e.FindElement(Id(id_btn_chg_pwd)));
        elemBtnChgPwd.Click();
        _logger.WrLog(shdwName, "Password changed!");
        Sleep(TIME_OUT);
    }
    #endregion
}
