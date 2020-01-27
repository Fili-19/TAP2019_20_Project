using System.Collections.Generic;
using TAP2018_19.AlarmClock.Interfaces;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public interface ISiteFactory
    {
        void Setup(string connectionString);

        IEnumerable<string> GetSiteNames(string connectionString);

        void CreateSiteOnDb(string connectionString, string name, int timezone, int sessionExpirationTimeInSeconds,
            double minimumBidIncrement);

        ISite LoadSite(string connectionString, string name, IAlarmClock alarmClock);

        int GetTheTimezoneOf(string connectionString, string name);
    }
}