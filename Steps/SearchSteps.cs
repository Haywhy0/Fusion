using FluentAssertions;
using Fusion.Hooks;
using Fusion.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Fusion.Steps
{
    [Binding]
    public class SearchSteps
    {


        public IWebDriver driver = WebHook.driver;
        SearchPage _searchPage = new SearchPage();

        [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl("http://testautomationpractice.blogspot.com/");
        }
        
        [When(@"I click on the searchbox")]
        public void WhenIClickOnTheSearchbox()
        {
            _searchPage.clickSearchBox();
        }
        
        [When(@"I type in software""")]
        public void WhenITypeInSoftware()
        {
            _searchPage.enterSearchBox();
        }

        [When(@"I click on searh button")]
        public void WhenIClickOnSearhButton()
        {
            _searchPage.clickSearchButton();
        }

        [When(@"I select on software bug")]
        public void WhenISelectOnSoftwareBug()
        {
            _searchPage.clickSoftwareBug();
        }
        
        
        
        [Then(@"I should be redirected to wikipedia page")]
        public void ThenIShouldBeRedirectedToWikipediaPage()
        {
            _searchPage.IsWikiPageDisplayed().Should().BeTrue();
        }
    }
}
