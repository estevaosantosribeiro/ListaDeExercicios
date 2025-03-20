namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal quilometragemInicial, quilometragemFinal, combustivelGasto, consumo;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Calculadora de consumo de combustível");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite a quilometragem inicial: ");
            quilometragemInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a quilometragem final: ");
            quilometragemFinal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o combustível gasto: ");
            combustivelGasto = Convert.ToDecimal(Console.ReadLine());

            consumo = (quilometragemFinal - quilometragemInicial) / combustivelGasto;

            Console.WriteLine($"O consumo médio é {consumo.ToString("F2")} km/L");

            Console.ReadLine();
        }
    }
}
