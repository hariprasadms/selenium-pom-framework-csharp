using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using seledemo2.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seledemo2
{
    class HariTestDemo : TestBaseFold.TestBase
    {
        
        [Test]
        public void Test1()
        {

            driver.Navigate().GoToUrl("http://blazedemo.com/");
            driver.FindElement(By.LinkText("home")).Click();
            driver.FindElement(By.LinkText("BlazeDemo")).Click();
            new SelectElement(driver.FindElement(By.Name("fromPort"))).SelectByText("Boston");
            new SelectElement(driver.FindElement(By.Name("toPort"))).SelectByText("London");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Choose your destination city:'])[1]/following::input[1]")).Click();
            driver.FindElement(By.LinkText("home")).Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("testscreenshot");
       
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("ASOS");
            driver.FindElement(By.Name("btnK")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Web result with site links'])[1]/following::div[5]")).Click();
            Assert.AreEqual("ASOS | Online Shopping for the Latest Clothes & Fashion", driver.Title);
            driver.FindElement(By.Id("chrome-search")).Clear();
            driver.FindElement(By.Id("chrome-search")).SendKeys("belt");
            driver.FindElement(By.CssSelector("button.kH5PAAC._1KRfEms > svg")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='£290'])[2]/following::img[1]")).Click();
            Assert.AreEqual("ASOS DESIGN double circle waist and hip jeans belt", driver.FindElement(By.XPath("//h1[contains(text(),'ASOS DESIGN double circle waist and hip jeans belt')]")).Text);

        }

        [Test]
        public void Test3()
        {
            GooglePage gp = new GooglePage(driver);
            driver.Navigate().GoToUrl("http://blazedemo.com/");
            gp.clickHomeLink();
            

        }

    }
}
