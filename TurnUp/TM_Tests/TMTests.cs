using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUp.Pages;

namespace TurnUp.TM_Tests
{
    internal class TMTests
    {
        static void Main(string[] args)
        {
            //Open Chrome Browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login Page Object Initialization and definition
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginSteps(driver);

            //Home Page Object Initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.homePageSteps(driver);

            //Time & Material Management
            TMPage timeMaterialPageObject = new TMPage();
            timeMaterialPageObject.timeMaterialSteps(driver);
            timeMaterialPageObject.editPageSteps(driver);
            timeMaterialPageObject.deletetPageSteps(driver);

        }


    }
}
