using OpenQA.Selenium;
using SpecTestProj2.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecTestProj2.StepDefinitions
{
    [Binding]
    class GoogleSearchSteps
    {
        //IWebDriver currentDriver = null;

        [Given(@"I have navigated to Google page")]
        public void GivenIHaveNavigatedToGooglePage()
        {
            Lib.Driver.Navigate().GoToUrl(new Uri("https://www.google.co.uk"));
            Lib.Driver.Manage().Window.Maximize();
        }

        [Given(@"I see the google page fully loaded")]
        public void GivenISeeTheGooglePageFullyLoaded()
        {
            if (Lib.Driver.FindElement(By.Name("q")).Displayed == true)
                Console.WriteLine("Page loaded fully");
            else
                Console.WriteLine("Page failed to download");
        }

        [When(@"I type search keyword as")]
        public void WhenITypeSearchKeywordAs(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            Lib.Driver.FindElement(By.Name("q")).SendKeys(tableDetail.Keyword);
            Lib.Driver.FindElement(By.Name("btnG")).Click();
        }

        [Then(@"I should see the results for keyword")]
        public void ThenIShouldSeeTheResultsForKeyword(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            string key = tableDetail.Keyword;
            //if (Fixtures.Fixtures.Driver.FindElement(By.PartialLinkText(key)).Displayed == true)
            if (Lib.Driver.PageSource.Contains(key))
                Console.WriteLine("Control exist");
            else
                Console.WriteLine("Control not exist");
        }


    }
}
