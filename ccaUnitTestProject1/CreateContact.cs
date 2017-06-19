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
    public class CreateContact
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
            //Log in as Kerris Hankin
            Thread.Sleep(5000);            
            //driver.FindElement(By.Id("globalHeaderNameMink")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("Setup")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector("img.setupImage")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.Id("ManageUsers_font")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.XPath("//td[@id='bodyCell']/div[4]/div/div/a[8]/span")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.XPath("(//a[contains(text(),'Login')])[7]")).Click();
            //Thread.Sleep(3000);
            ////Go to Contacts tab
            //driver.FindElement(By.XPath("(//a[contains(text(),'Login')])[7]")).Click();
            //Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Contacts")).Click();
            Thread.Sleep(3000);
            //Create a New Contact
            driver.FindElement(By.Name("new")).Click();
            Thread.Sleep(3000);
            //Contact Edit Page is loaded and then...


            new SelectElement(driver.FindElement(By.Id("name_salutationcon2"))).SelectByText("Mr.");
            driver.FindElement(By.Id("name_firstcon2")).Clear();
            driver.FindElement(By.Id("name_firstcon2")).SendKeys("Test010");


            driver.FindElement(By.Id("name_lastcon2")).Clear();
            driver.FindElement(By.Id("name_lastcon2")).SendKeys("Contact");

            
            driver.FindElement(By.Id("con5")).Clear();
            driver.FindElement(By.Id("con5")).SendKeys("Help Desk Agent");


            driver.FindElement(By.Id("con6")).Clear();
            driver.FindElement(By.Id("con6")).SendKeys("CSC");
            driver.FindElement(By.Id("00Nb0000009chgg")).Click();
            driver.FindElement(By.Id("00Nb0000009chgg")).Click();

            new SelectElement(driver.FindElement(By.Id("00Nb000000ASEWi"))).SelectByText("General Contact");
            driver.FindElement(By.Id("00Nb0000009IaDp")).Clear();
            driver.FindElement(By.Id("00Nb0000009IaDp")).SendKeys("000001");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWU5"))).SelectByText("--None--");
            new SelectElement(driver.FindElement(By.Id("00Nb0000009cWU5"))).SelectByText("Active");
            driver.FindElement(By.Id("con10")).Clear();
            driver.FindElement(By.Id("con10")).SendKeys("01225895988");
            driver.FindElement(By.Id("00Nb0000009ckUW")).Clear();
            driver.FindElement(By.Id("00Nb0000009ckUW")).SendKeys("0001");
            driver.FindElement(By.Id("con12")).Clear();
            driver.FindElement(By.Id("con12")).SendKeys("07941373315");
            driver.FindElement(By.Id("con15")).Clear();
            driver.FindElement(By.Id("con15")).SendKeys("Test010Contact@mailinator.com");
            driver.FindElement(By.Id("00Nb000000ASEWf")).Clear();
            driver.FindElement(By.Id("00Nb000000ASEWf")).SendKeys("Test010Contact@mailinator.com");
            driver.FindElement(By.Id("00Nb000000AaUF6")).Click();
            driver.FindElement(By.Id("00Nb000000AaUF6")).Click();
            driver.FindElement(By.Id("con4")).Clear();
            driver.FindElement(By.Id("con4")).SendKeys("Customer004");
            new SelectElement(driver.FindElement(By.Id("con19country"))).SelectByText("England");
            driver.FindElement(By.Id("con19street")).Clear();
            driver.FindElement(By.Id("con19street")).SendKeys("10 Queen Street");
            driver.FindElement(By.Id("con19city")).Clear();
            driver.FindElement(By.Id("con19city")).SendKeys("Bristol");
            new SelectElement(driver.FindElement(By.Id("con19state"))).SelectByText("Avon");
            driver.FindElement(By.Id("con19zip")).Clear();
            driver.FindElement(By.Id("con19zip")).SendKeys("BS158BA");
            //new SelectElement(driver.FindElement(By.Id("00Nb0000009cWU1"))).SelectByText("Email");
            driver.FindElement(By.CssSelector("#bottomButtonRow > input[name=\"save\"]")).Click();
            //driver.FindElement(By.CssSelector("span.optionLabel")).Click();
            //driver.FindElement(By.CssSelector("#efpViews_0037E00000SnHYv_option1 > span.optionLabel")).Click();
            //Assert.AreEqual("Contact Information", driver.FindElement(By.CssSelector("h3")).Text);
            //Assert.AreEqual("Title/First Name", driver.FindElement(By.CssSelector("label")).Text);
            //Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.CssSelector("td.labelCol.requiredInput > label")).Text, "^exact:[\\s\\S]*Last Name$"));
            //Assert.AreEqual("*\n Last Name", driver.FindElement(By.CssSelector("td.labelCol.requiredInput > label")).Text);
            //Assert.AreEqual("Additional Email", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[6]/td[3]/label")).Text);
            //Assert.AreEqual("Contact Type", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[6]/td/label")).Text);
            //Assert.AreEqual("Job Title", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[3]/td/label")).Text);
            //Assert.AreEqual("Department", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[4]/td/label")).Text);
            //Assert.AreEqual("Status", driver.FindElement(By.XPath("//span[@id='Contact.00Nb0000009cWU5-_help']/label")).Text);
            //Assert.AreEqual("Telephone", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[2]/td[3]/label")).Text);
            //Assert.AreEqual("extension", driver.FindElement(By.XPath("//span[@id='Contact.00Nb0000009ckUW-_help']/label")).Text);
            //Assert.AreEqual("Mobile", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[4]/td[3]/label")).Text);
            //Assert.AreEqual("Email", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[5]/td[3]/label")).Text);
            //Assert.AreEqual("User Research Participant", driver.FindElement(By.XPath("//span[@id='Contact.00Nb000000AaUF6-_help']/label")).Text);
            //Assert.AreEqual("Organisation Information:", driver.FindElement(By.CssSelector("#head_2_ep > h3")).Text);
            //Assert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[5]/table/tbody/tr/td/label")).Text, "^exact:[\\s\\S]*Organisation Name$"));
            //Assert.AreEqual("Address Information:", driver.FindElement(By.CssSelector("#head_3_ep > h3")).Text);
            //Assert.AreEqual("Country", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[7]/table/tbody/tr/td/label")).Text);
            //Assert.AreEqual("Additional Email", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[6]/td[3]/label")).Text);
            //Assert.AreEqual("Additional Email", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[6]/td[3]/label")).Text);
            //Assert.AreEqual("Address Line", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[7]/table/tbody/tr[2]/td/label")).Text);
            //Assert.AreEqual("Town/City", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[7]/table/tbody/tr[3]/td/label")).Text);
            //Assert.AreEqual("County", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[7]/table/tbody/tr[4]/td/label")).Text);
            //Assert.AreEqual("Postcode", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[7]/table/tbody/tr[5]/td/label")).Text);
            //Assert.AreEqual("Mr. Test002 Contact", driver.FindElement(By.CssSelector("h2.topName")).Text);
            //Assert.AreEqual("Reports To", driver.FindElement(By.XPath("//div[@id='ep']/div[2]/div[3]/table/tbody/tr[7]/td/label")).Text);
            //Assert.AreEqual("Marketing Campaign Reference", driver.FindElement(By.XPath("//span[@id='Contact.00Nb0000009IaDp-_help']/label")).Text);
            //Assert.AreEqual("Additional Information:", driver.FindElement(By.CssSelector("#head_4_ep > h3")).Text);
            //Assert.AreEqual("Origin", driver.FindElement(By.XPath("//span[@id='Contact.00Nb0000009cWU1-_help']/label")).Text);
            //Assert.AreEqual("Notes", driver.FindElement(By.XPath("//span[@id='Contact.00Nb0000009cWTz-_help']/label")).Text);
            
            driver.Close();
        }
    }
}
