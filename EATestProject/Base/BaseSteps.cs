using EAAutoFramework.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Base
{
    public class BaseSteps:Base
    {
        public virtual void NavigateSite()
        {
            DriverContext.Browser.GotoUrl(Settings.AUT);
        }
    }
}
