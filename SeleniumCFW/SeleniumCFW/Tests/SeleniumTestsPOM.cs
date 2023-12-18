using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCFW.Based;
using SeleniumCFW.PageObjects;

namespace  SeleniumCFW
{
    [TestFixture]
    public class SeleniumTestsPOM
    {
        private IWebDriver driver;
        private MainPage mainPage;
        private BaseCommand I;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            I.MaximizeWindow(driver);
            I.Timeouts(driver,30);
            mainPage = new MainPage(driver);
            mainPage.NavigateTo(mainPage.basedURL);
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