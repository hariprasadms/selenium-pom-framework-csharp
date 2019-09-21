using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seledemo2.TestBaseFold
{

    [Obsolete]
    class TestBase
    {

       public IWebDriver driver;
       public String BrowserType = "bs";
       public DesiredCapabilities capability;

        [SetUp]
        [Obsolete]
        public void StartBrowser()
        {

            if (BrowserType == "bs")
            {
                capability = new DesiredCapabilities();

                capability.SetCapability("browser", "Chrome");
                capability.SetCapability("browser_version", "62.0");
                capability.SetCapability("os", "Windows");
                capability.SetCapability("os_version", "10");
                capability.SetCapability("resolution", "1024x768");
                capability.SetCapability("browserstack.user", "<BROWSERSTACK_KYE>");
                capability.SetCapability("browserstack.key", "<BROWSERSTACK_VALUE>");
                capability.SetCapability("name", "Bstack-[C_sharp] Sample Test");

                driver = new RemoteWebDriver(
                  new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability
                );
            }
            else
            {

                driver = new ChromeDriver("C:\\test-hari");
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        }

        public static void click(IWebElement element)
        {
            element.Click();
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
