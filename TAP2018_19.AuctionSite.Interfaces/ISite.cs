using System.Collections.Generic;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public interface ISite
    {
        IEnumerable<IUser> GetUsers();

        IEnumerable<ISession> GetSessions();

        IEnumerable<IAuction> GetAuctions(bool onlyNotEnded);

        ISession Login(string username, string password);

        ISession GetSession(string sessionId);

        void CreateUser(string username, string password);

        void Delete();

        void CleanupSessions();

        string Name { get; }
        int Timezone { get; }
        int SessionExpirationInSeconds { get; }
        double MinimumBidIncrement { get; }
    }
}