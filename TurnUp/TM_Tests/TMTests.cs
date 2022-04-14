using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUp.Pages;
using TurnUp.Utilities;

namespace TurnUp.TM_Tests
{   
    [TestFixture]

    internal class TMTests : CommonDriver
    {
      
            [SetUp]
            public void LoginFunction()
            {
                //Open Chrome Browser
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                //Login Page Object Initialization and definition
                LoginPage loginPageObject = new LoginPage();
                loginPageObject.LoginSteps(driver);

                //Home Page Object Initialization and definition
                HomePage homePageObject = new HomePage();
                homePageObject.homePageSteps(driver);
            }

            [Test]
            public void CreateTM_Test()
            {
                TMPage timeMaterialPageObject = new TMPage();
                timeMaterialPageObject.timeMaterialSteps(driver);
            }
            [Test]
            public void EditTM_Test()
            {
                TMPage timeMaterialPageObject = new TMPage();
                timeMaterialPageObject.editPageSteps(driver);
            }
            [Test]
            public void DeleteTM_Test()
            {
                TMPage timeMaterialPageObject = new TMPage();
                timeMaterialPageObject.deletetPageSteps(driver);
            }
            
            [TearDown]
            public void CloseTestRun()
            {

            }

         

        }

}
