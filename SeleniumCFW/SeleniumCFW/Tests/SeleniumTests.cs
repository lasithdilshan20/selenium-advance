using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCFW.Based;
using SeleniumCFW.PageObjects;

namespace  SeleniumCFW
{
    [TestFixture]
    public class SeleniumTests
    {
        private IWebDriver driver;
        private MainPage mainPage;
        BaseCommand I = new BaseCommand();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            I.MaximizeWindow(driver);
            I.Timeouts(driver,30);
            string pathToHtml = @"C:\Automation\Selenium\SeleniumCFW\selenium-advance\SeleniumCFW\SeleniumCFW\HTML\index.html";
            mainPage = new MainPage(driver);
            mainPage.NavigateTo(pathToHtml);
        }

        [Test]
        public void TestPage()
        {
            mainPage.FillName("Alexis Texas");
            mainPage.FillEmail("a.texas@gmail.com");
            
            mainPage.SelectLanguage("Java");
            mainPage.CheckOnCoding();

            I.Pause(5000);
            I.Quit(driver);
        }
    }
}