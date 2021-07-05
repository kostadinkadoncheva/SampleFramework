using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFramework
{
    [TestFixture]
    class SliderFuture : BaseTest
    {

        [Test]
        [Description("Validate that slider changes images")]
        [Property("Author","KostadinkaDoncheva")]
        public void TCID3()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoTo();
           var currentImage = homePage.Slider.CurrentImage;
            homePage.Slider.ClickNextButton();
            var newImage = homePage.Slider.CurrentImage;
            Assert.AreNotEqual(currentImage, newImage,
                "The slider images did not change when pressing the next button");
        }

       
    }
}
