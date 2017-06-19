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
    public class CreateTechSupportCase
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
            driver.FindElement(By.Id("p3")).Click();
            new SelectElement(driver.FindElement(By.Id("p3"))).SelectByText("Tech Support");
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();
            driver.FindElement(By.Id("cas3")).Clear();
            driver.FindElement(By.Id("cas3")).SendKeys("Test004 Contact");
            driver.FindElement(By.Id("cas4")).Clear();
            driver.FindElement(By.Id("cas4")).SendKeys("Customer004");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASLvR"))).SelectByText("Applications & Infrastructure");
            new SelectElement(driver.FindElement(By.Id("cas11"))).SelectByText("Phone");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASLvS"))).SelectByText("Triage");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASLxF"))).SelectByText("Problem");
            new SelectElement(driver.FindElement(By.Id("cas8"))).SelectByText("Amber");
            new SelectElement(driver.FindElement(By.Id("00Nb000000ASLvQ"))).SelectByText("Applications & Infrastructure");
            Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector("#00Nb000000ASLvQ > option[value=\"Applications & Infrastructure\"]")).Click();
            //Thread.Sleep(2000);
            //new SelectElement(driver.FindElement(By.Id("00Nb000000ASLvO"))).SelectByText("Network");
            //Thread.Sleep(2000);
            driver.FindElement(By.Id("cas14")).Clear();
            driver.FindElement(By.Id("cas14")).SendKeys("Tech Support Case with Email");
            driver.FindElement(By.Id("cas15")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cas15")).Clear();
            driver.FindElement(By.Id("cas15")).SendKeys("Tech Support Case with Email");
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();
            Thread.Sleep(2000);

            driver.Quit();
            //            driver.Close();
        }

    }
}
