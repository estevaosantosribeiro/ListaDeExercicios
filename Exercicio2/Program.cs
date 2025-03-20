namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume, pi;

            pi = Math.PI;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de volume de cilindro");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite o raio do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = pi * (raio * raio) * altura;

            Console.WriteLine($"O volume do cilindro é {volume.ToString("F2")} cm³");

            Console.ReadLine();
        }
    }
}
