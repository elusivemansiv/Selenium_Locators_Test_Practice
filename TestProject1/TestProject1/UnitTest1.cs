using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace DemoQa
{
    public class Test1
    {
        private WebDriver driver;
        private WebDriverWait wait;

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        [Test]

        public void DemoQa()
        {
            var cardbtn = driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", cardbtn);
            
            var browsewinbtn = driver.FindElement(By.XPath("//span[text()='Browser Windows']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", browsewinbtn);

            var newtabbtn = driver.FindElement(By.XPath("//*[@id=\"tabButton\"]"));
            newtabbtn.Click();

            System.Threading.Thread.Sleep(3000);

        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}