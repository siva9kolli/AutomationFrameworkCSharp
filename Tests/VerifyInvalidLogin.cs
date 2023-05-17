using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumAutomation.BaseTest;
using SeleniumAutomation.Pages;

namespace SeleniumAutomation.Tests
{
	[TestClass]
	public class VerifyInvalidLogin:BaseAutomation
	{
		public LoginPage loginPage;

		[TestInitialize]
		public void Initialize()
		{
			loginPage = new LoginPage(driver);
		}

		[TestMethod]
		public void VerifyErrorMessage()
		{

			loginPage.login("Selenium", "Automation");
        }
	}
}

