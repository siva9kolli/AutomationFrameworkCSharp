using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation.BaseTest
{
	
	public class BaseAutomation
	{
        public IWebDriver driver;

        [TestInitialize]
		public void OpenApplication()
		{
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
        }

        [TestCleanup]
        public void CleanSession()
        {
            driver.Quit();
        }
    }
}

