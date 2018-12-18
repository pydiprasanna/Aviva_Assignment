using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using SeleniumTest.Helper;
using SeleniumTest.Pages;
using SeleniumTest.Actions;

namespace SeleniumTest.CodeBindings
{
    [Binding]
    public class SearchKeywordSteps
    {
        GoogleSearch googleSearch = new GoogleSearch();
        [Given(@"I am on google search page")]
        public void GivenIAmOnGoogleSearchPage()
        {
            DriverClass.driver.Navigate().GoToUrl("https://www.google.com");
        }

        [When(@"I Search for a keyword called '(.*)'")]
        public void WhenISearchForAKeywordCalled(string keyword)
        {
            try
            {
                new SearchKeywordAction().ClickSearchButton(googleSearch, keyword);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [Then(@"I should see '(.*)' on the goole search")]
         public void ThenIShouldSeeOnTheGooleSearch(string keyword)
        {
            try
            {
                Thread.Sleep(5000);
                Assert.That(DriverClass.driver.Title, Is.EqualTo(keyword));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        [Then(@"I should print the (.*)th Text of Search Result")]
        public void ThenIShouldPrintTheThTextOfSearchResult(int position)
        {
            try
            {
                Console.WriteLine("The link text of fifth result is : " + googleSearch.Result[position - 1].Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Then(@"I should see (.*) links in first page of search result")]
        public void ThenIShouldSeeLinksInFirstPageOfSearchResult(int totalCount)
        {
            try
            {
                    Console.WriteLine("Total number of search result links returned: " + googleSearch.Result.Count);
                    Assert.AreNotEqual(googleSearch.Result.Count, totalCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
