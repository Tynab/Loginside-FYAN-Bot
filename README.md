# FYAN BOT LOGINSIDE
- Run on window startup (support window 11)
- Bypass logon user
- Auto get OTP with the Secret Key set on GUI
- Auto login page inside of FPT Retail with the account set on GUI
- Checkin at the set time on GUI
- Checkout at the set time on GUI

## HÌNH ẢNH DEMO
<p align="center">
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/0.gif"></img>
</p>

## CẤU HÌNH BUILD UNPACKAGE
```xml
<!-- project -->
	<PropertyGroup>
		<WindowsPackageType>None</WindowsPackageType>
	</PropertyGroup>
```
```json
// launch setting
{
  "profiles": {
    "Windows Machine": {
      "commandName": "Project",
      "nativeDebugging": false
    }
  }
}
```

### TÍCH HỢP
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/4.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Microsoft.Maui.Dependencies » 6.0.541

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/4.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Microsoft.Maui.Extensions » 6.0.541

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/3.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Microsoft.Windows.SDK.BuildTools » 10.0.22000.194

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/2.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- SkiaSharp.Extended.UI.Maui » 2.0.0-preview.61

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/1.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Configuration.ConfigurationManager » 7.0.0-rc.2.22472.3

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/1.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.Runtime.InteropServices.NFloat.Internal » 6.0.1

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/1.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- System.ServiceProcess.ServiceController » 6.0.0

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/5.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Otp.NET » 1.2.2

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/6.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver » 4.5.1

</div>
<img src="https://raw.githubusercontent.com/Tynab/Loginside-FYAN-Bot/main/pic/7.png" align="left" width="3%" height="3%"></img>
<div style="display:flex;">

- Selenium.WebDriver.ChromeDriver » 107.0.5304.6200

</div>
