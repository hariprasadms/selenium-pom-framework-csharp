using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seledemo2.TestBaseFold
{


    class TestBase
    {

       public IWebDriver driver;
       public StringBuilder verificationErrors;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\test-hari");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

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
