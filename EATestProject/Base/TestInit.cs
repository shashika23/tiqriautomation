using EAAutoFramework.Config;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using static EAAutoFramework.Base.Browser;

namespace EAAutoFramework.Base
{
    public abstract class TestInit : Base
    {
        public readonly BrowserType Browser;

        public TestInit(BrowserType browser) {
            Browser = browser;
        }
        
        public void InitializeSettings() {
            ConfigReader.SetFrameWorkSettings();
            OpenBrowser(Browser);
        }

        private void OpenBrowser(BrowserType browserType)
        {

            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chorme:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        public virtual void NavigateSite() {
            DriverContext.Browser.GotoUrl(Settings.AUT);
        }

    }
}
