# FYAN BOT LOGINSIDE
- Run automatically at startup in Windows
- Bypass user password logon Windows
- Auto get OTP with the Secret Key set on GUI
- Auto login page inside of FPT Retail with the account set on GUI (Chrome, FireFox, Edge, IE, Brave)
- Checkin at the set time on GUI
- Checkout at the set time on GUI
- Auto change password bypass rule inside
- Auto update new version

## AVATAR
<p align='center'>
<img src='pic/13.png'></img>
</p>

## IMAGE DEMO
<p align='center'>
<img src='pic/0.jpg'></img>
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

### PACKAGE
</div>
<img src='pic/9.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- AngleSharp » 1.0.1

<img src='pic/4.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Animator » 1.0.3

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Microsoft.Win32.Registry » 5.0.0

</div>
<img src='pic/5.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Otp.NET » 1.3.0

</div>
<img src='pic/6.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Selenium.WebDriver » 4.9.1

</div>
<img src='pic/7.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Selenium.WebDriver.ChromeDriver » 113.0.5672.6300

</div>
<img src='pic/2.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Selenium.WebDriver.GeckoDriver » 0.33.0

</div>
<img src='pic/3.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Selenium.WebDriver.IEDriver » 4.8.1

</div>
<img src='pic/12.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Serilog » 2.12.0

</div>
<img src='pic/11.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Serilog.Sinks.File » 5.0.0

</div>
<img src='pic/10.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- SharpZipLib » 1.4.2

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Buffers » 4.5.1

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Memory » 4.5.5

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Numerics.Vectors » 4.5.0

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Runtime.CompilerServices.Unsafe » 6.0.0

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Security.AccessControl » 6.0.0

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Security.Principal.Windows » 5.0.0

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Text.Encoding.CodePages » 7.0.0

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.Threading.Tasks.Extensions » 4.5.4

</div>
<img src='pic/8.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- System.ValueTuple » 4.5.0

</div>
<img src='pic/1.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- Tynab.YANF » 1.0.1

</div>
<img src='pic/4.png' align='left' width='3%' height='3%'></img>
<div style='display:flex;'>

- WebDriverManager » 2.16.2

</div>
