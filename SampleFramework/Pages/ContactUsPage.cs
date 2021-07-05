using OpenQA.Selenium;
using System;

namespace SampleFramework
{
    internal class ContactUsPage : BaseApplicationPage
    {
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
        }

        public bool Isloaded => Driver.FindElement(By.Id("center_column")).Displayed;

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }
        
    }
}