namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal larguraTerreno, comprimentoTerreno;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de área de terreno");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Digite a largura do terreno: ");
            larguraTerreno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimentoTerreno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A área do terreno é {larguraTerreno * comprimentoTerreno} m²");

            Console.ReadLine();
        }
    }
}
