using OpenQA.Selenium;
using System;


namespace SampleFramework
{
    internal class HomePage : BaseApplicationPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            Slider = new Slider(driver);
        }


        public Slider Slider { get; internal set; }
        public Header Header => new Header(Driver);

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        internal SearchPage Search(string itemToSearchFor)
        {
            Driver.FindElement(By.Id("search_query_top")).SendKeys(itemToSearchFor);
            Driver.FindElement(By.Name("submit_search")).Click();
            return new SearchPage(Driver);
        }

        
    }
}