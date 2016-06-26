using System.Collections.Generic;

namespace CatalystSelenium.Interfaces
{
    public interface IExcelReader
    {
        #region Methods

        string GetCellValue(int row, int column);
        int GetTotalRowCount();
        IDictionary<string, string> GetXcelData();
        int GetTotalColumnCount(int rowIndex);
        string Worksheet { get; set; }

        #endregion
    }
}
