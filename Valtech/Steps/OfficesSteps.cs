﻿using System;
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
            Reference.Initialize();
        }

        [AfterScenario("Offices")]
        public void TearDown()
        {
            Reference.driver.Quit();
        }

        [When(@"I view the Contact Us Page")]
        public void WhenIViewTheContactUsPage()
        {
            Reference.driver.Navigate().GoToUrl(Reference.BaseAddress + "investors/contact-us");
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