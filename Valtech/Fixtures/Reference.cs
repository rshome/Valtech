﻿using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Chrome;

namespace ValtechRickyShome
{
    [Binding]
    public class Reference
    {

        public static string BaseAddress
        {
            get { return "http://www.valtech.com/"; }
        }

        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        public void GotoUrl()
        {
            //Go to Valtech Homepage
            driver.Navigate().GoToUrl(BaseAddress);
        }

        public void MaximiseWindow()
        {
            //Maximise browser window
            driver.Manage().Window.Maximize();
        }

        public void ClearCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public void MethodWait()
        {
             driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public void Exit()
        {
            driver.Quit();
        }

 




    }
}

