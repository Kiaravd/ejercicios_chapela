using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos autos desea ingresar para la agencia?");
            int num_autos = 0;
            try
            {
                num_autos = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException){ Console.WriteLine("El formato es incorrecto");}

            agencia infoAgencia = new agencia( num_autos);
            Console.WriteLine("Ingrese el nombre de la agencia:");
            infoAgencia.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección de la agencia:");
            infoAgencia.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del titular de la agencia:");
            infoAgencia.Titular = Console.ReadLine();
            try
            {
                for (int i = 0; i < num_autos; i++)
                {
                    Console.WriteLine("Marca del auto {0}: ", i + 1);
                    infoAgencia.marca[i] = Console.ReadLine();
                    Console.WriteLine("Año del auto {0}: ", i + 1);
                    infoAgencia.año[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Modelo del auto {0}: ", i + 1);
                    infoAgencia.modelo[i] = Console.ReadLine();
                    Console.WriteLine("Peso del chasis {0}: ", i + 1);
                    infoAgencia.peso_chasis[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato invalido");
            }

            infoAgencia.Mostrar(num_autos);

        }
        public class agencia
        {
            public agencia(int cant) { marca = new string[cant]; modelo = new string[cant]; año = new int[cant]; peso_chasis = new int[cant]; }

            private string nombre;
            private string direccion;
            private string titular;
            public string[] marca;
            public string[] modelo;
            public int[] año;
            public int[] peso_chasis;
            public string Nombre
            {
                set { nombre = value.ToUpper(); }
                get { return nombre; }
            }
            public string Direccion
            {
                set { direccion = value; }
                get { return direccion; }
            }
            public string Titular
            {
                set { titular = value; }
                get { return titular; }
            }
            public void Mostrar(int cant) {
                int peso_tot = 0;
                int autos_2021 = 0;
                Console.WriteLine("Cantidad de autos: {0} ", cant);
                for (int i = 0; i < peso_chasis.Length; i++) {peso_tot += peso_chasis[i]; }
                Console.WriteLine("El peso total de los chasis es: {0} y el peso promedio es: {1}", peso_tot, (peso_tot / cant));
                for (int i = 0;i < año.Length; i++) { if (año[i] >= 2021) { autos_2021++; } }
                Console.WriteLine("Cantidad de autos mayores o iguales a 2021: {0}",autos_2021);

            }
        }
    }
}
