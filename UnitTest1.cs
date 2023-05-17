using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        SoftAssertions softAssertions;

        [TestInitialize]
        public void StartSession()
        {
            softAssertions = new SoftAssertions();
            driver = new ChromeDriver();
            Console.WriteLine("Navigating to Parabank app.");
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
        }

        [TestCleanup]
        public void CleanSession()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod1()
        {
          

            driver.FindElement(By.Name("username")).SendKeys("Selenium");
            Console.WriteLine("Enter UserName");
            driver.FindElement(By.Name("password")).SendKeys("Automation");
            Console.WriteLine("Enter Password");


            IList<IWebElement> elems = driver.FindElements(By.XPath("//*[@id='headerPanel']/ul/li/a"));
            Assert.AreEqual(8, elems.Count);

            driver.FindElement(By.CssSelector("input[value='Log In']")).Click();
;
            string accountOverviewTitle = driver.FindElement(By.CssSelector(".title")).Text;
            try
            {
                Assert.AreEqual("Accounts Overview", accountOverviewTitle);
            }
            catch(Exception e)
            {
                Assert.AreEqual("Error!", accountOverviewTitle);
            }

            softAssertions.AddTrue("Passing bool Add assertion", true);
            softAssertions.AddTrue("Passing bool Add assertion", false);
            Assert.AreEqual("Test", "Test");
            Assert.IsFalse(false);
            Assert.IsTrue(true);
            Assert.AreSame("Test", "Test");

            IList<string> ilist = new List<string>();
            
            ilist.Add("Motivity");
            ilist.Add("Jnit");
            foreach (string list in ilist)
            {
                Console.WriteLine(list);
            }

            IList<string> jlist = new List<string>();
            
            jlist.Add("Motivity");
            jlist.Add("Jnit");
            foreach (string list in jlist)
            {
                Console.WriteLine(list);
            }

            Assert.IsTrue(ilist.SequenceEqual(jlist));
            

        }
    }
}
