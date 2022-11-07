# FYAN BOT LOGINSIDE
- Run automatically at startup in Windows
- Bypass user password logon Windows
- Auto get OTP with the Secret Key set on GUI
- Auto login page inside of FPT Retail with the account set on GUI (Chrome, FireFox, Edge, IE)
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
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/9.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- AngleSharp » 0.17.1

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Microsoft.Win32.Registry » 5.0.0

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

- Selenium.WebDriver.ChromeDriver » 107.0.5304.6200

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/2.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver.GeckoDriver » 0.32.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/3.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver.IEDriver » 4.6.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/10.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- SharpZipLib » 1.4.1

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Buffers » 4.5.1

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Memory » 4.5.5

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Numerics.Vectors » 4.5.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Runtime.CompilerServices.Unsafe » 6.0.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Security.AccessControl » 6.0.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Security.Principal.Windows » 5.0.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Text.Encoding.CodePages » 6.0.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/8.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Threading.Tasks.Extensions » 4.5.4

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/4.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- WebDriverManager » 2.16.0

</div>
