using OpenQA.Selenium;

namespace SampleFramework
{
    internal class SignInPage : BaseApplicationPage
    {
       

        public SignInPage(IWebDriver driver) : base(driver)
        {            
        }

        public bool IsLoaded => Driver.FindElement(By.Id("create-account_form")).Displayed;
        
    }
}