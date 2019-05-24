using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class HomePage : BasePage{

    
        [FindsBy(How = How.CssSelector, Using = "div#body a:nth-child(4) > img")]
        private IWebElement lnkMyLeave { get; set; }


        public MyLeavePage navigatetoMyLeavePage() {
            lnkMyLeave.Click();
            return GetInstance<MyLeavePage>();

        }


    }
}
