using EAAutoFramework.Base;
using TechTalk.SpecFlow;
using static EAAutoFramework.Base.Browser;

namespace EAEmployeeTest
{
    [Binding]
    public class Initialize : TestInit
    {
        //init
        public Initialize() : base(BrowserType.Chorme) {
            InitializeSettings();
            NavigateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            Initialize init = new Initialize();
        }
    }
}
