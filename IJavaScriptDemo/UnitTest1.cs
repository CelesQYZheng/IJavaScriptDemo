using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace IJavaScriptDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JavaScriptPopup()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);
            ((IJavaScriptExecutor)driver).ExecuteScript("alert('Hello')");

        }
        [TestMethod]
        public void JavaScriptRefresh()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);

            // go to contact page
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[5]/a/span")).Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("history.go(0)");
            Thread.Sleep(2000);
        }
    }
}
