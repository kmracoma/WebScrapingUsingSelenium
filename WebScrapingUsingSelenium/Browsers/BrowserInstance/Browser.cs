using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapingUsingSelenium.Core.BrowserInstance
{
    public abstract class Browser
    {
        public BrowserManager manager;

        public Browser(BrowserManager manager)
        {
            this.manager = manager;
        }

        public abstract void InitBrowser();
    }
}
