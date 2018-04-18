using OpenQA.Selenium;
using System.Threading;

namespace FLAutomation
{
    public class AddBand : AutomationBase
    {
        MaintainCostApproves costApproves = new MaintainCostApproves();
        public static void AddBand1()
        {
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("500");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
           AddApprover.BudegtHolder();
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            Thread.Sleep(200);
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("1");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboSendTo")).SendKeys("1");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("butBack")).Click();
                }
            }
            AddBand2();

        }
        public static void AddBand2()
        {
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("10000");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
            AddApprover.BudegtHolder();
            Thread.Sleep(200);
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                }
            }
            AddApprover.SmallSpend();
            Thread.Sleep(200);
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("2");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboSendTo")).SendKeys("2");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("butBack")).Click();
                }
            }
            AddBand3();
        }
        public static void AddBand3()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("20000");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
            AddApprover.BudegtHolder();
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            Thread.Sleep(200);
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                }
            }
            AddApprover.SmallSpend();
            Thread.Sleep(200);
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                }
            }
            AddApprover.MediumSpend();
            Thread.Sleep(200);
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("3");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboSendTo")).SendKeys("3");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("butBack")).Click();
                }
            }
            AddBand4();
        }
        public static void AddBand4()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("99999999");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
            AddApprover.BudegtHolder();
            Thread.Sleep(200);
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = driver.WindowHandles;
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                }
            }
            Thread.Sleep(200);
            AddApprover.SmallSpend();
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                }
            }
            Thread.Sleep(200);
            AddApprover.MediumSpend();
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                }
            }
            Thread.Sleep(200);
            AddApprover.LargeSpend();
            Thread.Sleep(200);
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("4");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("cboSendTo")).SendKeys("4");
                    driver.FindElement(By.Name("butSubmit")).Click();
                    driver.FindElement(By.Name("butBack")).Click();
                }
            }
            MaintainCostApproves.ApprovalCosts();
        }
    }
}
