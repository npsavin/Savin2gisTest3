using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Savin2gisTest3
{
    class WebItem
    {
          public string ClassName { get; set; }
          public string XPath { get; set; }
   
          public WebItem(string className="", string xPath="")
          {
              ClassName = className;
              XPath = xPath;
          }

        

        public void Click()
          {
              BrowserFramework.FindWebElement(this).Click();
          }
   
          public void SetValue(string value)
          {
              BrowserFramework.FindWebElement(this).SendKeys(value);
          }

        public string GetVlue()
        {
            return BrowserFramework.FindWebElement(this).GetAttribute("value");
        }
        public void PressKeyEnter()
        {
            BrowserFramework.FindWebElement(this).SendKeys(Keys.Enter);
        }
    }
}
