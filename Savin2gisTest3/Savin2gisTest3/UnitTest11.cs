using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Savin2gisTest3
{
    [TestClass]
    public class UnitTest11
    {
        private const string City = "Новосибирск";
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
