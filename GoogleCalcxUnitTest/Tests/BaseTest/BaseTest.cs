using GoogleCalcxUnitTest.PageObjects;

public class BaseTest
{
    private IWebDriver driver;
    
    public void TestSetup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "https://pastebin.com";
        // Perhaps there's a better way to wait for elements?
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Pages.Init(driver);
    }
    
    public void TestEnding()
    {
        driver.Quit();
    }
}