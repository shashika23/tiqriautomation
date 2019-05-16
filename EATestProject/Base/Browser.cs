using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrowserType Type { get; set; }

        public void GotoUrl(string url)
        {
            DriverContext.Driver.Navigate().GoToUrl(url);
        }       
    
        public enum BrowserType
        {
            Chorme,
            InternetExplorer,
            Firefox,
            Safari,
            Opera
        }


    }
}
