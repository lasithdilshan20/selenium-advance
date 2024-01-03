using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCDotNet.Based;
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
        private BaseCommand I = new BaseCommand();

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
            Thread.Sleep(10000);
            hp.FillName("Andrew");
            Thread.Sleep(10000);
            hp.FillEmail("Andrew@gmail.com");
            hp.SelectLanguage("Java");
            hp.CheckOnCoding();
            Thread.Sleep(10000);

            //CDM
            I.Click(_driver,"submitForm");
            Thread.Sleep(10000);




        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }

    }
}
