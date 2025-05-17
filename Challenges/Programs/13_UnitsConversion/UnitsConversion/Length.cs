namespace UnitsConversion;

public class Length(float lengthInMeters)
{
    float _lengthInMeters = lengthInMeters;

    public static Length FromALinusSebastian(float aLinusSebastian)
    {
        return new Length(aLinusSebastian * 1.68f);
    }
    
    public static Length FromMillimeters(float millimeters)
    {
        return new Length(millimeters / 1000f);
    }

    public static Length FromCentimeters(float centimeters)
    {
        return new Length(centimeters / 100f);
    }

    public static Length FromMeters(float meters)
    {
        return new Length(meters);
    }

    public static Length FromKilometers(float kilometers)
    {
        return new Length(kilometers * 1000f);
    }

    public static Length FromInches(float inches)
    {
        return new Length(inches / 39.37f);
    }

    public static Length FromFoots(float foots)
    {
        return new Length(foots / 3.281f);
    }

    public static Length FromYards(float yards)
    {
        return new Length(yards / 1.094f);
    }

    public static Length FromMiles(float miles)
    {
        return new Length(miles * 1609.344f);
    }

    public float ToALinusSebastian()
    {
        return _lengthInMeters / 1.68f;
    }

    public float ToMillimeters()
    {
        return _lengthInMeters * 1000f;
    }

    public float ToCentimeters()
    {
        return _lengthInMeters * 100f;
    }

    public float ToMeters()
    {
        return _lengthInMeters;
    }

    public float ToKilometers()
    {
        return _lengthInMeters / 1000f;
    }

    public float ToInches()
    {
        return _lengthInMeters * 39.37f;
    }

    public float ToFoots()
    {
        return _lengthInMeters * 3.281f;
    }

    public float ToYards()
    {
        return _lengthInMeters * 1.094f;
    }

    public float ToMiles()
    {
        return _lengthInMeters / 1609.344f;
    }
}