using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScrapingUsingSelenium.Core;

namespace WebScrapingUsingSelenium
{
    public class WebScrapingSelenium
    {
        static void Main()
        {
            BrowserManager manager = new BrowserManager(BrowserType.Firefox);
            IWebDriver driver = manager.Browser;
            driver.Navigate().GoToUrl("https://google.com");
            Console.WriteLine("Accessing " + driver.Url + " from browser: " + BrowserType.Firefox);
        }
    }
}
