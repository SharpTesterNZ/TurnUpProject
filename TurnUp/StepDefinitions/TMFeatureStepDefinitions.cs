using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TurnUp.Pages;
using TurnUp.Utilities;

namespace TurnUp.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions:CommonDriver

    {
        //PageObject initialization
        HomePage homePageObj = new HomePage();  
        LoginPage loginPageObj = new LoginPage();
        TMPage tMPageObj = new TMPage();

        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            //open Chrome Driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializaiton and definition
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObj.homePageSteps(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tMPageObj.createTimeMaterialSteps(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tMPageObj.getCode(driver);
            string newTypeCode = tMPageObj.getTypeCode(driver);
            string newDescription = tMPageObj.getDescription(driver);
            string newPrice = tMPageObj.getPrice(driver);

            Assert.That(newCode == "12345", "Actual Code and expected code does not match");
            Assert.That(newTypeCode == "M", "Actual typecode and expected code doese not match");
            Assert.That(newDescription == "hi yaya", "Actual descpriton and ");
        }

        [When(@"I update '([^']*)','([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string p0, string p1, string p2)
        {
            tMPageObj.editPageSteps(driver,p0,p1,p2);
            //这里的变量跟tmpage 里的变量是一样的，变量名可以不一样
        }

        [Then(@"the record should have the updated '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string p0, string p1, string p2)
        {
           string returnNewCode = tMPageObj.getCode(driver);
           string returnNewDescription = tMPageObj.getDescription(driver);
           string returnNewPrice = tMPageObj.getPrice(driver);

            Assert.That(returnNewCode == p0, "the code does not match");
            Assert.That(returnNewDescription == p1, "the description does not match");
            Assert.That(returnNewPrice == p2, "the new price does not match");
        }

    }
}
