using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement txtPassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "button-blue")]
        private IWebElement btnLogin { get; set; }

        


        public HomePage Login(string userName, string password) {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();
            return new HomePage();
        }

    }
}
