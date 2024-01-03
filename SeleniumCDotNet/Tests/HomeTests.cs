﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
    public class HomeTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void InitScript() 
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [Test]
        public void SearchBook() 
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://www.amazon.com/");
            Thread.Sleep(50000);
            hp.Search("Webdriver book");

      
        }
        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
