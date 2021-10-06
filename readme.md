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

