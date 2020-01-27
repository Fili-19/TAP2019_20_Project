namespace TAP2018_19.AlarmClock.Interfaces
{
    public interface IAlarmClockFactory
    {
        IAlarmClock InstantiateAlarmClock(int timezone);
    }
}