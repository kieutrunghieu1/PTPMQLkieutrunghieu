using System.Data;
using OfficeOpenXml;
namespace NewMVC.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string filePath)
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var dt = new DataTable();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int totalRows = worksheet.Dimension.Rows;
                int totalCols = worksheet.Dimension.Columns;

                
                for (int col = 1; col <= totalCols; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Text);
                }
                for (int row = 2; row <= totalRows; row++)
                {
                    var newRow = dt.NewRow();
                    for (int col = 1; col <= totalCols; col++)
                    {
                        newRow[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    dt.Rows.Add(newRow);
                }
            }

            return dt;
        }
    }
}
