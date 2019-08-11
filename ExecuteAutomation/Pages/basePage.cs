using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExecuteAutomation.Pages
{
    class BasePage
    {
        IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetwebElementbytxt(string text,By by)
        {
            IList<IWebElement> radioBtns = driver.FindElements(by);
            foreach (IWebElement element in radioBtns)
            {
                
                if(element.GetAttribute("name") == text)
                {
                    return element;
                }
            }

            throw new Exception($"radio button with text {text} is not found");
        }

        public void selectDropDownusingTxt(string text, By DropDown)
        {
            IWebElement titleElement = driver.FindElement(DropDown);
            SelectElement selectElement = new SelectElement(titleElement);
            selectElement.SelectByText(text);
        }
    }
}
