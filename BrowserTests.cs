using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Roman_Framework.Selenium.WebDriverManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverManager
{
    [TestFixture]
    public class BrowserTests
    {

        [OneTimeSetUp]
        public static void CleanDirectory() 
        {
            //Deletes all the drivers to ensure that the download is tested
            string user = System.Environment.GetEnvironmentVariable("USERPROFILE");
            string webdriver_dir = user + "\\WebDrivers\\";

            if (Directory.Exists(webdriver_dir)) 
            {
                Directory.Delete(webdriver_dir, true);
            }
            

        }

        [Test]
        public void ChromeTest() 
        {
            var binaryDir = Manager.GetWebDriver(Manager.BrowserType.CHROME);
            var driver = new ChromeDriver();
            Assert.That(driver != null);
            driver.Quit();
        }

        [Test]
        public void ChromeTestTwo()
        {
            //This test should not download and should work with the existing driver
            var binaryDir = Manager.GetWebDriver(Manager.BrowserType.CHROME);
            var driver = new ChromeDriver(binaryDir);
            Assert.That(driver != null);
            driver.Quit();
        }

        [Test]
        public void FirefoxTest()
        {
            var binaryDir = Manager.GetWebDriver(Manager.BrowserType.FIREFOX);

            FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService(binaryDir);
            firefoxDriverService.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            var driver = new FirefoxDriver(firefoxDriverService);
            Assert.That(driver != null);
            driver.Quit();
        }

        [Test]
        public void InternetExplorerTest()
        {
            var binaryDir = Manager.GetWebDriver(Manager.BrowserType.INTERNET_EXPLORER);
            var driver = new InternetExplorerDriver(binaryDir);
            Assert.That(driver != null);
            driver.Quit();
        }

        [Test]
        public void EdgeTest()
        {
            var binaryDir = Manager.GetWebDriver(Manager.BrowserType.EDGE);
            var driver = new EdgeDriver(binaryDir);
            Assert.That(driver != null);
            driver.Quit();
        }
    }
}
