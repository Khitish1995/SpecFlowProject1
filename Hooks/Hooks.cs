using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using SpecFlowProject1.Configuration;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        public IWebDriver driver;
        private readonly IObjectContainer _container;
        public static ClassConfigSetting config;
        static string configsettingpath = System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar
            + "Configuration/configSetting.json";
        //private static ScenarioContext _scenarioContext;
        //private static ExtentReports _extentReports;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("mytag")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Empty Feature and step");
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            config = new ClassConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configsettingpath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            if (Hooks.config.BrowserType.ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if(Hooks.config.BrowserType.ToLower() == "ie")
            {
                driver = new InternetExplorerDriver();
            }
            else if (Hooks.config.BrowserType.ToLower() == "edge")
            {
                driver = new EdgeDriver();
            }
            //driver.Navigate().GoToUrl(GetgeeksURL());
            driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
           var driver = _container.Resolve<IWebDriver>(); 
            if(driver != null) 
            {
                driver.Quit();
            }
        }
    }
}