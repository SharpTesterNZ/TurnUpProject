using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TurnUp.Utilities;

namespace TurnUp.Pages
{
    internal class TMPage
    {
       public void timeMaterialSteps(IWebDriver driver)
        {
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

            // click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();
            //Wait.waitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5);
            Thread.Sleep(5000);
            //click on go to last page button

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            Thread.Sleep(5000);
            lastPageButton.Click();

            //Check if record create is present in the table and has expected value

            IWebElement codeItem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            Assert.That(codeItem.Text == "12345", "Actual code and expected code do not match");



        }

        public void editPageSteps(IWebDriver driver)
        {
            //Thread.Sleep(5000);
            //IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            //editButton.Click();
            //IWebElement codeEditTextBox = driver.FindElement(By.Name("Code"));
            //codeEditTextBox.Click();
            //codeEditTextBox.Clear();
            //codeEditTextBox.SendKeys("TU20220123");

            //IWebElement descriptionEditTextBox = driver.FindElement(By.XPath("//*[@id='Description']"));
            //descriptionEditTextBox.Click();
            //descriptionEditTextBox.Clear();
            //descriptionEditTextBox.SendKeys("leaking");

            //IWebElement priceEditTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            ////priceEditTextBox.Click();
            ////priceEditTextBox.Clear();

            //priceEditTextBox.SendKeys("96");

            //////*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
            //// click on save button
            //IWebElement saveEditButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            //saveEditButton.Click();

            //// click on BackToList
            //IWebElement backToListEditButton = driver.FindElement(By.XPath("//*[@id='container']/div/a"));

            //// click on lastpage

            //Thread.Sleep(5000);
            //IWebElement lastPageEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            //Thread.Sleep(5000);
            //lastPageEditButton.Click();

            ////Assert
            //Thread.Sleep(3000);
            //IWebElement codeEditItem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //if (codeEditItem.Text == "TU20220123")
            //{
            //    Console.WriteLine("testing pass");
            //}
            //else
            //{
            //    Console.WriteLine("test failed");
            //}
        }
        public void deletetPageSteps(IWebDriver driver)
        {
            //IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            //deleteButton.Click();
            //driver.SwitchTo().Alert().Accept();
        }
    }
}
