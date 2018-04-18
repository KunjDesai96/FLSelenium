using System.Threading;

namespace FLAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomationBase ab = new AutomationBase();
            ab.TestInitialize();
            ExcelReader excelReader = new ExcelReader(@"C:\Users\kzd\Desktop\ExcelExample.xlsx");
            try
            {
                for (int i = 1; i <= excelReader.RowCount; i++)
                {
                    string _code = excelReader.GetCellContent(i, 1);
                    string _desc = excelReader.GetCellContent(i, 2);
                    Thread.Sleep(200);
                    AddApprovalGroups.InsertApprover(_code, _desc);
                }
            }
            finally
            {
                excelReader = null;
            }
            ab.TestCleanup();
        }
    }
}
