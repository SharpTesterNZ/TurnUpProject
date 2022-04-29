using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUp.Pages;

namespace TurnUp.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void LoginFunction()
        {
            //open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //
            HomePage homePageObj = new HomePage();
            homePageObj.homePageSteps(driver);

            //如果在这里设置了 login page。三次测试只有一次登录，
            //但是如果是在这里设置homepage，也就是说只做一次homepage initialize，但是每次测试都需要进入homepage，因为这是并行测试，也就是同时测试
            //这样需要每一个测试都是基于homepage 进行操作。所以就需要将homepage 单独写到每个方法里面去。
        }
        [OneTimeTearDown]
        public void closeTestRun()
        {
            //driver.Quit();
        }
    }
}
