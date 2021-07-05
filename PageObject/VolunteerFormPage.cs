using Amazon.DynamoDBv2;
using Fusion.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fusion.PageObject
{
    class VolunteerFormPage
    {
        public IWebDriver driver;
        public VolunteerFormPage()
        {
            driver = WebHook.driver;
        }
        private By firstName = By.CssSelector("#RESULT_TextField-1");
        private By lastName = By.CssSelector("#RESULT_TextField-2");
        private By country = By.CssSelector("#RESULT_TextField-4");
        private By city = By.CssSelector("#RESULT_TextField-5");
        private By email = By.CssSelector("#RESULT_TextField-6");
        private By female = By.XPath("#q26>table>tbody>tr:nth-child(2)>td>label");
        private By day = By.CssSelector("#q15>table>tbody>tr:nth-child(2)>td>label");
        private By phoneNumber = By.CssSelector("#RESULT_TextField-3");
        private By contact = By.CssSelector("#RESULT_RadioButton-9 > option:nth-child(3)");
        private By upload = By.CssSelector("#RESULT_FileUpload-10");
        private By submitButton = By.CssSelector("#FSsubmit");

        







        public void EnterfirstName()
        {
            driver.FindElement(firstName).SendKeys("Joy");
        }

        public void EnterLastName()
        {
            driver.FindElement(lastName).SendKeys("Badmus");
        }

        public void EnterphoneNumber()
        {
            driver.FindElement(phoneNumber).SendKeys("07401439556");
        }

        public void EnterCountry()
        {
            driver.FindElement(country).SendKeys("UnitedKingdom");
        }

        public void EnterCity()
        {
            driver.FindElement(city).SendKeys("Kent");
        }

        public void EnterEmail()
        {
            driver.FindElement(email).SendKeys("badmusayoola@gmail.com");
        }

        public void ClickFemale()
        {
            
                driver.FindElement(female).Click();
        }

        public void CliickDay()
        {
            driver.FindElement(day).Click();
        }

        public void SelectContact()
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("#RESULT_RadioButton-9")));
            selectElement.SelectByIndex(1);
            driver.FindElement(contact).Click();

        }

        public void UploadFile()
        {
            driver.FindElement(upload).SendKeys(@"C:\Users\The User\Pictures\HD fashion pic.jpg");
        }

        public void clickSubmitButton()
        {
            driver.FindElement(submitButton).Click();
        }

        public void firstNameBlank()
        {
            driver.FindElement(firstName).SendKeys("");
        }


        public void invalidCountryName()
        {
            driver.FindElement(country).SendKeys("untedKingdom");
        }

        public void invalidCity()
        {
            driver.FindElement(city).SendKeys("lndon");
        }

        public void invalidEmail()
        {
            driver.FindElement(email).SendKeys("badmusayool+2@.com");
        }

        public bool IsErrorMessageDisplayed()
        {
            return driver.Url.Contains ("The result storage capacity has been reached for this form. Your result was not created. Please contact the form owner.");
        }
    }
}
