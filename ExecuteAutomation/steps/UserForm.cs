using ExecuteAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ExecuteAutomation.steps
{
    [Binding]
    public sealed class userFormSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        IWebDriver driver;
        UserFormPage userFormPage;
        private readonly ScenarioContext context;

        public userFormSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }
        [Given(@"User is on UserForm Page")]
        public void GivenUserIsOnUserFormPage()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");

            
        }

        [Given(@"User enters below details")]
        public void GivenUserEntersBelowDetails(Table table)
        {
           User user = table.CreateInstance<User>();
            userFormPage= new UserFormPage(driver);
            userFormPage.selectTitle(user.Title);
            userFormPage.enterInitial(user.Initial);
            userFormPage.firstName(user.FirstName);
            userFormPage.middleName(user.MiddleName);
            userFormPage.gender(user.Gender);
            userFormPage.language(user.LanguagesKnown);
            
        }

        [When(@"user clicks save")]
        public void WhenUserClicksSave()
        {
            driver.FindElement(userFormPage.saveBtn).Click();
        }

        [Then(@"no error displayed")]
        public void ThenNoErrorDisplayed()
        {
           // ScenarioContext.Current.Pending();
        }


    }
    class User
    {
        // | Title | Initial | FirstName | MiddleName | Gender | LanguagesKnownstr
        public string Title;
        public string Initial { get; set; }
        public string FirstName;
        public string MiddleName;
        public string Gender;
        public string LanguagesKnown;


    }
}
