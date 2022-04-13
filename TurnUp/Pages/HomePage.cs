using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnUp.Pages
{
    internal class HomePage
    {
        public void homePageSteps(IWebDriver driver)
        {
            IWebElement administrator = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrator.Click();
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();

            //Click on Create New Button


            IWebElement createNewItem = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewItem.Click();
        }
    }
}
