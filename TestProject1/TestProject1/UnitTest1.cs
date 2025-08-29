using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        
        [Test]
       
        public void DemoQa()
        {
            var cardbtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//h5[text()='Alerts, Frame & Windows']")));
            cardbtn.Click();
            
            var browsewinbtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Browser Windows']")));
            browsewinbtn.Click();

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