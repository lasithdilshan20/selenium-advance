using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCDotNet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Console.WriteLine("Setup");
            //Driver = new CromeDriver();;

        }
        [Test]
        public void Test1()
        {

            {
                {
                    // Specify the path to the chromedriver.exe
                    string chromeDriverPath = @"C:\Users\Glesh\source\repos\SeleniumCDotNet\Drivers\chromedriver.exe";

                    // Set the path for ChromeDriver
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("start-maximized"); // You can add additional options if needed
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService(chromeDriverPath);
                    IWebDriver driver = new ChromeDriver(service, options);

                    // Navigate to Google
                    driver.Navigate().GoToUrl("https://www.google.com");

                    // Perform some actions or assertions if needed
                    // For example, you can find an element by its name and perform a search
                    IWebElement searchBox = driver.FindElement(By.Name("q"));
                    searchBox.SendKeys("Selenium with C#");
                    searchBox.Submit();

                    // Wait for a few seconds to see the result
                    System.Threading.Thread.Sleep(5000);

                    // Close the browser
                    driver.Quit();
                }
            }
        }
    }
}