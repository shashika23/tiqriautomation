using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Initialize
    {
        [TestMethod]
        public void Login() {
                      
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage = CurrentPage.As<LoginPage>().Login("shashika ", "Zn1heZ");
            CurrentPage = CurrentPage.As<HomePage>().navigatetoMyLeavePage();
            CurrentPage.As<MyLeavePage>().submitLeaveData();

        }
    }
}
