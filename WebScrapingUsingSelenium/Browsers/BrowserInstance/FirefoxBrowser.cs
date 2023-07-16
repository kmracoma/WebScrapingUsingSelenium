using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace WebScrapingUsingSelenium.Core.BrowserInstance
{
    public class FirefoxBrowser : Browser
    {
        public FirefoxBrowser(BrowserManager manager) : base(manager)
        {
        }

        public override void InitBrowser()
        {
            manager.Browser = new FirefoxDriver();
        }
    }
}
