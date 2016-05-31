using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecTestProj2.Actions;
using NUnit.Framework;
using SpecTestProj2.Library.Pages;
using OpenQA.Selenium;

namespace SpecTestProj2.StepDefinitions
{
    [Binding]
    public sealed class FlipkartSteps
    {
        Actions.Actions actions = new Actions.Actions();
        HomePage homePage = new HomePage();

        Library.Lib lib = new Library.Lib();

        [Given(@"I launch Browser")]
        public void GivenILaunchBrowser()
        {
            Assert.IsNotNull(Library.Lib.Driver);
        }

        [Given(@"I navigate to ""(.*)"" web site")]
        public void GivenINavigateToWebSite(string url)
        {
            Library.Lib.Driver.Navigate().GoToUrl(new Uri(url));
        }

        [When(@"I perform search with ""(.*)""")]
        public void WhenIPerformSearchWith(string searchString)
        {
            homePage.PerformSearch(searchString);
        }

        [Then(@"The result should be displayed")]
        public void ThenTheResultShouldBeDisplayed()
        {
            Assert.IsNotNull(Library.Lib.Driver.FindElement(By.Id("searchCount")));
        }

        [When(@"I perform search and results are displayed")]
        public void WhenIPerformSearchAndResultsAreDisplayed(Table table)
        {
            foreach (var row in table.Rows)
            {
                homePage.PerformSearch(row["SearchString"]);
                Assert.IsNotNull(Library.Lib.Driver.FindElement(By.Id("searchCount")));
            }

        }
    }
}
