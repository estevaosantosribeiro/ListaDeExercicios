namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaCelsius, temperaturaFahrenheit;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a temperatura em Celsius: ");
            temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

            temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é {temperaturaFahrenheit}°F");

            Console.ReadLine();
        }
    }
}
