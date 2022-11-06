# FYAN BOT LOGINSIDE
- Run automatically at startup in Windows
- Bypass user password logon Windows
- Auto get OTP with the Secret Key set on GUI
- Auto login page inside of FPT Retail with the account set on GUI (Chrome, FireFox, Edge, IE, Safari)
- Checkin at the set time on GUI
- Checkout at the set time on GUI
- Auto change password bypass rule inside

## HÌNH ẢNH DEMO
<p align="center">
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/0.jpg"></img>
</p>

## CODE DEMO
```c#
using AnimatorNS;
using System.Windows.Forms;

/// <summary>
/// Show animation async.
/// </summary>
/// <param name="type">Effect type.</param>
/// <param name="spd">Frame per milisecond.</param>
internal static void ShowAnimatAsync(this Control ctrl, AnimationType type, float spd)
{
	var animat = new Animator
	{
		TimeStep = spd,
		AnimationType = type
	};
	animat.Show(ctrl);
}

/// <summary>
/// Hide animation async.
/// </summary>
/// <param name="type">Effect type.</param>
/// <param name="spd">Frame per milisecond.</param>
internal static void HideAnimatAsync(this Control ctrl, AnimationType type, float spd)
{
	var animat = new Animator
	{
		TimeStep = spd,
		AnimationType = type
	};
	animat.Hide(ctrl);
}
```

### TÍCH HỢP
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/4.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Animator » 1.0.3

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/1.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Tynab.YANF » 1.0.1

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/5.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Otp.NET » 1.2.2

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/6.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver » 4.6.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/7.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver.ChromeDriver » 108.0.5359.2200-beta

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/2.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver.GeckoDriver » 0.32.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/3.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver.IEDriver » 4.6.0

</div>
