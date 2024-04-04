using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Pages;
using SpecFlowProject1.Utility;
using System.Runtime.InteropServices;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private readonly HomePagee hp;
        private IWebDriver driver;
        private string geeksURL = "https://www.geeksforgeeks.org/";
        public static int i;
        public LoginStepDefinitions(IWebDriver driver) 
        {
            this.driver = driver;
            hp = new HomePagee(driver);
        }
        
        public string GetgeeksURL() 
        {
            return geeksURL;
        }
        [Given(@"User lands on the homepage to login")]
        public void GivenUserLandsonthehomepagetoLogin()
        {
            driver.Navigate().GoToUrl(GetgeeksURL());
        }

        [When(@"User enters ID and Password to login")]
        public void WhenUserEntersIDAndPasswordToLogin()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\LENOVO\source\repos\SpecFlowProject1\TestData\TestDataExcel.xlsx");
            for (i = 1; i <= ExcelOperations.GetTotalRowCount();i++)
            {
                hp.Login(i);
                //i++;
            //Console.WriteLine(i);
                break;
            }
        }

        [Then(@"User Search for the (.*) in the search field and select the required data")]
        public void GivenUserSearchForTheSearchDataInTheSearchFieldAndSelectTheRequiredData(string searchData)
        {
            hp.SearchFieldFunction(searchData);
        }

        [When(@"User click on the profile")]
        public void WhenUserClikOnTheProfile()
        { 
            hp.clickProfileBttn(i);
        }

        [Then(@"User click on the Logout")]
        public void ThenUserClickOnTheLogout()
        {
            hp.ClickOnTheLogout();
        }

        //[When(@"User enters <Loginfield> and <Passwordfield> to login")]
        //public void WhenUserEntersLoginfieldAndDataFieldToLogin(string UserName, string Password)
        //{
        //    hp.Login(UserName, Password);
        //}

    }
}
