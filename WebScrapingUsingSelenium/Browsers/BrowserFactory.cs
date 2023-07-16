using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScrapingUsingSelenium.Core.BrowserInstance;

namespace WebScrapingUsingSelenium.Core
{
    public class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public Browser Create(BrowserType browserType, BrowserManager browserManager)
        {
            return (Browser)Activator.CreateInstance(Type.GetType($"WebScrapingUsingSelenium.Core.BrowserInstance.{browserType}Browser"), new object[] { browserManager });
        }
    }
}
