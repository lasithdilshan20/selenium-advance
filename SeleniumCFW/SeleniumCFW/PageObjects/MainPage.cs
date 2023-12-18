using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCFW.PageObjects;

public class MainPage
{
    private readonly IWebDriver _driver;
    private By TXT_Name => By.Id("name");
    private By TXT_Email => By.Id("email");
    
    public MainPage(IWebDriver driver)
    {
        _driver = driver;
    }
    
    public void NavigateTo(String url)
    {
        _driver.Navigate().GoToUrl(url);
    }
    
    public void FillName(String name)
    {
        _driver.FindElement(TXT_Name).SendKeys(name);
    }
    
    public void FillEmail(String email)
    {
        _driver.FindElement(TXT_Email).SendKeys(email);
    }
    
    public void CheckOnCoding()
    {
        _driver.FindElement(By.Id("coding")).Click();
    }
    
    public void SelectLanguage(String language)
    {
        var dropDownLanguage = _driver.FindElement(By.Id("dropdown"));
        var selectElement = new SelectElement(dropDownLanguage);
        selectElement.SelectByText(language);
    }
}