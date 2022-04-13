﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TurnUp.Utilities
{
    internal class Wait
    {
        public static void waitToBeClickable(IWebDriver driver, string locator,string locatorValue,int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,2,seconds));
            if(locator == "XPATH")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if(locatorValue =="ID")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue))); 
            }
            if(locatorValue=="CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
        }
        public static void waitToBeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver,new TimeSpan(0,0,2,seconds));
            if(locator == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if(locator =="Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if(locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }

        }
        
        
    }
}