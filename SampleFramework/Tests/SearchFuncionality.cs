using NUnit.Framework;

namespace SampleFramework
{
    [TestFixture]
    public class SearchFuncionality : BaseTest
    {

        [Test]
        [Property("Author","KostadinkaDoncheva")]
        [Description("")]
        public void TCID1()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoTo();
            SearchPage searchPage = homePage.Search("blouse");
            Assert.IsTrue(searchPage.Contains(Item.Blouse));
        }
    }
}