using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalystSelenium.Interfaces;
using OfficeOpenXml;

namespace CatalystSelenium.ExcelUtility
{
    public class ExcelReaderHelper : IExcelReader,IDisposable
    {
        #region Constructor

        public ExcelReaderHelper(string xlPath, string sheetName) : this(new FileInfo(xlPath), sheetName) { }

        public ExcelReaderHelper(FileInfo xlInfo, string sheetName)
        {
            _package = new ExcelPackage(xlInfo);
            Worksheet = sheetName;
        }

        #endregion

        #region Property

        public string Worksheet
        {
            get { return _sheetName; }
            set { _sheetName = value; }
        }

        #endregion

        #region Feilds

        private readonly ExcelPackage _package;
        private string _sheetName;

        #endregion

        #region Private

        private ExcelWorksheet GetSheet()
        {
            return _package.Workbook.Worksheets[_sheetName];
        }

        #endregion

        #region Public

       public string GetCellValue(int row, int column)
       {
           return GetSheet().Cells[row, column].Text;
       }

        public int GetTotalRowCount()
        {
            var count = 1;

            while (!GetCellValue(count, 1).Equals(string.Empty))
            {
                count++;
            }

            return count;
        }

        public int GetTotalColumnCount(int rowIndex)
        {
            var count = 1;

            while (!GetCellValue(rowIndex, count).Equals(string.Empty))
            {
                count++;
            }

            return count;
        }

        public IDictionary<string, string> GetXcelData()
        {
            var totalColumn = GetTotalColumnCount(1);
            var data = new Dictionary<string,string>();

            for (var i = 1; i < totalColumn; i++)
            {
                data.Add(GetCellValue(1, i), GetCellValue(2, i));
            }

            return data;
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            _package.Dispose();
        }

        #endregion

      
    }
}
