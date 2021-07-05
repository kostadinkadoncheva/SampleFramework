using OpenQA.Selenium;

namespace SampleFramework
{
    public class Header : BaseApplicationPage
    {
        

        public Header(IWebDriver driver) : base(driver)
        {
        }

        internal SignInPage ClickSignInButton()
        {
            Driver.FindElement(By.XPath("//*[@title='Log in to your customer account']")).Click();
            return new SignInPage(Driver);
        }

        internal ContactUsPage ClickCotactUsButton()
        {
            Driver.FindElement(By.XPath("//*[@title='Contact Us']")).Click();
            return new ContactUsPage(Driver);
        }
    }
}