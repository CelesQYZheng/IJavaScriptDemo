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
            driver.FindElement(By.LinkText("Contact")).Click();
            // refresh the page
            ((IJavaScriptExecutor)driver).ExecuteScript("history.go(0)");

            Thread.Sleep(2000);
        }

        [TestMethod]
        public void JavascriptChechboxDemo()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";
            Thread.Sleep(2000);

            // check checkbox
            ((IJavaScriptExecutor)driver).ExecuteScript("document.querySelectorAll('input[value=read]')[0].click()");
            Thread.Sleep(2000);
            // uncheck the box 
            ((IJavaScriptExecutor)driver).ExecuteScript("document.querySelector('input[value=read]').click()");
            Thread.Sleep(2000);

            driver.Quit();

        }

        [TestMethod]
        public void JavaScriptGetInnerText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);

            var innertext = ((IJavaScriptExecutor)driver).ExecuteScript("return document.documentElement.innerText;").ToString();
            Console.WriteLine(innertext);
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void JavaScriptGetTheTitle()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);

            var title = ((IJavaScriptExecutor)driver).ExecuteScript("return document.title;").ToString();

            Console.WriteLine(title);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
