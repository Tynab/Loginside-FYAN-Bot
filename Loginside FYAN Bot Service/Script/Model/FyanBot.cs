using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static OpenQA.Selenium.By;
using static System.Threading.CancellationToken;
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
        new List<ShdwBot>
        {
            new GcBot(this),
            new FfBot(this),
            new MeBot(this),
            new IeBot(this),
            new CbBot(this)
        }?.ForEach(x =>
        {
            new Thread(() => x?.ShdwBotChk())?.Start();
            Sleep(TMR_INTVL_DFLT);
        });
    }

    /// <summary>
    /// Bot change password.
    /// </summary>
    internal void BotPwd()
    {
        if (new Task<bool>[SHDW_BOT_CNT]
        {
            Run(() => new GcBot().ShdwBotPwd()),
            Run(() => new FfBot().ShdwBotPwd()),
            Run(() => new MeBot().ShdwBotPwd()),
            Run(() => new IeBot().ShdwBotPwd()),
            Run(() => new CbBot().ShdwBotPwd())
        }.WaitAnyWithCond(true, None).Result)
        {
            _appConfig?.Setter(pwd_ins, _appConfig?.Getter(pwd_prev));
            _appConfig?.Setter(pwd_prev, _appConfig?.Getter(pwd_ins));
        }
    }

    // Shadow login
    private void ShdwLogin(string shdwName, IWebDriver drv, WebDriverWait webDrWait, AccountInside acctIns)
    {
        // access link
        drv?.Manage()?.Window?.Maximize();
        drv?.Navigate()?.GoToUrl(link_ins);
        Sleep(TIME_OUT);
        // enter Id
        webDrWait?.Until(e => e?.FindElement(Id(id_inp_id)))?.SendKeys(acctIns?.Id);
        Sleep(DELAY);
        // enter password
        webDrWait?.Until(e => e?.FindElement(Id(id_inp_pwd)))?.SendKeys(acctIns?.Pwd);
        Sleep(DELAY);
        // enter OTP
        webDrWait?.Until(e => e?.FindElement(Id(id_inp_otp)))?.SendKeys(GetOtp(acctIns?.SecKey));
        Sleep(DELAY);
        // login
        webDrWait?.Until(e => e?.FindElement(Id(id_btn_login)))?.Click();
        _logger?.WrInfo(shdwName, "Logged!");
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
        (IsCheckIn? webElem?.Until(e => e?.FindElement(Id(id_btn_chkin))) : webElem?.Until(e => e?.FindElement(Id(id_btn_chkout))))?.Click();
        _logger?.WrInfo(shdwName, IsCheckIn ? "Checked in!" : "Checked out!");
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
        drv?.Navigate()?.GoToUrl(link_ins_chg_pwd);
        // enter old password
        webElem?.Until(e => e?.FindElement(Id(id_old_pwd)))?.SendKeys(acctIns?.Pwd);
        Sleep(DELAY);
        // enter new password
        webElem?.Until(e => e?.FindElement(Id(id_new_pwd)))?.SendKeys(acctIns?.PwdPrev);
        Sleep(DELAY);
        // enter confirm password
        webElem?.Until(e => e?.FindElement(Id(id_cfm_pwd)))?.SendKeys(acctIns?.PwdPrev);
        Sleep(DELAY);
        // change password
        webElem?.Until(e => e?.FindElement(Id(id_btn_chg_pwd)))?.Click();
        _logger?.WrInfo(shdwName, "Password changed!");
        Sleep(TIME_OUT);
    }
    #endregion
}
