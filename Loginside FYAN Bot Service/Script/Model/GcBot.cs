﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;

namespace Loginside_FYAN_Bot_Service.Script.Model;

internal class GcBot : ShdwBot
{
    #region Fields
    private readonly Logger _logger = new();
    private readonly AppConfig _appConfig = new();
    #endregion

    #region Porperties
    internal new string Name { get; } = "GC Bot";
    #endregion

    #region Constructors
    internal GcBot() { }

    internal GcBot(FyanBot fyanBot) => IsCheckIn = fyanBot.IsCheckIn;
    #endregion

    #region Overridden
    protected internal override void ShdwBotChk()
    {
        var acctIns = new AccountInside
        {
            Id = _appConfig?.Getter(id_ins),
            Pwd = _appConfig?.Getter(pwd_ins),
            SecKey = _appConfig?.Getter(sec_key)
        };
        if (HasVals(acctIns?.Id, acctIns?.Pwd, acctIns?.SecKey))
        {
            var ctr = 0;
        Attack:
            try
            {
                _ = (new DriverManager()?.SetUpDriver(new ChromeConfig()));
                using IWebDriver drv = new ChromeDriver();
                ShdwChkIO(Name, drv, acctIns);
            }
            catch (Exception ex)
            {
                ctr++;
                _logger?.WrErr($"{Name} error", ex);
                // limit attack
                if (ctr is > 0 and < LMT_ATK)
                {
                    goto Attack;
                }
            }
        }
        else
        {
            _logger?.WrInfo(Name, "Missing value!");
        }
    }

    protected internal override bool ShdwBotPwd()
    {
        var acctIns = new AccountInside
        {
            Id = _appConfig?.Getter(id_ins),
            Pwd = _appConfig?.Getter(pwd_ins),
            PwdPrev = _appConfig?.Getter(pwd_prev),
            SecKey = _appConfig?.Getter(sec_key)
        };
        if (HasVals(acctIns?.Id, acctIns?.Pwd, acctIns?.PwdPrev, acctIns?.SecKey))
        {
            try
            {
                _ = (new DriverManager()?.SetUpDriver(new ChromeConfig()));
                using IWebDriver drv = new ChromeDriver();
                ShdwChgPwd(Name, drv, acctIns);
                return true;
            }
            catch (Exception ex)
            {
                _logger?.WrErr($"{Name} error", ex);
                return false;
            }
        }
        else
        {
            _logger?.WrInfo(Name, "Missing value!");
            return false;
        }
    }
    #endregion
}
