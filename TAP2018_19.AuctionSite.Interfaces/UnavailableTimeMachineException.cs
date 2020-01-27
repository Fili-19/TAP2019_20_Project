using System;
using System.Runtime.Serialization;

namespace TAP2018_19.AuctionSite.Interfaces
{
    public class UnavailableTimeMachineException : AuctionSiteException
    {
        public UnavailableTimeMachineException() { }

        public UnavailableTimeMachineException(string message) { }

        public UnavailableTimeMachineException(string message, Exception inner) { }

        public UnavailableTimeMachineException(SerializationInfo info, StreamingContext context) { }
    }
}