using Fusion.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fusion.PageObject
{
    class SearchPage
    {


        public IWebDriver driver;
        public SearchPage()
        {
            driver = WebHook.driver;
        }

        private By searchbox = By.CssSelector("#Wikipedia1_wikipedia-search-input");
        private By searchButton = By.CssSelector("#Wikipedia1_wikipedia-search-form > div > span.wikipedia-search-bar > span:nth-child(2) > input");
        private By softwareBug = By.CssSelector("#wikipedia-search-result-link > a");
      public void clickSearchBox()
        {
            driver.FindElement(searchbox).Click();
        }

        public void enterSearchBox()
        {
            driver.FindElement(searchbox).SendKeys("software");
        }

        public void clickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public void clickSoftwareBug()
        {
            driver.FindElement(softwareBug).Click();
        }

        public bool IsWikiPageDisplayed()
        {
            return driver.Url==("https://en.wikipedia.org/wiki/Software_bug");
        }

    }
}
