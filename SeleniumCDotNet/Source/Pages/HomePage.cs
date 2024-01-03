using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCDotNet.Source.Pages
{
    internal class HomePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement _searchtextbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        private IWebElement _searchbtn;
        public HomePage(IWebDriver driver) 
        { 
            _driver = driver;
            PageFactory.InitElements(driver, this);
        
        }

        public void Search(String searchtext) 
        {
            _searchtextbox.SendKeys(searchtext);
            _searchbtn.Click();

        }
    }

}
