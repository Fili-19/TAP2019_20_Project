using System;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public interface ISession
    {
        bool IsValid();

        void Logout();

        IAuction CreateAuction(string description, DateTime endsOn, double startingPrice);

        string Id { get; }
        DateTime ValidUntil { get; }
        IUser User { get; }
    }
}