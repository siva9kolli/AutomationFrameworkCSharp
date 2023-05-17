using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomation.Pages
{
	public class LoginPage
	{
		//IWebDriver driver;
		public LoginPage(IWebDriver driver)
		{
            PageFactory.InitElements(driver, this);
            //this.driver = driver;
        }

		[FindsBy(How = How.Name, Using = "username")]
		private IWebElement UserNameInputBox;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement PasswordInputBox;

        [FindsBy(How = How.CssSelector, Using = "input[value='Log In']")]
        private IWebElement LoginButton;


        public void login(string UserName, string Password)
        {
            UserNameInputBox.SendKeys(UserName);
            PasswordInputBox.SendKeys(Password);
            LoginButton.Click();
        }
    }
}

