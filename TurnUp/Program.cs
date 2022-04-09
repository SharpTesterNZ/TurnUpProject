using System;
using System.Threading;
using NUnit.Framework;
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
            System.Threading.Thread.Sleep(50);
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("login succefully");
            }
            else
            {
                Console.WriteLine("login failed");
            }



            //Click on the Administration and Go to Time&Materials page 

            IWebElement administrator = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrator.Click();
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();

            //Click on Create New Button


            IWebElement createNewItem = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewItem.Click();


            //Validate TypeCode and Select Material from TypeCode dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            typeCode.Click();

            IWebElement materialButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            materialButton.Click();

            //IWebElement timeButton = driver.FindElement(By.XPath("//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]"));


            //Identify the code textbox and input a code
            IWebElement codeText = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[2]/label"));
            codeText.Click();
            IWebElement codeTextBox = driver.FindElement(By.Name("Code"));
            codeTextBox.Click();
            codeTextBox.SendKeys("12345");

            //Identify the description textbox and input a description
            IWebElement descriptionText = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[3]/label"));
            descriptionText.Click();
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.Click();
            descriptionTextBox.SendKeys("hi yaya");

            //Identify the price per unit and input a price

            IWebElement priceText = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/label"));
            priceText.Click();
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
        
            priceTextBox.SendKeys("88");

            //select files 
            //IWebElement uploadFile = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[6]/div/div/div/div"));
            //uploadFile.SendKeys("C:\\Users\\owens\\OneDrive\\Desktop\\1612515811566.jpeg");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();

            // click on BackToList
            IWebElement backOnListButton = driver.FindElement(By.XPath("//*[@id='container']/div/a"));

            // click on lastpage

            Thread.Sleep(5000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            Thread.Sleep(5000);
            lastPageButton.Click();

            //Assert
            Thread.Sleep(3000);
            IWebElement codeItem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (codeItem.Text == "wow")
            {
                Console.WriteLine("testing pass");
            }
            else
            {
                Console.WriteLine("test failed");
            }


            // Check if the user able to edit the material&time for the previous item 
            Thread.Sleep(5000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            IWebElement codeEditTextBox = driver.FindElement(By.Name("Code"));
            codeEditTextBox.Click();
            codeEditTextBox.Clear();
            codeEditTextBox.SendKeys("TU20220123");

            IWebElement descriptionEditTextBox = driver.FindElement(By.XPath("//*[@id='Description']"));
            descriptionEditTextBox.Click();
            descriptionEditTextBox.Clear();
            descriptionEditTextBox.SendKeys("leaking");

            IWebElement priceEditTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //priceEditTextBox.Click();
            //priceEditTextBox.Clear();
     
            priceEditTextBox.SendKeys("96");

            ////*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
            // click on save button
            IWebElement saveEditButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveEditButton.Click();

            // click on BackToList
            IWebElement backToListEditButton = driver.FindElement(By.XPath("//*[@id='container']/div/a"));

            // click on lastpage

            Thread.Sleep(5000);
            IWebElement lastPageEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            Thread.Sleep(5000);
            lastPageEditButton.Click();

            //Assert
            Thread.Sleep(3000);
            IWebElement codeEditItem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (codeEditItem.Text == "TU20220123")
            {
                Console.WriteLine("testing pass");
            }
            else
            {
                Console.WriteLine("test failed");
            }






            //Check if the user able to delete the previous item


            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(5000);
            IWebElement codeDeleteItem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (codeDeleteItem.Text != "wow")
            {
                Console.WriteLine("testing pass"); 
            }
            else
            {
                Console.WriteLine("test failed");
            }




















        }
    }
}

