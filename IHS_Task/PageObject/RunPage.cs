using System;
using System.Collections.Generic;
using System.Text;
//using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace IHS_Task.PageObject
{
    public class RunPage
    {
        IWebDriver driver;
        public RunPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "run-button")]
        public IWebElement runButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"output\"]")]
        public IWebElement outputText { get; set; }

        public void clickRunButton() {
            runButton.Click();
        }

    }
}
