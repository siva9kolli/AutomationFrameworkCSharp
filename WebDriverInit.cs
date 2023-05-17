using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace SeleniumAutomation
{
    public enum BrowserType
    {
        Chrome,
        FireFox,
        Safari,
        Edge
    }

    //public class WebDriverInit
    //{
    //    public IWebDriver GetWebDriver(BrowserType browserType)
    //    {

    //    }

    //    private dynamic GetBrowserOptions(BrowserType browserType)
    //    {
    //        switch (browserType)
    //        {
    //            case BrowserType.Chrome:
    //                return new ChromeOptions();
    //            case BrowserType.FireFox:
    //                return new FirefoxOptions();
    //            case BrowserType.Safari:
    //                return new SafariOptions();
    //            case BrowserType.Edge:
    //                return new EdgeOptions();
    //            default:
    //                Console.WriteLine("No BrowserOption");
    //        }
    //    }
    //}
}
