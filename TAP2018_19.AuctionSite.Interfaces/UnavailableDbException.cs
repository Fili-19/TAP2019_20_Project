using System;
using System.Runtime.Serialization;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public class UnavailableDbException : AuctionSiteException
    {
        public UnavailableDbException() { }

        public UnavailableDbException(string message) { }

        public UnavailableDbException(string message, Exception inner) { }

        public UnavailableDbException(SerializationInfo info, StreamingContext context) { }
    }
}