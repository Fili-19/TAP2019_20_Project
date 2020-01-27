using System;

namespace TAP2018_19.AlarmClock.Interfaces
{
    public interface IAlarmClock
    {
        IAlarm InstantiateAlarm(int frequencyInMs);

        int Timezone { get; }
        DateTime Now { get; }
    }
}