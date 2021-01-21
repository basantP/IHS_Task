using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IHS_Task.AUT;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IHS_Task
{
    [TestFixture]
    public class TaskTest : AutClass
    {
        [Test]
        public void ClickRunAndCheckOutPut_Test()
        {
            IWebElement runButton = driver.FindElement(By.Id("run-button"));
            runButton.Click();
            IWebElement outputText = driver.FindElement(By.XPath("//*[@id=\"output\"]"));
            Assert.IsTrue(outputText.Text.Contains("Hello World"), "Text: Hello World is not displayed");
        }

        [Test]
        public void DoAsYourNameStarts_Test()
        {
            //String nameInput = "Austin";
            //String nameInput = "Frank";
            //String nameInput = "Mike";
            //String nameInput = "Troy";
            String nameInput = "Zion";

            nameInput = nameInput.ToUpper();
            char[] name = nameInput.ToCharArray();
            if (name[0] == 'A' || name[0] == 'B' || name[0] == 'C' || name[0] == 'D' || name[0] == 'E')
            {
                //IWebElement nugetPackagesSearchBox = driver.FindElement(By.XPath("//*[@id=\"CodeForm\"]/div[2]/div[2]/div[5]/div/div/input"));
                IWebElement nugetPackageSearchBox = driver.FindElement(By.CssSelector("input[placeholder = 'Package name...']"));
                nugetPackageSearchBox.SendKeys("nUnit");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                IWebElement nUnitOption = driver.FindElement(By.CssSelector("a[package-id='NUnit']"));
                nUnitOption.Click();
                
                wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[version-name='3.12.0.0']")));
                element.Click();
               
                IWebElement nunitNugetPackage = driver.FindElement(By.CssSelector("a[package-id='NUnit']"));
                Assert.IsTrue(nunitNugetPackage.Displayed, "nUnit package is not added");

            }
            else if (name[0] == 'F' || name[0] == 'G' || name[0] == 'H' || name[0] == 'I' || name[0] == 'J' || name[0] == 'K')
            {
       
                IWebElement shareButton = driver.FindElement(By.Id("Share"));
                shareButton.Click();

                driver.SwitchTo().Window(driver.WindowHandles.Last());

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                IWebElement shareLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ShareLink")));

                Assert.IsTrue(shareLink.Displayed, "Share link not displayed");
                Assert.IsTrue(shareLink.GetAttribute("value").Contains("https://dotnetfiddle.net/"),"valid Share link is not displayed ");

            }
            else if (name[0] == 'L' || name[0] == 'M' || name[0] == 'N' || name[0] == 'O' || name[0] == 'P')
            {
                driver.FindElement(By.XPath("//*[@id=\"CodeForm\"]/div[2]/div[2]/div[1]/button[1]/span")).Click();

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                System.Threading.Thread.Sleep(5000); //shuold be changed with selenium wait. but this is other way to quickly debug 
                Assert.IsFalse( driver.FindElement(By.XPath("//*[@id=\"CodeForm\"]/div[2]/div[2]/div[1]/button[1]/span")).Displayed,"Option is wrongly displaying after hiding");
              
            }
            else if (name[0] == 'Q' || name[0] == 'R' || name[0] == 'S' || name[0] == 'T' || name[0] == 'U')
            {
                driver.FindElement(By.Id("save-button")).Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                IWebElement loginWindow = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("button[data-loading-text='Logging in...']")));//Failing with no such element exception

                Assert.IsTrue((loginWindow).Displayed, "Login window did not appear");
            }
            else if (name[0] == 'V' || name[0] == 'W' || name[0] == 'X' || name[0] == 'Y' || name[0] == 'Z')
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                IWebElement gettingStartedButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a[href='/GettingStarted/']")));//Failing with no such element exception

                gettingStartedButton.Click();

                IWebElement bakToEditor = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#top-navbar > div.navbar-center-container > div:nth-child(1) > a")));
                Assert.IsTrue((bakToEditor).Displayed, "Back to Editor button did not appear");
            }
        }
    }
}

