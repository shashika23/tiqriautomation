using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    class LoginSteps:BaseSteps
    {
        
        [Given(@"I enter username and the password and i clicked the login button")]
        public void WhenIEnterUsernameAndThePassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage = CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
            
        }

        [When(@"I should click the myleave button")]
        public void ThenIShouldTheSeeTheMyleaveButton()
        {

            CurrentPage = CurrentPage.As<HomePage>().navigatetoMyLeavePage();
            CurrentPage.As<MyLeavePage>().submitLeaveData();

        }

        [Then(@"I see the my leave")]
        public void ThenISeeTheMyLeave()
        {
            // sample code should be added here
        }

    }
}
