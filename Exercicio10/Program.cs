namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadePaes, quantidadeBroas;
            decimal totalArrecadado, totalPoupanca;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de arrecadação da padaria Hotpão");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a quantidade de pães vendidos: ");
            quantidadePaes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de broas vendidas: ");
            quantidadeBroas = Convert.ToInt32(Console.ReadLine());

            totalArrecadado = (quantidadePaes * 0.12m) + (quantidadeBroas * 1.50m);
            totalPoupanca = totalArrecadado * 0.10m;

            Console.WriteLine($"O total arrecadado foi de R$ {totalArrecadado}");
            Console.WriteLine($"O total a ser guardado na poupança é de R$ {totalPoupanca}");
            Console.ReadLine();
        }
    }
}
