using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace EAEmployeeTest.Pages
{
    class MyLeavePage : BasePage
    {


        [FindsBy(How = How.CssSelector, Using = "label > button:nth-child(1)")]
        private IWebElement btnSubmit { get; set; }


        public HomePage submitLeaveData() {
           // btnSubmit.Click();
            return GetInstance<HomePage>();
        }
        
     }
}
