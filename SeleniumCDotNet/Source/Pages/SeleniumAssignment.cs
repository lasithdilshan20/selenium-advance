using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCDotNet.Source.Pages
{
    internal class SeleniumAssignment
    { 
        private IWebDriver _driver;

        [FindsBy(How = How.Id,Using = "name" )]
        private IWebElement _name;

        [FindsBy(How = How.Id,Using = "email")]
        private IWebElement _email;

        [FindsBy(How = How.Id, Using = "coding")]
        private IWebElement _coding;

        public SeleniumAssignment(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void FillName(String name)
        {
            _name.SendKeys(name);
        }

        public void FillEmail(String email) 
        {
            _email.SendKeys(email);
        }

        public void CheckOnCoding() 
        {
            _coding.Click();
            
        }
    }
}
