namespace UnitsConversion;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter time in seconds: ");
                var timeInSeconds = float.Parse(Console.ReadLine() ?? string.Empty);
                HandleTime(timeInSeconds);

                Console.Write("Enter volume in liters: ");
                var volumeInLiters = float.Parse(Console.ReadLine() ?? string.Empty);
                HandleVolume(volumeInLiters);

                Console.Write("Enter length in meters: ");
                var lengthInMeters = float.Parse(Console.ReadLine() ?? string.Empty);
                HandleLength(lengthInMeters);

                Console.Write("Enter weight in grams: ");
                var weightInGrams = float.Parse(Console.ReadLine() ?? string.Empty);
                HandleWeight(weightInGrams);

                Console.Write("Enter temperature in Celsius: ");
                var temperatureInCelsius = float.Parse(Console.ReadLine() ?? string.Empty);
                HandleTemperature(temperatureInCelsius);
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Do you want to exit? (y/n): ");
                Console.ResetColor();
                var key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Y) break;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e);
                Console.ResetColor();
            }
        }

        static void HandleTime(float timeInSeconds)
        {
            var time = Time.FromSeconds(timeInSeconds);

            Console.WriteLine("Time Breakdown:");
            Console.WriteLine($"\tDays         : {time.ToDays()}");
            Console.WriteLine($"\tHours        : {time.ToHours()}");
            Console.WriteLine($"\tMinutes      : {time.ToMinutes()}");
            Console.WriteLine($"\tSeconds      : {time.ToSeconds()}");
            Console.WriteLine($"\tMilliseconds : {time.ToMilliSeconds()}");
        }

        static void HandleVolume(float liters)
        {
            var volume = Volume.FromLiters(liters);

            Console.WriteLine("Volume Breakdown:");
            Console.WriteLine($"\tLiters      : {volume.ToLiters()} L");
            Console.WriteLine($"\tMilliliters : {volume.ToMilliliters()} mL");
            Console.WriteLine($"\tGallons     : {volume.ToImperialGallons()} gal");
        }

        static void HandleLength(float lengthInMeters)
        {
            var length = Length.FromMeters(lengthInMeters);

            Console.WriteLine("Length Breakdown:");
            Console.WriteLine($"\tMeters      : {length.ToMeters()}");
            Console.WriteLine($"\tKilometers  : {length.ToKilometers()}");
            Console.WriteLine($"\tCentimeters : {length.ToCentimeters()}");
            Console.WriteLine($"\tFoots       : {length.ToFoots()}");
            Console.WriteLine($"\tInches      : {length.ToInches()}");
            Console.WriteLine($"\tYards       : {length.ToYards()}");
            Console.WriteLine($"\tMiles       : {length.ToMiles()}");
        }

        static void HandleWeight(float weightInGrams)
        {
            var weight = Weight.FromGrams(weightInGrams);

            Console.WriteLine("Weight Breakdown:");
            Console.WriteLine($"\tMilligrams : {weight.ToMilligrams()}");
            Console.WriteLine($"\tGrams      : {weight.ToGrams()}");
            Console.WriteLine($"\tKilograms  : {weight.ToKilograms()}");
            Console.WriteLine($"\tPounds     : {weight.ToPounds()}");
        }

        static void HandleTemperature(float temperatureInCelsius)
        {
            var temp = Temperature.FromCelsius(temperatureInCelsius);

            Console.WriteLine("Temperature Breakdown:");
            Console.WriteLine($"\tCelsius    : {temp.ToCelsius()} °C");
            Console.WriteLine($"\tFahrenheit : {temp.ToFahrenheit()} °F");
            Console.WriteLine($"\tKelvin     : {temp.ToKelvin()} K");
        }
    }
}