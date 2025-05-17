namespace UnitsConversion;

public class Weight(float weightInGrams)
{
    float _weightInGrams = weightInGrams;

    public static Weight FromMilligrams(float miligrams)
    {
        return new Weight(miligrams / 1000f);
    }
    
    public static Weight FromGrams(float grams)
    {
        return new Weight(grams);
    }
    
    public static Weight FromKilogram(float weightInKg)
    {
        return new Weight(weightInKg*1000f);
    }

    public static Weight FromPounds(float weightInPounds)
    {
        return new Weight(weightInPounds * 453.6f);
    }

    public float ToMilligrams()
    {
        return _weightInGrams*1000f;
    }

    public float ToGrams()
    {
        return _weightInGrams;
    }

    public float ToKilograms()
    {
        return _weightInGrams / 1000f;
    }

    public float ToPounds()
    {
        return _weightInGrams / 453.6f;
    }
}