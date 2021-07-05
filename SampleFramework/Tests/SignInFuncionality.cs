using NUnit.Framework;

namespace SampleFramework
{
    
     public class SignInFuncinality : BaseTest
    {
        [Test]
        [Property("Author","KostadinkaDoncheva")]
        [Description("")]
        public void TCID5()
        {
            var homePage = new HomePage(driver);
            homePage.GoTo();
            var signInPage = homePage.Header.ClickSignInButton();
            Assert.IsTrue(signInPage.IsLoaded,
                "The Sign page did not open successfully.");
        }
    }
}
