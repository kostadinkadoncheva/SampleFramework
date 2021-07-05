﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SampleFramework
{
    public class Slider : BaseApplicationPage
    {

        public Slider(IWebDriver driver) : base(driver)
        {          
        }

        public string CurrentImage => MainSliderImage.GetAttribute("style");

        private IWebElement MainSliderImage => Driver.FindElement(By.Id("homeslider"));

        internal void ClickNextButton()
        {
            Driver.FindElement(By.ClassName("bx-next")).Click();
        }

        
    }
}