namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal mediaPonderada, nota1, nota2, peso1, peso2;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de média ponderada");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o peso da primeira nota: ");
            peso1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o peso da segunda nota: ");
            peso2 = Convert.ToDecimal(Console.ReadLine());

            mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada é {mediaPonderada.ToString("F2")}");

            Console.ReadLine();
        }
    }
}
