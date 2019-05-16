using EAAutoFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
