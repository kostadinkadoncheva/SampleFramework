using OpenQA.Selenium;
using System;

namespace SampleFramework
{
    internal class SearchPage : BaseApplicationPage
    {

        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        internal bool Contains(Item blouse)
        {
            switch (blouse)
            {
                case Item.Blouse:
                   return Driver.FindElement(By.XPath("//*[@title='Blouse']")).Displayed;
                default:
                    throw new ArgumentOutOfRangeException("No such item in this collection.");
            }
        }
    }
}