using System;

namespace Numeros_Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDigite um numero: \n");
            int a = int.Parse(Console.ReadLine());

            if( a < 0)
            {
                Console.WriteLine("\n" + a + " É um número NEGATIVO");
            }

            else
            {
                Console.WriteLine("\n" + a + " É um número POSITIVO");
            }

        }
    }
}
