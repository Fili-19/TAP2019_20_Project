using System;

namespace TAP2018_19.AlarmClock.Interfaces
{
    public interface IAlarm : IDisposable
    {
        event Action RingingEvent;
    }
}