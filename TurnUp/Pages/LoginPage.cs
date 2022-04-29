using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
//using TurnUp.TM_Tests;
using TurnUp.Utilities;

namespace TurnUp.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
           
            driver.Manage().Window.Maximize();
            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                //identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                //identify password textbox and enter valid password

                //click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal login page does not work", ex.Message);
                throw;
            }

            // 当我们做测试的时候，整个scenario 是用THEN 来做assertion 的，但是在用到的每个页面上，
            // 我们要知道是否登陆成功，某种意义上来讲不是assertion，但是需要一种方法来判断
            // 所以我们就是需要try catch
            

        }
    }
}
