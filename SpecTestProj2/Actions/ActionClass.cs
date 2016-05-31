using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecTestProj2.Actions
{
    class ActionClass
    {
        public void SetText(string locator, string value)
        {
            try
            {
                switch(GetElementPropertyType(locator))
                {
                    case "Name":
                        Library.Lib.Driver.FindElement(By.Name(GetElementPropertyValue(locator))).SendKeys(value);
                        break;

                    case "ClassName":
                        Library.Lib.Driver.FindElement(By.ClassName(GetElementPropertyValue(locator))).SendKeys(value);
                        break;
                }
            }
            catch(Exception e)
            {
                Assert.Fail("Set Text Failed to locate " + locator + "Exception " + e);
            }
        }

        public void ClickElement(string locator)
        {
            try
            {
                switch (GetElementPropertyType(locator))
                {
                    case "ClassName":
                        Library.Lib.Driver.FindElement(By.ClassName(GetElementPropertyValue(locator))).Click();
                        break;
                }
            }
            catch (Exception e)
            {

                Assert.Fail("Element click failed to locate " + locator + " Exception: " + e);
            }
        }

        public string GetElementPropertyType(string elementLogicalName)
        {
            return elementLogicalName.Split('_')[1];
        }

        public string GetElementPropertyValue(string elementLogicalName)
        {
            return elementLogicalName.Split('_')[0];
        }
    }
}
