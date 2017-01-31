using TechTalk.SpecFlow;
using ValtechRickyShome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace Valtech
{
    [Binding]
    public class PageSteps
    {
        Reference refClass = new Reference();

        [BeforeScenario("Pages")]
        public void Setup()
        {
            refClass.Initialize();            
        }

        [AfterScenario("Pages")]
        public void TearDown()
        {
            refClass.Exit();
        }


        [When(@"I navigate to (.*)")]
        public void WhenINavigateToCases(string section)
        {
            Reference.driver.Navigate().GoToUrl(Reference.BaseAddress + section);
        }


        [Then(@"I see the Page (.*)")]
        public void ThenISeeThePageWork(string page)
        {
            refClass.MethodWait();
            Assert.AreEqual(page, Reference.driver.FindElement(By.CssSelector("h1")).Text);
        }



    }
}
