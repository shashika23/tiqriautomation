using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Initialize
    {

        [TestMethod]
        public void Login() {

            LoginPage loginPage = new LoginPage();
            MyLeavePage myLeavePage = new MyLeavePage();
            HomePage homePage = loginPage.Login("Shashika", "use your password");
            homePage.navigatetoMyLeavePage();
         
 
        }
    }
}
