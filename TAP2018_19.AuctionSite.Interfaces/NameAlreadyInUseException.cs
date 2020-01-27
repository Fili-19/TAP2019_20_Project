using System;
using System.Runtime.Serialization;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public class NameAlreadyInUseException : AuctionSiteException
    {
        public NameAlreadyInUseException(string name) { }

        public NameAlreadyInUseException(string name, string message) { } 

        public NameAlreadyInUseException(string name, string message, Exception inner) { }

        public NameAlreadyInUseException(SerializationInfo info, StreamingContext context) { }

        public string Name { get; }
    }
}