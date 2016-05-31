using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecTestProj2.Library;

namespace SpecTestProj2.Fixtures
{
    [Binding]
    class Fixtures
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            //String path = System.IO.Path.GetFullPath(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Drivers"));
            //String path = @"C:\Users\sree\Documents\Visual Studio 2015\Projects\SpecflowTestProject2\Drivers";
            //Driver = new ChromeDriver(path);

            string BrowserName = ConfigurationManager.AppSettings["BrowserName"];
            Lib Library = new Lib();
            Library.GetDriver(BrowserName);

        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Lib.Driver.Quit();
        }
    }
}
