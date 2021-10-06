# WebDriverManager

Supports

* chrome
* firefox
* internet explorer
* edge

Currently supports windows for simple management.
Linux and MAC in development.

## Windows
Scans the registry for the given browser, if found it will return a version number which will be compared to the available versions on the various distribution systems.
The driver will be stored in %USERPROFILE%/WebDrivers 
If the driver already exists it will not be redownloaded

Examples

Chrome Driver
```csharp
    var binaryDir = Manager.GetWebDriver(Manager.BrowserType.CHROME);
    var driver = new ChromeDriver(binaryDir);
```

Firefox
```csharp

   var binaryDir = Manager.GetWebDriver(Manager.BrowserType.FIREFOX);

    FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService(binaryDir);
    firefoxDriverService.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

    var driver = new FirefoxDriver(firefoxDriverService);
```

IE
```csharp
    var binaryDir = Manager.GetWebDriver(Manager.BrowserType.INTERNET_EXPLORER);
    var driver = new InternetExplorerDriver(binaryDir);
```

Edge
```csharp
    var binaryDir = Manager.GetWebDriver(Manager.BrowserType.EDGE);
    var driver = new EdgeDriver(binaryDir);
```