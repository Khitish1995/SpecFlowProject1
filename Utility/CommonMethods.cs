using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Utility
{
    public class CommonMethods
    {
        private static IWebDriver driver;
        public CommonMethods(IWebDriver driver) 
        {
            CommonMethods.driver = driver;
        }

        public static void waitForLoad(IWebElement locator) 
        {
            TimeSpan time = TimeSpan.FromSeconds(5);
            WebDriverWait wait = new WebDriverWait(driver, time);
            wait.Until(d => locator.Displayed);
        }
    }
}
