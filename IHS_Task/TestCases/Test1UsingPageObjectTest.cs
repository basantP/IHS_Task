using NUnit.Framework;
using IHS_Task.AUT;
using IHS_Task.PageObject;

namespace TaskUsingPageObjectTest
{
    [TestFixture]
    public class Test1UsingPageObjectTest : AutClass
    {
        [Test]
        public void ClickRunAndCheckOutPut_Test()
        {
            var runPage = new RunPage(driver);
            runPage.clickRunButton();            
            Assert.IsTrue(runPage.outputText.Text.Contains("Hello World"), "Text: Hello World is not displayed");
        }
    }
}

