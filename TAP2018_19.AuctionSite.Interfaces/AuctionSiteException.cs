using System;
using System.Runtime.Serialization;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public class AuctionSiteException : Exception
    {
        protected AuctionSiteException() {}

        protected AuctionSiteException(string message) {}

        protected AuctionSiteException(string message, Exception inner) {}

        protected AuctionSiteException(SerializationInfo info, StreamingContext context) {}
    }
}