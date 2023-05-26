using System;
using OpenQA.Selenium;
using SeleniumAutomation.CommonMethods;
using SeleniumExtras.PageObjects;

namespace SeleniumAutomation.Pages
{
	public class LoginPage
	{
        public SeActions actions;

		public LoginPage(IWebDriver driver)
		{
            PageFactory.InitElements(driver, this);
            actions = new SeActions();
        }

		[FindsBy(How = How.Name, Using = "username")]
		private IWebElement UserNameInputBox;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement PasswordInputBox;

        [FindsBy(How = How.CssSelector, Using = "input[value='Log In']")]
        private IWebElement LoginButton;


        public void login(string UserName, string Password)
        {
            actions.TypeValue(UserNameInputBox, UserName);
            actions.TypeValue(PasswordInputBox, Password);
            actions.ClickOnElement(LoginButton);
        }
    }
}

