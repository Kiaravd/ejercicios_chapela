using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejerprueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Información de la compañia");
                Console.WriteLine("Cuantos autos posee la compañia?");
                try
                {
                    int cant = Convert.ToInt32(Console.ReadLine());
                    Agencia agencia = new Agencia(cant);
                    Console.WriteLine("Ingresar nombre de la agencia");
                    agencia.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresar dirección de la agencia");
                    agencia.direccion = Console.ReadLine();
                    Console.WriteLine("Ingresar titular de la agencia");
                    agencia.titular = Console.ReadLine();

                    for (int i = 0; i < cant; i++)
                    {
                        Console.WriteLine("Marca del auto {0}", i + 1);
                        agencia.Marca = Console.ReadLine();
                        Console.WriteLine("Modelo del auto {0}", i + 1);
                        agencia.Modelo = Console.ReadLine();
                        Console.WriteLine("Año del auto {0}", i + 1);
                        agencia.Año = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Peso del chasis del auto {0}", i + 1);
                        agencia.Peso = Convert.ToInt32(Console.ReadLine());

                    }

                    agencia.Mostrar();
                }
                catch (FormatException e) { Console.WriteLine(e.Message); }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
        public class Agencia
        {
            public Agencia(int cant) { cant_autos = cant; marca = new string[cant]; modelo = new string[cant]; año = new int[cant]; peso_chasis = new int[cant]; }
            private string nombre;
            private int cant_autos;
            private string[] marca;
            private string[] modelo;
            private int[] año;
            private int[] peso_chasis;
            int cant_privado = 0;
            public string Nombre
            {
                set { nombre = value.ToUpper(); }
                get { return nombre; }
            }
            public string direccion { get; set; }
            public string titular { get; set; }
            public string Marca
            {
                set { marca[cant_privado] = value; }
                get { return marca[cant_privado]; }
            }
            public string Modelo
            {
                set { modelo[cant_privado] = value; }
                get { return modelo[cant_privado]; }
            }
            public int Año
            {
                set { año[cant_privado] = value; }
                get { return año[cant_privado]; }
            }
            public int Peso
            {
                set { peso_chasis[cant_privado] = value; cant_privado++; }
                get { return peso_chasis[cant_privado]; }
            }

            public void Mostrar()
            {
                int pesoTot = 0;
                int cant2021 = 0;
                for (int i = 0; i < peso_chasis.Length; i++) { pesoTot += peso_chasis[i]; }
                for (int i = 0; i < año.Length; i++)
                {
                    if (año[i] >= 2021) { cant2021++; }
                }
                Console.WriteLine("Agencia {0} con direccion en {1} y el titular de esta es {2}", nombre, direccion, titular);
                Console.WriteLine("Cantidad de autos en la agencia: {0}", cant_autos);
                Console.WriteLine("Peso total de en chasis: {0}", pesoTot);
                Console.WriteLine("Peso promedio de chasis: {0}", pesoTot / cant_autos);
                Console.WriteLine("Cantidad de autos mayores o iguales a 2021: {0}", cant2021);
            }
        }
    }
}
