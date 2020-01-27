using System;
using System.Collections.Generic;
using System.ComponentModel;
using TAP2018_19.AuctionSite.Interfaces;
using ISite = TAP2018_19.AuctionSite.Interfaces.ISite;

namespace TAP2019_20_Project
{
    public class Site : ISite
    {
        public IEnumerable<IUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISession> GetSessions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAuction> GetAuctions(bool onlyNotEnded)
        {
            throw new NotImplementedException();
        }

        public ISession Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public ISession GetSession(string sessionId)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void CleanupSessions()
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
        public int Timezone { get; }
        public int SessionExpirationInSeconds { get; }
        public double MinimumBidIncrement { get; }
    }
}