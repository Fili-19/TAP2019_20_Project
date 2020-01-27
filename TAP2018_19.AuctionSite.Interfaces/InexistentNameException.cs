using System;
using System.Runtime.Serialization;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public class InexistentNameException : AuctionSiteException
    {
        public InexistentNameException(string name) { }

        public InexistentNameException(string name, string message) { }

        public InexistentNameException(string name, string message, Exception inner) { }

        public InexistentNameException(SerializationInfo info, StreamingContext context) { }

        public string Name { get; }
    }
}