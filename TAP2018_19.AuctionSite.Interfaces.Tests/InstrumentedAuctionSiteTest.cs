using Ninject;
using NUnit.Framework;
using TAP2018_19.AlarmClock.Interfaces;

namespace TAP2018_19.AuctionSite.Interfaces.Tests
{
    [TestFixture]
    public abstract class InstrumentedAuctionSiteTest
    {
        protected static readonly IAlarmClockFactory AnAlarmClockFactory;
        protected static readonly ISiteFactory AnAuctionSiteFactory;

        static InstrumentedAuctionSiteTest()
        {
            var kernel = new StandardKernel();
            kernel.Load(Conﬁguration.ClockImplementationAssembly);
            AnAlarmClockFactory = kernel.Get<IAlarmClockFactory>();
            kernel.Load(Conﬁguration.ImplementationAssembly);
            AnAuctionSiteFactory = kernel.Get<ISiteFactory>();
        }
    }
}