using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecTestProj2.Actions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.IO;
using SpecTestProj2.Actions;

namespace SpecTestProj2.Library
{
    class Lib
    {
        public static IWebDriver Driver;
        String Driverpath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Drivers"));

        //Actions.Actions actions = new Actions.Actions();
        ActionClass actions = new ActionClass();

        public IWebDriver GetDriver(string Browser)
        {
            switch(Browser)
            {
                case "chrome":
                case "Chrome":
                    Driver = new ChromeDriver();
                    break;

                case "firefox":
                case "Firefox":
                    Driver = new FirefoxDriver();
                    break;

                case "ie":
                case "IE":
                    Driver = new InternetExplorerDriver();
                    break;
            }
            Driver.Manage().Window.Maximize();
            return Driver;
        }
    }
}
