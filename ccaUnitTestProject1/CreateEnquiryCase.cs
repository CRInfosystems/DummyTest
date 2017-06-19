using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Threading;

namespace ccsCreateContactTestProject1
{
    [TestClass]
    public class CreateEnquiryCase
    {
        IWebDriver driver;
        private object verificationErrors;

        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://crowncommercial--bauqa.cs86.my.salesforce.com/");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("chitta.jena@crowncommercial.gov.uk.bauqa");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Data@3456");
            driver.FindElement(By.Id("Login")).Click();
            Thread.Sleep(3000);
            //driver.FindElement(By.Id("globalHeaderNameMink")).Click();
            //driver.FindElement(By.LinkText("Setup")).Click();
            //driver.FindElement(By.Id("Users_font")).Click();
            //driver.FindElement(By.Id("ManageUsers_font")).Click();
            //driver.FindElement(By.LinkText("Full Name")).Click();
            //driver.FindElement(By.XPath("//td[@id='bodyCell']/div[4]/div/div/a[8]/span")).Click();
            //driver.FindElement(By.LinkText("more")).Click();
            //driver.FindElement(By.LinkText("more")).Click();
            //driver.FindElement(By.XPath("(//a[contains(text(),'Login')])[45]")).Click();
            driver.FindElement(By.LinkText("Cases")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("new")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.Id("cas4")).Clear();
            //driver.FindElement(By.Id("cas4")).SendKeys("Customer005");
//            driver.FindElement(By.CssSelector("img.lookupIconOn")).Click();
            Thread.Sleep(3000);
            // ERROR: Caught exception [ERROR: Unsupported command [waitForPopUp | lookup | 30000]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=resultsFrame | ]]
//            driver.FindElement(By.LinkText("Customer005")).Click();
            Thread.Sleep(3000);
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=umps|CS86$00D7E0000008uF4_005b0000005lkv0_02_e4361666-5ce1-49c6-bb96-1ef1a08e9fa9|0| | ]]
            driver.FindElement(By.Id("cas4")).Clear();
            driver.FindElement(By.Id("cas4")).SendKeys("Customer004");
            //driver.FindElement(By.Id("cas3")).Clear();
            //driver.FindElement(By.Id("cas3")).SendKeys("Test002 Contact");
//            driver.FindElement(By.CssSelector("img.lookupIconOn")).Click();
            Thread.Sleep(3000);
            // ERROR: Caught exception [ERROR: Unsupported command [waitForPopUp | lookup | 30000]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=resultsFrame | ]]
//            driver.FindElement(By.LinkText("Test002 Contact")).Click();
            Thread.Sleep(3000);
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=umps|CS86$00D7E0000008uF4_005b0000005lkv0_02_e4361666-5ce1-49c6-bb96-1ef1a08e9fa9|0| | ]]
            driver.FindElement(By.Id("cas3")).Clear();
            driver.FindElement(By.Id("cas3")).SendKeys("Test004 Contact");
//            driver.FindElement(By.Id("CF00Nb0000009IPcp")).Clear();
//            driver.FindElement(By.Id("CF00Nb0000009IPcp")).SendKeys("Level 1");
//            driver.FindElement(By.CssSelector("img.lookupIconOn")).Click();
            Thread.Sleep(3000);
            // ERROR: Caught exception [ERROR: Unsupported command [waitForPopUp | lookup | 30000]]
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=resultsFrame | ]]
//            driver.FindElement(By.LinkText("Level 1")).Click();
            Thread.Sleep(3000);
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | name=umps|CS86$00D7E0000008uF4_005b0000005lkv0_02_e4361666-5ce1-49c6-bb96-1ef1a08e9fa9|0| | ]]
            driver.FindElement(By.Id("CF00Nb0000009IPcp")).Clear();
            driver.FindElement(By.Id("CF00Nb0000009IPcp")).SendKeys("Level 1");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEUx"))).SelectByText("Helpdesk");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWTI"))).SelectByText("Communications Marketplace");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWTJ"))).SelectByText("Communications Marketplace");
            new SelectElement(driver.FindElement(By.Id("cas11"))).SelectByText("Email");
            new SelectElement(driver.FindElement(By.Id("cas5"))).SelectByText("General Information");
            new SelectElement(driver.FindElement(By.Id("00Nb000000AahDz"))).SelectByText("How do I use CCS deals?");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWTU"))).SelectByText("Information Given");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWTV"))).SelectByText("Info no longer required");
            driver.FindElement(By.Id("cas14")).Clear();
            driver.FindElement(By.Id("cas14")).SendKeys("Test Enquiry Email");
            driver.FindElement(By.Id("cas15")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("cas15")).Clear();
            driver.FindElement(By.Id("cas15")).SendKeys("Test");
            driver.FindElement(By.Id("00Nb0000009cWTP")).Clear();
            driver.FindElement(By.Id("00Nb0000009cWTP")).SendKeys("Test");
            driver.FindElement(By.Id("00Nb0000009cWTW")).Clear();
            driver.FindElement(By.Id("00Nb0000009cWTW")).SendKeys("Test");
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();
//            driver.FindElement(By.CssSelector("#efpViews_5007E000005DP2A_option1 > span.optionLabel")).Click();
//            driver.FindElement(By.Id("globalHeaderNameMink")).Click();
//            Thread.Sleep(3000);
//            driver.FindElement(By.LinkText("Logout")).Click();
            Thread.Sleep(3000);
            driver.Quit();
//            driver.Close();
        }
    }
}
