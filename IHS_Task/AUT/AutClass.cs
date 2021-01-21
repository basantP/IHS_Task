using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace IHS_Task.AUT
{
    [SetUpFixture]
    public class AutClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Launch()
        {
            // TODO: Add code here that is run before
            //  all tests in the assembly are run      
            driver = new ChromeDriver();
            driver.Url = "https://dotnetfiddle.net/";
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void Close()
        {
            // TODO: Add code here that is run after
            //  all tests in the assembly have been run
            driver.Quit();
        }
    }
}