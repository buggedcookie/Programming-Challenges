namespace TemperatureConverter;

public class Temperature(float temperatureInCelCius)
{
    float _temperatureInCelsius = temperatureInCelCius;

    public static Temperature FromCelsius(float temperatureInCelsius)
    {
        return new Temperature(temperatureInCelsius);
    }

    public static Temperature FromFahrenheit(float temperatureInFahrenheit)
    {
        float inCelsius = temperatureInFahrenheit - 32 / 1.8f ;
        return new Temperature(inCelsius);
    }

    public static Temperature FromKelvin(float temperatureInKelvin)
    {
        float inCelsius = temperatureInKelvin - 273.15f;
        
        return new Temperature(inCelsius);
    }
    
    public float ToCelsius()
    {
        return _temperatureInCelsius;
    }

    public float ToFahrenheit()
    {
        return _temperatureInCelsius * 1.8f + 32f;
    }

    public float ToKelvin()
    {
        return _temperatureInCelsius + 273.15f;
    }
}