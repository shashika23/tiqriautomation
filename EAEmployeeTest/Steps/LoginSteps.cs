﻿using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    class LoginSteps:BaseSteps
    {
        [Given(@"I have navigated to the login screen")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
        }

        [When(@"I enter username and the password and i clicked the login button")]
        public void WhenIEnterUsernameAndThePassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage = CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
            

           /* LoginPage loginPage = new LoginPage();
            HomePage homePage = loginPage.Login(data.UserName, data.Password);*/
        }

        [Then(@"I should click the myleave button")]
        public void ThenIShouldTheSeeTheMyleaveButton()
        {

            CurrentPage = CurrentPage.As<HomePage>().navigatetoMyLeavePage();
            CurrentPage.As<MyLeavePage>().submitLeaveData();

            /*HomePage homePage = new HomePage();
            MyLeavePage myLeavePage = homePage.navigatetoMyLeavePage();*/

        }
    }
}
