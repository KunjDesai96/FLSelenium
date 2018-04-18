using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace FLAutomation
{
    public class AddApprover : AutomationBase
    {
        public static void BudegtHolder()
        {
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("txtAuthoriser")).Clear();
                    driver.FindElement(By.Name("txtAuthoriser")).SendKeys("BUDGETHOLDER");
                    driver.FindElement(By.Name("chkMandatory")).Click();
                    driver.FindElement(By.Name("txtSequence")).SendKeys("10");
                    driver.FindElement(By.Name("butSubmit")).Click();      
                }                
            }
        }

        public static void SmallSpend()
        {
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("txtAuthoriser")).Clear();
                    driver.FindElement(By.Name("txtAuthoriser")).SendKeys("SMALLSPEND");
                    driver.FindElement(By.Name("chkMandatory")).Click();
                    driver.FindElement(By.Name("txtSequence")).SendKeys("20");
                    driver.FindElement(By.Name("butSubmit")).Click();
                }
            }           
        }

        public static void MediumSpend()
        {
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("txtAuthoriser")).Clear();
                    driver.FindElement(By.Name("txtAuthoriser")).SendKeys("MEDIUMSPEND");
                    driver.FindElement(By.Name("chkMandatory")).Click();
                    driver.FindElement(By.Name("txtSequence")).SendKeys("30");
                    driver.FindElement(By.Name("butSubmit")).Click();
                }
            }
        }

        public static void LargeSpend()
        {
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("txtAuthoriser")).Clear();
                    driver.FindElement(By.Name("txtAuthoriser")).SendKeys("LARGESPEND");
                    driver.FindElement(By.Name("chkMandatory")).Click();
                    driver.FindElement(By.Name("txtSequence")).SendKeys("40");
                    driver.FindElement(By.Name("butSubmit")).Click();
                }
            }
        }
    }
}
