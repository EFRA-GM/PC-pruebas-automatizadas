using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetclinicFront.TestsAutomation.Handlers
{
    public class WaitHandler
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(drv => drv.FindElement(locator));
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
