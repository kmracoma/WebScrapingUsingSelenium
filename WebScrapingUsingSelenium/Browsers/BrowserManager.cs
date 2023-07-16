using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapingUsingSelenium.Core
{
    public class BrowserManager
    {
        public IWebDriver Browser { get; set; }

        public BrowserManager(BrowserType browserType = BrowserType.Chrome) => StartBrowser(browserType);

        public string BrowserName { get; private set; }
        public static BrowserType BrowserType { get; private set; }

        private void StartBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            BrowserFactory factory = new BrowserFactory();
            var browser = factory.Create(browserType, this);
            BrowserName = nameof(browserType);
            BrowserType = browserType;
            browser.InitBrowser();
        }

    }
}
