using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCDotNet.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCDotNet.Tests
{
    internal class SeleniumAssignmentTest
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitScript() 
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
           
        }

        [Test]
        public void TestAssignment() 
        {
            SeleniumAssignment hp = new SeleniumAssignment(_driver);
            _driver.Navigate().GoToUrl("C:\\Users\\Glesh\\source\\repos\\SeleniumCDotNet\\index.html");
            hp.FillName("Andrew");
            hp.FillEmail("Andrew@gmail.com");
        
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }

    }
}
