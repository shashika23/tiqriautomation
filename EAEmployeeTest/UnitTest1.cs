using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Initialize
    {

        [TestMethod]
        public void Login() {

            // write the page using generic class.
            LoginPage loginPage = new LoginPage();
            MyLeavePage myLeavePage = new MyLeavePage();
            HomePage homePage = loginPage.Login("use your name", "use your pwd");
            homePage.navigatetoMyLeavePage();
         
 
        }
    }
}
