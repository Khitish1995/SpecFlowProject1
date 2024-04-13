using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
//using AventStack.ExtentReports.Reporter.Config;
using AventStack.ExtentReports.Reporter.Configuration;

namespace SpecFlowProject1.Utility;

public class ExtentReport
{
    public static ExtentReports _extentReports;
    public static ExtentTest _feature;
    public static ExtentTest _scenario;

    public static String dir = AppDomain.CurrentDomain.BaseDirectory;
    public static String testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults" /* + DateTime.Now.ToString("ddMMyyyyHHmmss") */);

    public static void ExtentReportInit()
    {
        var htmlReporter = new ExtentHtmlReporter(testResultPath);
        htmlReporter.Config.ReportName = "Automation Status Report";
        htmlReporter.Config.DocumentTitle = "Automation Status Report";
        htmlReporter.Config.Theme = Theme.Standard;
        htmlReporter.Start();

        _extentReports = new ExtentReports();
        _extentReports.AttachReporter(htmlReporter);
        _extentReports.AddSystemInfo("Application", "GeekForGeeks");
        _extentReports.AddSystemInfo("Browser", "Chrome");
        //_extentReports.AddSystemInfo("OS", "Windows");
    }

    public static void ExtentReportTearDown()
    {
        _extentReports.Flush();
    }

    public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
    {
        ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
        Screenshot screenshot = takesScreenshot.GetScreenshot();
        string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
        screenshot.SaveAsFile(screenshotLocation /*, ImageFormat.Png */);
        return screenshotLocation;
    }


}


