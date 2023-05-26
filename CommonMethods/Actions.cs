using System;
using OpenQA.Selenium;

namespace SeleniumAutomation.CommonMethods
{
	public class SeActions
	{
		public void ClickOnElement(IWebElement element)
		{
			element.Click();
		}

		public void TypeValue(IWebElement element, string data)
		{
			element.SendKeys(data);
		}
	}
}

