using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();

            Console.WriteLine("Ingresar lados de un rectangulo");
            Console.WriteLine("lado 1: ");
            rectangulo.lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lado 2: ");
            rectangulo.lado2 = Convert.ToDouble(Console.ReadLine());
            if (rectangulo.lado1 != rectangulo.lado2)
            {
                rectangulo.EsRectangulo();
            }
            else
            {
                Console.WriteLine("No ingreso los valores apropiados para un rectangulo");
            }

            // ejercicio 5.1
            // persona per = new persona();
            //int sumador = 0;
            // for ( int i= 1; i<=3; i++)
            // {
            //     Console.WriteLine("ingrese datos de la persona {0}: ", i);
            //     Console.WriteLine("nombre");
            //     per.nombre = Console.ReadLine();
            //     Console.WriteLine("apellido");
            //     per.apellido = Console.ReadLine();
            //     Console.WriteLine("edad");
            //     per.edad = Convert.ToInt32(Console.ReadLine());
            //     sumador += per.edad;
            //     per.mostrarinfo();
            // }
            // Console.WriteLine("Promedio de edades: {0}", sumador/3);
        }

        public class Rectangulo
        {
            public Rectangulo(){ }

            public double lado1;
            public double lado2;

            public void EsRectangulo()
            {
                Console.WriteLine("Ha ingresado un rectangulo de " + lado1 + " por " + lado2);
            }
        }
        // ejercicio 5.1
        //public class persona
        //{
        //    public persona() { }
        //    public string nombre;
        //    public int edad;
        //    public string apellido;
        //    public void mostrarinfo()
        //    {
        //        Console.WriteLine("Persona: " + nombre + " " + apellido +" "+ edad);
        //    }
        //}
    }
}
