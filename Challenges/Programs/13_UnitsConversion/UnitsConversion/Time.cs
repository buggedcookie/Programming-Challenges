namespace UnitsConversion;

public class Time(float timeInSeconds)
{
    float _timeInSeconds = timeInSeconds;

    public static Time FromMilliSeconds(float timeInMilliseconds)
    {
        return new Time(timeInMilliseconds * 1000);
    }

    public static Time FromSeconds(float timeInSeconds)
    {
        return new Time(timeInSeconds);
    }

    public static Time FromMinutes(float timeInMinutes)
    {
        return new Time(timeInMinutes * 60);
    }

    public static Time FromHours(float timeInHours)
    {
        return new Time(timeInHours * 3600);
    }

    public static Time FromDays(float timeInDays)
    {
        return new Time(timeInDays * 86400);
    }

    public float ToMilliSeconds()
    {
        return _timeInSeconds / 1000f;
    }

    public float ToSeconds()
    {
        return _timeInSeconds;
    }

    public float ToMinutes()
    {
        return _timeInSeconds / 60;
    }

    public float ToHours()
    {
        return _timeInSeconds / 3600;
    }

    public float ToDays()
    {
        return _timeInSeconds / 86400;
    }
}