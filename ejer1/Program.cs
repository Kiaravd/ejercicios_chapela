using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumador = 0;
            for (int i = 1; i<=3; i++)
            {
                Console.WriteLine("Ingrese numero {0}", i);
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("{0} es par", numero);
                }
                else
                {
                    Console.WriteLine("{0} es impar", numero);
                }
                sumador += numero;
            }
            Console.WriteLine("Promedio de los numeros es: {0}", sumador / 3);
        }
    }
}
