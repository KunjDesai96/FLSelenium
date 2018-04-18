using OpenQA.Selenium;
using System.Threading;

namespace FLAutomation
{
    class MaintainCostApproves : AutomationBase
    {
        public static void ApprovalCosts()
        {
            driver.FindElement(By.Name("butMaintain")).Click();
            driver.FindElement(By.Name("txt1Col1")).SendKeys(AddApprovalGroups.Code);
            driver.FindElement(By.Name("txt2Col1")).SendKeys(AddApprovalGroups.Code);
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            //AddApprovalGroups.InsertApprover(AddApprovalGroups.Code, AddApprovalGroups.Description);
        }
    }
}
