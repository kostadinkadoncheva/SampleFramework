﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFramework
{
    public class BaseApplicationPage
    {
        protected IWebDriver Driver { get; set; }
        public BaseApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
