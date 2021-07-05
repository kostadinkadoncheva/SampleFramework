using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using SampleFramework;

namespace SampleFramework
{
    [TestFixture]
    public class ContactUsFeature : BaseTest
    {
    
        [Test]
        [Property("Author", "KostadinkaDoncheva")]
        [Description("Validate the contact us page is successfully loaded with a form")]
        public void TCID2()
        {
            ContactUsPage contactUsPage = new ContactUsPage(driver);
            contactUsPage.GoTo();
            Assert.IsTrue(contactUsPage.Isloaded,
                "The contact us page did not open successfully");
        }
        [Test]
        [Description("Validate the Contact Us button is redirected to Contact Us form.")]
        [Property("Author", "KostadinkaDoncheva")]
        public void TCID4()
        {
            var homePage = new HomePage(driver);
            homePage.GoTo();
            
            var contactUsPage = homePage.Header.ClickCotactUsButton();
            Assert.IsTrue(contactUsPage.Isloaded,
                "The contact us page did not open successfully");

        }
    }
}
