namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase, totalVendas, comissao, percentualComissao, salarioTotal;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de salário total");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite o salário base: ");
            salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o total de vendas: ");
            totalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o percentual de comissão: ");
            percentualComissao = Convert.ToDecimal(Console.ReadLine());

            comissao = totalVendas * percentualComissao / 100;
            salarioTotal = salarioBase + comissao;

            Console.WriteLine($"O salário total é R$ {salarioTotal.ToString("F2")}");

            Console.ReadLine();
        }
    }
}
