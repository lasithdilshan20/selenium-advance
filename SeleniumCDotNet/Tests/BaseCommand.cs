using OpenQA.Selenium;

namespace SeleniumCDotNet.Based;

public class BaseCommand
{
    public void Click(IWebDriver driver, String elementID)
    {
        driver.FindElement(By.Id(elementID)).Click();
    }
}