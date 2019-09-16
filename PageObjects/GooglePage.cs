using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seledemo2.PageObjects
{
    class GooglePage :TestBaseFold.TestBase
    {

        IWebDriver driver;

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "home")]
        private IWebElement home;

        [FindsBy(How = How.LinkText, Using = "home")]
        private IWebElement BlazeDemo;

        [FindsBy(How = How.Name, Using = "fromPort")]
        private IWebElement FromPort;

        [FindsBy(How = How.Name, Using = "toPort")]
        private IWebElement ToPort;

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Choose your destination city:'])[1]/following::input[1]")]
        private IWebElement ChooseDestinationCity;

        public void clickHomeLink()
        {
            TestBaseFold.TestBase.click(home);


        }

    }
}
