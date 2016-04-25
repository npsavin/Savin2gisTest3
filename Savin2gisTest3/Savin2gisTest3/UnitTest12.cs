using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Savin2gisTest3
{
    [TestClass]
    public class UnitTest12
    {
        private const string City = "Но";
        private const string CityInUrl = "novosibirsk";
        [TestMethod]
        public void TestMethod1()
        {
            PageAction.OpenHomePage();
            var webItemTextBox = new WebItem("world__searchInput");
            webItemTextBox.SetValue(City);
            webItemTextBox.PressKeyEnter();
            var getUrl = BrowserFramework.WebDriver.Url;
            Assert.IsTrue(getUrl.Contains(CityInUrl));
        }
    }
}
