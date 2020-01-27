using System.Collections.Generic;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public interface IUser
    {
        IEnumerable<IAuction> WonAuctions();

        void Delete();

        string Username { get; }
    }
}