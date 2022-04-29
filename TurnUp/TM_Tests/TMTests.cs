//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using TurnUp.Pages;
//using TurnUp.Utilities;

//namespace TurnUp.TM_Tests
//{   
//    [TestFixture]
//    [Parallelizable]

//    internal class TMTests : CommonDriver
//    {
//            [Test, Order(1)]
//            public void CreateTM_Test()
//            {
//                TMPage timeMaterialPageObject = new TMPage();
//                timeMaterialPageObject.createTimeMaterialSteps(driver);
//            }
//            [Test, Order(2)]
//            public void EditTM_Test()
//            {
//                TMPage timeMaterialPageObject = new TMPage();
//                timeMaterialPageObject.editPageSteps(driver);
//            }
//            [Test, Order(3)]
//            public void DeleteTM_Test()
//            {
//                TMPage timeMaterialPageObject = new TMPage();
//                timeMaterialPageObject.deletetPageSteps(driver);
//            }

//    }

//}
