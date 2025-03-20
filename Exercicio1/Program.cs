namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal altura, largura, comprimento, volume;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de volume de caixa retangular");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a altura da caixa: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a largura da caixa: ");
            largura = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a comprimento da caixa: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            volume = altura * largura * comprimento;

            Console.WriteLine($"O volume da caixa retangular é {volume.ToString("F2")} cm³");

            Console.ReadLine();
        }
    }
}
