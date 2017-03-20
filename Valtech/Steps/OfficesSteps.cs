using System;
using TechTalk.SpecFlow;
using ValtechRickyShome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valtech
{
    [Binding]
    public class ValtechHomePageSteps
    {

        Reference refClass = new Reference();

        [BeforeScenario("Offices")]
        public void Setup()
        {
            refClass.Initialize();            
        }

        [AfterScenario("Offices")]
        public void TearDown()
        {
            refClass.Exit();
        }

        [When(@"I view the Contact Us Page")]
        public void WhenIViewTheContactUsPage()
        {
            Reference.driver.Navigate().GoToUrl(Reference.BaseAddress + "about/contact-us");
        }


        [Then(@"I view the total number of offices is (.*)")]
        public void ThenIViewTheTotalNumberOfOfficesIs(int offices)
        {
            refClass.MethodWait();            

            int OfficeCount = Reference.driver.FindElements(By.CssSelector("header.office__header")).Count;
            Assert.AreEqual(OfficeCount, offices);
        }

    }
}
