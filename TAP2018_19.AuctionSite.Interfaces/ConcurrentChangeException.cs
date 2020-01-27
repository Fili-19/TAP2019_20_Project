using System;
using System.Runtime.Serialization;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public class ConcurrentChangeException : AuctionSiteException
    {
        public ConcurrentChangeException() {}

        public ConcurrentChangeException(string message) {}

        public ConcurrentChangeException(string message, Exception inner) {}

        protected ConcurrentChangeException(SerializationInfo info, StreamingContext context) {}
    }
}