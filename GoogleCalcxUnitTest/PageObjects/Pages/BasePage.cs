namespace GoogleCalcxUnitTest.PageObjects.BasePage;
{
    public class BasePage
    {
        private readonly string url;
        private readonly Header header;

        public BasePage(string url)
        {
            this.url = url;
            this.header = new Header();
        }

        public void Open()
        {
            driver.Url = this.url;
        }
    }
}
