using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleFramework
{
    public class BaseTest
    {

        public IWebDriver driver; 
        [OneTimeSetUp]
        public void SetUpBeforeEverySingleMethod()
        {
            driver = new ChromeDriver();
        }
    
        [OneTimeTearDown]
        public virtual void CleanUpAfterEverySingleMethod()
        {
            driver.Close();   
            driver.Quit();
        }
    }
}