namespace GoogleCalcxUnitTest.PageObjects;

internal class Pages : BaseTest
{
    public static HomePage Home;
    public static CalculatorPage Calculator;
    public static SearchResultsPage SearchResults;
    public static TempailPage Email;

    public static void Init(IWebDriver driver)
    {
        Home = new HomePage(driver);
        Calculator = new CalculatorPage();
        SearchResults = new SearchResultsPage();
        Email = new TempailPage();
    }
}