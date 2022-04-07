using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TurnUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify password textbox and enter valid password

            //click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();


            //check if user is logged in successfully

            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("login succefully");
            }
            else
            {
                Console.WriteLine("login failed");
            }

        }
    }
}

