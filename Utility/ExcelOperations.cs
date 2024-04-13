//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Core;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Utility
{
    public class ExcelOperations
    {
        //public static bool UseHeaderRow { get; private set; }
        //public static Func<object, ExcelDataTableConfiguration> ConfigureDataTable { get; private set; }

        //        ExtentSparkReporter extent = new ExtentSparkReporter();
        //        ExtentTest test;
        //        public void CreateExtentReport()
        //        {          
        //        }

        private static DataTable ExcelToDataTable(string filename)
        {
            EncodingProvider provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);
            using FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            }); 
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table["Login Data"];
            return resultTable;
            
        }

        public class DataCollection 
        {
            public int rowNumber {  get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }

        }
        static List<DataCollection> dataCol = new List<DataCollection>();
        static int totalRowCount = 0;

        public static int GetTotalRowCount()
        {
            return totalRowCount;
        }

        public static void PopulateInCollection(string fileName) 
        {
            DataTable table = ExcelToDataTable(fileName);
            totalRowCount = table.Rows.Count;
            for (int row = 1; row <= table.Rows.Count; row++) 
            {
                for(int col = 0; col < table.Columns.Count; col++) 
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    dataCol.Add(dtTable);

                }
            }
        }

        public static string ReadData(int rowNumber, string columnName) 
        {
            try 
            {
                string data = dataCol?.FirstOrDefault(x => x.colName == columnName && x.rowNumber == rowNumber)?.colValue;//(from colData in dataCol where colData.colName == columnName && colData.rowNumber == rowNumber select colData.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch (Exception ex) { return null; }
        }
    }
}
