using FluentAssertions;
using Fusion.Hooks;
using Fusion.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Fusion.Steps
{
    [Binding]
    public class VolunteerFormStep
    {

        public IWebDriver driver = WebHook.driver;
        VolunteerFormPage _volunteerFormPage = new VolunteerFormPage();


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl("http://testautomationpractice.blogspot.com");
        }
        
        [When(@"I fill in the volunteer form")]
        public void WhenIFillInTheVolunteerForm()
        {
            _volunteerFormPage.EnterfirstName();
        }
        
        [When(@"I click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            _volunteerFormPage.EnterLastName();
        }
        
        [When(@"I enter First name")]
        public void WhenIEnterFirstName()
        {
            _volunteerFormPage.EnterphoneNumber();
        }
        
        [When(@"I enter Last name")]
        public void WhenIEnterLastName()
        {
            _volunteerFormPage.EnterLastName();
        }
        
        [When(@"I enter invalid phone number")]
        public void WhenIEnterInvalidPhoneNumber()
        {
            _volunteerFormPage.EnterphoneNumber();
        }
        
        [When(@"I enter Country Name")]
        public void WhenIEnterCountryName()
        {
            _volunteerFormPage.EnterCountry();
        }
        
        [When(@"I enter city Name")]
        public void WhenIEnterCityName()
        {
            _volunteerFormPage.EnterCity();
        }
        
        [When(@"I enter email")]
        public void WhenIEnterEmail()
        {
           _volunteerFormPage.EnterEmail();
        }
        
        [When(@"I select gender")]
        public void WhenISelectGender()
        {
            _volunteerFormPage.ClickFemale();
        }
        
        [When(@"I select available days of the week")]
        public void WhenISelectAvailableDaysOfTheWeek()
        {
            _volunteerFormPage.CliickDay();
        }
        
        [When(@"I select best time to contact from thr dropdown")]
        public void WhenISelectBestTimeToContactFromThrDropdown()
        {
            _volunteerFormPage.SelectContact();
        }
        [When(@"I  upload file")]
        public void WhenIUploadFile()
        {
           _volunteerFormPage.UploadFile();
        }
        
        
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            _volunteerFormPage.clickSubmitButton();
        }
        
        [When(@"I leave first name blank")]
        public void WhenILeaveFirstNameBlank()
        {
            _volunteerFormPage.ToString();
        }
        
        [When(@"I Enter Invalid country name")]
        public void WhenIEnterInvalidCountryName()
        {
            _volunteerFormPage.invalidCountryName();
        }
        
        [When(@"I enter Invalid city name")]
        public void WhenIEnterInvalidCityName()
        {
            _volunteerFormPage.invalidCity();
        }
        
        [When(@"I enter invalid email")]
        public void WhenIEnterInvalidEmail()
        {
            _volunteerFormPage.invalidEmail();
        }
        
        [Then(@"I should get an error message""(.*)""")]
        public void ThenIShouldGetAnErrorMessage(string p0)
        {
            _volunteerFormPage.IsErrorMessageDisplayed().Should().BeTrue();

        }
        
        
    }
}
