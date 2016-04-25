using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace Savin2gisTest3
{
    class BrowserFramework
    {
         static RemoteWebDriver _WebDriver;
     
             public static RemoteWebDriver WebDriver
            {
                get
                {
                   if (_WebDriver == null)
                      _WebDriver = new FirefoxDriver();
     
                    return _WebDriver;
                }
            }
     
            public static void OpenURL (string URL)
           {
               WebDriver.Navigate().GoToUrl(URL);
            }
     
            public static IWebElement FindWebElement(WebItem webItem)
            {
     
                if (webItem.ClassName != "")
                return WebDriver.FindElementByClassName(webItem.ClassName);

                if (webItem.XPath != "")
                    return WebDriver.FindElementByXPath(webItem.XPath);
   
   
              return null;
          }

        

        
       
    }
}
