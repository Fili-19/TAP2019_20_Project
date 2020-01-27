using System;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public interface IAuction
    {
        IUser CurrentWinner();

        double CurrentPrice();

        void Delete();

        bool BidOnAuction(ISession session, double offer);

        int Id { get; }
        IUser Seller { get; }
        string Description { get; }
        DateTime EndsOn { get; }
    }
}