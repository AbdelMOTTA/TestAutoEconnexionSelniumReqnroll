using EconnexionTestAuto.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EconnexionTestAuto.Utils
{
    public static class AutomationHelper
    {
        public static void Retry(Action action, int retries, int delayMs)
        {
            for (int i = 0; i < retries; i++)
            {
                try
                {
                    action();
                    return;
                }
                catch
                {
                    if (i == retries - 1)
                        throw;

                    Thread.Sleep(delayMs);
                }
            }
        }
        /* 
        AutomationHelper.Retry(() =>
            {
        _driver.FindElement(By.Id("login")).Click();
        }, 3, 1000);

        */

        public static IWebElement WaitForElement(IWebDriver driver, By locator, int timeoutSec)
        {
            var wait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(timeoutSec),
                PollingInterval = TimeSpan.FromMilliseconds(500)
            };

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return wait.Until(d => d.FindElement(locator));
        } // AutomationHelper.WaitForElement(_context.Driver, By.Id("login"), 10).Click();

    }
    


}



