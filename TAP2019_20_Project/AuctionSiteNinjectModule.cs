using System.Data.Entity;
using System.Reflection;
using System.Security;
using Ninject.Modules;
using TAP2018_19.AuctionSite.Data;
using TAP2018_19.AuctionSite.Interfaces;

[assembly: AllowPartiallyTrustedCallers]

namespace TAP2019_20_Project
{   
   
    [SecurityCritical]
    public class AuctionSiteNinjectModule : NinjectModule
    {
        [SecurityCritical]
        public override void Load()
        {
            Database.SetInitializer<ASContext>(null);
            this.Bind<ISiteFactory>().To<SiteFactory>();
            this.Bind<ISite>().To<Site>();
            this.Bind<IAuction>().To<Auction>();
            this.Bind<ISession>().To<Session>();
            this.Bind<IUser>().To<User>();
        }
    }
}