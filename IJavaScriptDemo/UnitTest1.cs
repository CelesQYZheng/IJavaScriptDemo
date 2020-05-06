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
        public void JavascriptCheckboxDemo()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";
            Thread.Sleep(2000);

            // check checkbox
            ((IJavaScriptExecutor)driver).ExecuteScript("document.querySelectorAll('input[value=read]')[0].click()");
            Thread.Sleep(2000);
            // uncheck the checkbox 
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
            // get the inner text
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
            // get the title
            var title = ((IJavaScriptExecutor)driver).ExecuteScript("return document.title;").ToString();

            Console.WriteLine(title);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptGetTheDomain()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);
            // get the domain
            var domain = ((IJavaScriptExecutor)driver).ExecuteScript("return document.domain;").ToString();
            // print out domain
            Console.WriteLine(domain);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptGetTheURL()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);
            // get the URL
            var url = ((IJavaScriptExecutor)driver).ExecuteScript("return document.URL;").ToString();
            // print out domain
            Console.WriteLine(url);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptScrollThePage()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);
            // scroll down the page
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 1000)");
            Thread.Sleep(2000);
            // scroll up
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, -1000)");
            Thread.Sleep(2000);
            // scroll to the end
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, document.body.scrollHeight)");
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptNavigateToOtherpage()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.location ='https://google.com';");
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptGettheSizeofPage()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "https://techexpozed.co.nz";
            Thread.Sleep(2000);
            var pwidth = ((IJavaScriptExecutor)driver).ExecuteScript("return window.innerWidth;").ToString();
            var pheight = ((IJavaScriptExecutor)driver).ExecuteScript("return window.innerHeight;").ToString();
            Console.WriteLine(pwidth);
            Console.WriteLine(pheight);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptInsertTextInput()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "https://techexpozed.co.nz/contact-us.php";
            driver.Manage().Window.FullScreen();
            Thread.Sleep(2000);
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('name').value ='Jane Perez';");
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('email').value ='perezmail@mail.com';");

            
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptHandleAlert()
        {
            IWebDriver driver = new FirefoxDriver();
            // nevigate to the page
            driver.Url = "http://uitestpractice.com/Students/Switchto";

            //driver.FindElement(By.Id("alert")).Click();
            //Thread.Sleep(2000);

            //var s1 = driver.SwitchTo().Alert().Text;
            //Thread.Sleep(2000);
            //Console.WriteLine(s1);
            //driver.SwitchTo().Alert().Accept();


            //driver.FindElement(By.Id("prompt")).Click();
            //driver.SwitchTo().Alert().SendKeys("selenium");
            //Thread.Sleep(2000);
            //driver.SwitchTo().Alert().Accept(); //accepts the alert window
            ////driver.SwitchTo().Alert().Dismiss();  //cancels the alert window
            //
            driver.FindElement(By.Id("confirm")).Click();
            var s1 = driver.SwitchTo().Alert().Text;
            Console.WriteLine(s1);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Quit();
        }
    }

}
