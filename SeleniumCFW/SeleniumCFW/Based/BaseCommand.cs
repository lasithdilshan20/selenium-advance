using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCFW.Based;

public class BaseCommand
{
    public void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
    
    public void OpenBrowser(IWebDriver driver, String browserName,String Url)
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl(Url);
    }
    
    public void MaximizeWindow(IWebDriver driver)
    {
        driver.Manage().Window.Maximize();
    }
    
    public void Click(IWebDriver driver, String elementID)
    {
        driver.FindElement(By.Id(elementID)).Click();
    }
    
    public void SendKeys(IWebDriver driver, String elementID, String text)
    {
        driver.FindElement(By.Id(elementID)).SendKeys(text);
    }
    
    public void SelectByText(IWebDriver driver, By by, String text)
    {
        var dropDown = driver.FindElement(by);
        var selectElement = new SelectElement(dropDown);
        selectElement.SelectByText(text);
    }
    
    public void SelectByValue(IWebDriver driver, By by, String value)
    {
        var dropDown = driver.FindElement(by);
        var selectElement = new SelectElement(dropDown);
        selectElement.SelectByValue(value);
    }
    
    public void Timeouts(IWebDriver driver, int seconds)
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
    }
    
    public void Quit(IWebDriver driver)
    {
        driver.Quit();
    }
}