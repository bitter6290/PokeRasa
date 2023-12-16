using System;
public enum TimeOfDay
{
    Morning,
    Day,
    Evening,
    Night,

}

public static class TimeUtils
{
    public static TimeOfDay timeOfDay => DateTime.Now.Hour switch
    {
        < 6 => TimeOfDay.Night,
        < 10 => TimeOfDay.Morning,
        < 19 => TimeOfDay.Day,
        19 => TimeOfDay.Evening,
        _ => TimeOfDay.Night
    };
}

