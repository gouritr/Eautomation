using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExecuteAutomation.Pages
{
    class UserFormPage:BasePage
    {
        IWebDriver driver;

        By titleDropDown = By.XPath("//Select[@name='TitleId'][@id='TitleId']");
        By initialTxt = By.XPath("//input[@id='Initial']");
        By firstNameTxt = By.XPath("//input[@id='FirstName']");
        By middlenameTxt = By.XPath("//input[@id='MiddleName']");
        // By genderRadiomale = By.XPath("//input[@name='Male']");
        //By gegenderRaiofemale = By.XPath("//input[@id='Female']");
        By genderRadiobtn = By.XPath("//input[@type='radio']");
        By langCheckbox = By.XPath("//input[@type='checkbox']");
       public By saveBtn = By.XPath("//input[@name='Save']");

        public UserFormPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        public void selectTitle(string title)
        {
            selectDropDownusingTxt(title,titleDropDown);
        }
        public void enterInitial(string initial)
        {
            driver.FindElement(initialTxt).SendKeys(initial);
        }
        public void firstName(string firstName)
        {
            driver.FindElement(firstNameTxt).SendKeys(firstName);
        }
        public void middleName(string middleName)
        {
            driver.FindElement(middlenameTxt).SendKeys(middleName);
        }public void gender(string gender)
        {
            GetwebElementbytxt(gender, genderRadiobtn).Click();
        }public void language(string language)
        {
            GetwebElementbytxt(language, langCheckbox).Click();
        }
        
        
    }

}
