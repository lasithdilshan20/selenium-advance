using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCFW.Based;

public class BaseCommand
{
    public void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
    
    public void MaximizeWindow(IWebDriver driver)
    {
        driver.Manage().Window.Maximize();
    }
    
    public void Click(IWebDriver driver, By by)
    {
        driver.FindElement(by).Click();
    }
    
    public void SendKeys(IWebDriver driver, By by, String text)
    {
        driver.FindElement(by).SendKeys(text);
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