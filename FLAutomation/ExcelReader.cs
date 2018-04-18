using Excel = Microsoft.Office.Interop.Excel;


namespace FLAutomation
{
    class ExcelReader
    {
        private Excel.Application xlApp;
        private Excel.Workbook xlWorkBook;
        private Excel.Worksheet xlWorkSheet;
        private Excel.Range range;

        public ExcelReader(string location)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(location, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

        }

        ~ExcelReader()
        {
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
        }


        public int RowCount
        {
            get
            {
                return range.Rows.Count;
            }

        }
            public string GetCellContent(int row,int column)
        {
            return (string)(range.Cells[row, column] as Excel.Range).Value2;
        }
       

    }
}
