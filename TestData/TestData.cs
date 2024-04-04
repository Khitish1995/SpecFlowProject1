//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SeleniumWebdriver.ComponentHelper;
//using SeleniumWebdriver.ExcelReader;
//using SeleniumWebdriver.PageObject;
//using SeleniumWebdriver.Settings;
//using xl = SeleniumWebdriver.ExcelReader.ExcelReaderHelper;

//namespace SpecFlowProject1.TestData
//{


//    public class TestData
//    {
//        private NUnit.Framework.TestContext _testContext;

//        public NUnit.Framework.TestContext TestContext
//        {
//            get { return _testContext; }
//            set { _testContext = value; }
//        }
//        [NUnit.Framework.CategoryAttribute("DataSource:TestData.csv")]
//        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\downloads\ExcelData.xlsx;", "TestExcelData$", DataAccessMethod.Sequential)]
//        //[DeploymentItem(@"DataDriven\TestDataFiles", @"DataDriven\TestDataFiles")]
//        public void TestBug()
//        {
//            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
//            HomePage hpPage = new HomePage(driver);
//            LoginPage loginPage = hpPage.NavigateToLogin();
//            var ePage = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
//            var bugPage = ePage.NavigateToDetail();
//            bugPage.SelectFromCombo(TestContext.DataRow["Severity"].ToString(), TestContext.DataRow["HardWare"].ToString(), TestContext.DataRow["OS"].ToString());
//            bugPage.TypeIn(TestContext.DataRow["Summary"].ToString(), TestContext.DataRow["Desc"].ToString());
//            bugPage.ClickSubmit();
//            bugPage.Logout();
//            Thread.Sleep(5000);
//        }


//        public void TestBugDdF()
//        {
//            string xlPath = @"C:\downloads\ExcelData.xlsx";
//            //NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
//            //HomePage hpPage = new HomePage(ObjectRepository.Driver);
//            //LoginPage loginPage = hpPage.NavigateToLogin();
//            var ePage = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
//            var bugPage = ePage.NavigateToDetail();
//            //bugPage.SelectFromCombo(TestContext.DataRow["Severity"].ToString(), TestContext.DataRow["HardWare"].ToString(), TestContext.DataRow["OS"].ToString());
//            //bugPage.TypeIn(TestContext.DataRow["Summary"].ToString(), TestContext.DataRow["Desc"].ToString());
//            bugPage.SelectFromCombo(xl.GetCellData(xlPath, "TestExcelData", 1, 0).ToString(), xl.GetCellData(xlPath, "TestExcelData", 1, 1).ToString(), ExcelReaderHelper.GetCellData(xlPath, "TestExcelData", 1, 2).ToString());
//            bugPage.TypeIn(ExcelReaderHelper.GetCellData(xlPath, "TestExcelData", 1, 3).ToString(), ExcelReaderHelper.GetCellData(xlPath, "TestExcelData", 1, 4).ToString());
//            bugPage.ClickSubmit();
//            bugPage.Logout();
//            Thread.Sleep(5000);
//        }


////        public virtual void TestInitialize()

////        {

////        }

////        [NUnit.Framework.TearDownAttribute()]

////        public virtual void TestTearDown()

////        {
////            testRunner.OnScenarioEnd();
////        }



////        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)

////        {
////            testRunner.OnScenarioInitialize(scenarioInfo);
////            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
////        }



////        public virtual void ScenarioStart()

////        {
////            testRunner.OnScenarioStart();
////        }



////        public virtual void ScenarioCleanup()

////        {
////            testRunner.CollectScenarioErrors();
////        }

////        [NUnit.Framework.TestAttribute()]
////        [NUnit.Framework.DescriptionAttribute("Add two numbers")]
////        [NUnit.Framework.CategoryAttribute("DataSource:TestData.csv")]
////        [NUnit.Framework.CategoryAttribute("DataField:Loginfield=UserName")]
////        [NUnit.Framework.CategoryAttribute("DataField:Passwordfield=Password")]
////        [NUnit.Framework.TestCaseAttribute("raktimmalakar2015@gmail.com", "raktim", null)]
////        [NUnit.Framework.TestCaseAttribute("khitishkumar", "little", null)]

////        public virtual void AddTwoNumbers(string Loginfield, string Passwordfield, string[] exampleTags)

////        {

////            string[] @__tags = new string[] {

////                    "DataSource:TestData.csv",

////                    "DataField:Loginfield=UserName",

////                    "DataField:Passwordfield=Password"};

////            if ((exampleTags != null))

////            {

////                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));

////            }

////            string[] tagsOfScenario = @__tags;

////            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();

////            argumentsOfScenario.Add("Loginfield", Loginfield);

////            argumentsOfScenario.Add("Passwordfield", Passwordfield);

////            //argumentsOfScenario.Add("sum", sum);

////            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);

////#line 4

////            this.ScenarioInitialize(scenarioInfo);

////#line hidden

////            bool isScenarioIgnored = default(bool);

////            bool isFeatureIgnored = default(bool);

////            if ((tagsOfScenario != null))

////            {

////                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();

////            }

////            if ((this._featureTags != null))

////            {

////                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();

////            }

////            if ((isScenarioIgnored || isFeatureIgnored))

////            {

////                testRunner.SkipScenario();

////            }

////            else

////            {

////                this.ScenarioStart();

////#line 5

////                testRunner.Given(string.Format("add the numbers {0} and {1}", Loginfield, Passwordfield), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
////#line hidden
////#line 6
////                //testRunner.Then(string.Format("the result should be {0}", sum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
////#line hidden
////            }
////            this.ScenarioCleanup();
////        }
//    }
//}

