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
    public class CreateProcurementCase
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
            driver.FindElement(By.LinkText("Cases")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("new")).Click();
            Thread.Sleep(3000);
            new SelectElement(driver.FindElement(By.Id("p3"))).SelectByText("Procurement");
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();
            driver.FindElement(By.Id("cas4")).Clear();
            driver.FindElement(By.Id("cas4")).SendKeys("Customer004");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEVc"))).SelectByText("Open Market");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWTU"))).SelectByText("Information Given");
            driver.FindElement(By.Id("00Nb000000ASEWL")).Clear();
            driver.FindElement(By.Id("00Nb000000ASEWL")).SendKeys("1");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEWO"))).SelectByText("Below £100k");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEW8"))).SelectByText("Important");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEW3"))).SelectByText("Intermediate");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEW4"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEZp"))).SelectByText("Buying Team");
            driver.FindElement(By.Id("CF00Nb000000ASEUK")).Clear();
            driver.FindElement(By.Id("CF00Nb000000ASEUK")).SendKeys("Tomes");
            new SelectElement(driver.FindElement(By.Id("cas11"))).SelectByText("Email");
            driver.FindElement(By.Id("cas14")).Clear();
            driver.FindElement(By.Id("cas14")).SendKeys("Case With Email");
            driver.FindElement(By.Id("cas15")).Click();
            driver.FindElement(By.Id("cas15")).Clear();
            driver.FindElement(By.Id("cas15")).SendKeys("CreateProcurementCase");
            driver.FindElement(By.Id("cas15")).Click();
            driver.FindElement(By.Id("cas15")).Clear();
            driver.FindElement(By.Id("cas15")).SendKeys("Procurement Case With Contact Email");
            driver.FindElement(By.Id("cas3")).Clear();
            driver.FindElement(By.Id("cas3")).SendKeys("Test004 Contact");
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();

            driver.Quit();
            //            driver.Close();
        }
    }
}
