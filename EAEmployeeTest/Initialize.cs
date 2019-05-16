using EAAutoFramework.Base;

using static EAAutoFramework.Base.Browser;

namespace EAEmployeeTest
{
    public class Initialize : TestInit
    {

        public Initialize() : base(BrowserType.Chorme) {
            InitializeSettings();
            NavigateSite();
        }
    }
}
