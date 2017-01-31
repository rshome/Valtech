using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using ValtechRickyShome;

namespace Valtech
{
    [Binding]
    public class ValtechSteps
    {

        Reference refClass = new Reference();

        [BeforeScenario("smoke")]
        public void Setup()
        {
            refClass.Initialize();            
        }

        [AfterScenario("smoke")]
        public void TearDown()
        {
            refClass.Exit();            
        }

        [Given(@"I am on the Valtech Homepage")]
        public void GivenIAmOnTheValtechHomepage()
        {
            refClass.GotoUrl();
            refClass.MaximiseWindow();
            refClass.ClearCookies();            
        }
        
        [Then(@"I see the Latest News Section")]
        public void ThenISeeTheLatestNewsSection()
        {
            Assert.IsTrue(Reference.driver.PageSource.Contains("Latest news"));
        }
    }
}
