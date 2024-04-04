using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebdriver.ExcelReader;
using SpecFlowProject1.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class HomePagee
    {
        private TestContext _testContext;

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }
        private IWebDriver driver;
        static int counter = 1;
        string xlPath = @"C:\Users\LENOVO\source\repos\SpecFlowProject1\TestData\TestDataExcel.xlsx";
        string userName;
        string passWord;
        private readonly ExcelReaderHelper erh;
        public HomePagee(IWebDriver driver)
        {
            this.driver = driver;
            erh = new ExcelReaderHelper(driver);
        }
        public void Login(int rowNum)
        {
            //string userName = "raktimmalakar2015@gmail.com";
            //string passWord = "raktim";
            By bttnSignIn = By.XPath("//a[@class='header-main__signup login-modal-btn']");
            By userNameField = By.XPath("//input[@placeholder='Username or email']");
            By passwordField = By.XPath("//input[@placeholder='Password']");
            By signinField = By.XPath("//button[text()='Sign In']");
            By randomClick = By.XPath("//div[@class='ant-modal-wrap']");
            Thread.Sleep(2000);
            driver.FindElement(bttnSignIn).Click();
            Thread.Sleep(2000);
            driver.FindElement(userNameField).Click();
            driver.FindElement(userNameField).SendKeys(ExcelOperations.ReadData(rowNum, "UserName"));
            driver.FindElement(passwordField).Click();
            driver.FindElement(passwordField).SendKeys(ExcelOperations.ReadData(rowNum, "Password"));
            driver.FindElement(signinField).Click();
            Thread.Sleep(3000);
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void SearchFieldFunction(string searchData)
        {
            By searchFiledText = By.XPath("//input[@type='text']");
            By seaarchBttn = By.XPath("//span[text()='Search']");
            driver.FindElement(searchFiledText).Click();
            driver.FindElement(searchFiledText).SendKeys(searchData);
            driver.FindElement(seaarchBttn).Click();
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
        }

        public void clickProfileBttn(int rowNum)
        {
            By profileBttn = By.XPath("(//p[@class='profileCard-profile-picture'])[1]");
            Thread.Sleep(2000);
            driver.FindElement(profileBttn).Click();
        }

        public void ClickOnTheLogout()
        {
            By logOutBttn = By.XPath("//span[@class='gfg-icon gfg-icon_logout']");
            Thread.Sleep(2000);
            driver.FindElement(logOutBttn).Click();
        }

        //public void ExcelWork(IWebDriver driver, int rowNum) 
        //{
        //    userName = ExcelOperations.ReadData(rowNum, "UserName");
        //    passWord = ExcelOperations.ReadData(rowNum, "Password");
        //}

    }
}
