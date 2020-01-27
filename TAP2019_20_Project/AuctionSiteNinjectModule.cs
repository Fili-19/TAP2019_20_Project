using System.Reflection;
using System.Security;
using Ninject.Modules;

[assembly: AllowPartiallyTrustedCallers]

namespace TAP2019_20_Project
{   
   
    [SecurityCritical]
    public class AuctionSiteNinjectModule : NinjectModule
    {
        [SecurityCritical]
        public override void Load()
        {
            throw new System.NotImplementedException();
        }
    }
}