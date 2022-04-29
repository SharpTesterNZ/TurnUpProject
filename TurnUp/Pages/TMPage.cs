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
       public void createTimeMaterialSteps(IWebDriver driver)
        {

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
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.Click();
            IWebElement priceTextBox2 = driver.FindElement(By.XPath(" //*[@id='Price']"));
            priceTextBox2.Clear();
            priceTextBox2.SendKeys("88");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            saveButton.Click();



            Thread.Sleep(5000);
            //click on go to last page button
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 5);

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(5000);
            lastPageButton.Click();

            //Check if record create is present in the table and has expected value

            IWebElement codeItem = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            Assert.That(codeItem.Text == "12345", "Actual code and expected code do not match");



        }

        public void editPageSteps(IWebDriver driver,string code,string description, string price)
        {
            Thread.Sleep(5000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(5000);
            lastPageButton.Click();

            
            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if(findRecordCreated.Text == "12345")
            {
                //click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }


            IWebElement codeEditTextBox = driver.FindElement(By.Name("Code"));
            codeEditTextBox.Click();
            codeEditTextBox.Clear();
            codeEditTextBox.SendKeys(code);

            IWebElement descriptionEditTextBox = driver.FindElement(By.XPath("//*[@id='Description']"));
            descriptionEditTextBox.Click();
            descriptionEditTextBox.Clear();
            descriptionEditTextBox.SendKeys(description);


            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.Click();
            
            IWebElement priceTextBox2 = driver.FindElement(By.XPath(" //*[@id='Price']"));
            priceTextBox2.Clear();
            priceTextBox.SendKeys(price);


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
        }

        public void deletetPageSteps(IWebDriver driver)
        {

            Thread.Sleep(5000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(5000);
            lastPageButton.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findRecordCreated.Text == "TU20220123")
            {
                //click on Delete button

                IWebElement deletebutton = driver.FindElement(By.XPath(" //*[@id='tmsGrid']/div[3]/table/tbody/tr/td[last()]/a[2]"));
                deletebutton.Click();
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record is not found, and cannot delete");
            }

            driver.Navigate().Refresh();
            Thread.Sleep(3000);
            IWebElement goTolastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(5000);
            goTolastPageButton.Click();

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editedCode.Text != "TU20220123", "Code record hasn't been deleted.");
            Assert.That(editedDescription.Text != "EditedFebruary2022", "Description record hasn't been deleted.");
            Assert.That(editedPrice.Text != "$170.00", "Price record hasn't been deleted.");

        }

        public string getCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string getTypeCode(IWebDriver driver)
        {  
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return newTypeCode.Text;
        }
        public string getDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string getPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

    }
}
