
//using ExcelDataReader;
//using OpenQA.Selenium;
//using System.Data;
//using System.Linq;

//namespace seleniumwebdriver.excelreader
//{
//    public class excelreaderhelper
//    {
//        public IWebDriver driver;
//        public excelreaderhelper(IWebDriver driver) 
//        {
//            this.driver = driver;
//        }
//        public void TestReadExcel()
//        {
//            FileStream stream = new FileStream(@"C:\Users\LENOVO\source\repos\SpecFlowProject1\TestData\TestDataExcel.xlsx", FileMode.Open, FileAccess.Read);
//            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
//            DataTable table = reader.AsDataSet().Tables["Login Data"];
//            for (int i = 0; i < table.Rows.Count; i++)
//            {
//                var col = table.Rows[i];
//                for (int j = 0; j < col.ItemArray.Length; j++)
//                {
//                    Console.Write("Data : {0}", col.ItemArray[j]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using OpenQA.Selenium;

namespace SeleniumWebdriver.ExcelReader
{
    public class ExcelReaderHelper
    {
        //private static IDictionary<string, IExcelDataReader> _cache;
        //private static FileStream stream;
        //private static IExcelDataReader reader;
        private IWebDriver driver;
        static int counter = 1; 

        //public ExcelReaderHelper(IWebDriver driver)
        //{
        //    _cache = new Dictionary<string, IExcelDataReader>();
        //    this.driver = driver;
        //}

        //private static IExcelDataReader GetExcelReader(string xlPath, string sheetName)
        //{
        //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //    if (_cache.ContainsKey(sheetName))
        //    {
        //        reader = _cache[sheetName];
        //    }
        //    else
        //    {
        //        stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
        //        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        //        _cache.Add(sheetName, reader);
        //    }
        //    return reader;
        //}

        //public static int GetTotalRows(string xlPath, string sheetName)
        //{
        //    IExcelDataReader _reader = GetExcelReader(xlPath, sheetName);
        //    return _reader.AsDataSet().Tables[sheetName].Rows.Count;
        //}

        //public static object GetCellData(string xlPath, string sheetName, int row, int column)
        //{

        //    IExcelDataReader _reader = GetExcelReader(xlPath, sheetName);
        //    DataTable table = _reader.AsDataSet().Tables[sheetName];
        //    return GetData(table.Rows[row][column].GetType(), table.Rows[row][column]);
        //}

        //private static object GetData(Type type, object data)
        //{
        //    switch (type.Name)
        //    {
        //        case "String":
        //            return data.ToString();
        //        case "Double":
        //            return Convert.ToDouble(data);
        //        case "DateTime":
        //            return Convert.ToDateTime(data);
        //        default:
        //            return data.ToString();
        //    }
        //}
        public ExcelReaderHelper(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}