namespace UnitsConversion;

public class Volume(float volumeInLiters)
{
    float _volumeInLiters = volumeInLiters;

    public static Volume FromLiters(float liters)
    {
        return new Volume(liters);
    }

    public static Volume FromMilliliters(float milliliters)
    {
        return new Volume(milliliters / 1000);
    }

    public static Volume FromImperialGallons(float gallons)
    {
        return new Volume(gallons * 4.546f);
    }

    public float ToLiters()
    {
        return _volumeInLiters;
    }

    public float ToImperialGallons()
    {
        return _volumeInLiters / 4.546f;
    }

    public float ToMilliliters()
    {
        return _volumeInLiters * 1000f;
    }

}