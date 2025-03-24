namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Verificador de número primo");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero < 2)
            {
                Console.WriteLine("O número não é primo");
            }
            else
            {
                bool primo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                {
                    Console.WriteLine("O número é primo");
                }
                else
                {
                    Console.WriteLine("O número não é primo");
                }
            }

            Console.ReadLine();
        }
    }
}
