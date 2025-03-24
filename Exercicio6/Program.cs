namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal mediaHarmonica, nota1, nota2, nota3;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de média harmônica");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            mediaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

            Console.WriteLine($"A média harmônica é {mediaHarmonica.ToString("F2")}");

            Console.ReadLine();
        }
    }
}
