namespace TemperatureConverter;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the temperature in Celsius");
            Console.Write("Temperature in Celsius: ");
            Console.ResetColor();
            
            var input = Console.ReadLine() ?? string.Empty;
            if(input == "--exit") break;
            if (input == "--clear")
            {
                Console.Clear();
                continue;
            }
            
            float temperatureInCelsius = float.Parse(input);
            
            var inFahrenheit = Temperature.FromCelsius(temperatureInCelsius).ToFahrenheit();
            var inKelvin  = Temperature.FromCelsius(temperatureInCelsius).ToKelvin();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Temperature in Celsius: {input}\u00b0C");
            Console.WriteLine($"Temperature in Fahrenheit: {inFahrenheit}\u00b0F");
            Console.WriteLine($"Temperature in Kelvin: {inKelvin}K");
            Console.ResetColor();
        }
    }
}