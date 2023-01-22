﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using static Loginside_FYAN_Bot_Service.Properties.Resources;
using static Loginside_FYAN_Bot_Service.Script.Common;
using static Loginside_FYAN_Bot_Service.Script.Constant;
using static System.Environment;

namespace Loginside_FYAN_Bot_Service.Script.Model;

internal class CbBot : ShdwBot
{
    #region Porperties
    internal new string Name { get; } = "CB Bot";
    #endregion

    #region Overridden
    protected internal override void ShdwBotChk()
    {
        var logger = new Logger();
        var appConfig = new AppConfig();
        var acctIns = new AccountInside
        {
            Id = appConfig.Getter(id_ins),
            Pwd = appConfig.Getter(pwd_ins),
            SecKey = appConfig.Getter(sec_key)
        };
        if (HasVals(acctIns.Id, acctIns.Pwd, acctIns.SecKey))
        {
            var ctr = 0;
        Attack:
            try
            {
                SetEnvironmentVariable(ENV_VAR_WEB_DRV_CR, CR_DRV_ADR);
                new DriverManager().SetUpDriver(new ChromeConfig());
                var opts = new ChromeOptions
                {
                    BinaryLocation = BRV_ADR
                };
                using IWebDriver drv = new ChromeDriver(BASE_PATH, opts);
                ShdwChkIO(Name, drv, acctIns);
            }
            catch (Exception ex)
            {
                ctr++;
                logger.WrLog($"{Name} error", ex.Message);
                // limit attack
                if (ctr is > 0 and < LMT_ATK)
                {
                    goto Attack;
                }
            }
        }
        else
        {
            logger.WrLog(Name, "Missing value!");
        }
    }

    protected internal override bool ShdwBotPwd()
    {
        var logger = new Logger();
        var appConfig = new AppConfig();
        var acctIns = new AccountInside
        {
            Id = appConfig.Getter(id_ins),
            Pwd = appConfig.Getter(pwd_ins),
            PwdPrev = appConfig.Getter(pwd_prev),
            SecKey = appConfig.Getter(sec_key)
        };
        if (HasVals(acctIns.Id, acctIns.Pwd, acctIns.PwdPrev, acctIns.SecKey))
        {
            try
            {
                SetEnvironmentVariable(ENV_VAR_WEB_DRV_CR, CR_DRV_ADR);
                new DriverManager().SetUpDriver(new ChromeConfig());
                var opts = new ChromeOptions
                {
                    BinaryLocation = BRV_ADR
                };
                using IWebDriver drv = new ChromeDriver(BASE_PATH, opts);
                ShdwChgPwd(Name, drv, acctIns);
                return true;
            }
            catch (Exception ex)
            {
                logger.WrLog($"{Name} error", ex.Message);
                return false;
            }
        }
        else
        {
            logger.WrLog(Name, "Missing value!");
            return false;
        }
    }
    #endregion
}
