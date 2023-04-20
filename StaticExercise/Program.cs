namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var celcius = TempConverter.FahrenheitToCelsius(24);
            Console.WriteLine($"Celsius {celcius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(55);
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
