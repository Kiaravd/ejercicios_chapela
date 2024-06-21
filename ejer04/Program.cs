using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona per = new persona();

            per.nombre = "Susana";
            per.edad = 11;
            per.nacionalidad = "India";
            per.mostrarinfo();

            persona per2 = new persona(1,"susi", "arg");
            per2.mostrarinfo();

        }
        public class persona
        {
            public persona() { }
            public persona(int ed, string nom, string na) {
                edad = ed;
                nombre = nom;
                nacionalidad = na;
            }
            public int edad;
            public string nombre;
            public string nacionalidad;
            public void mostrarinfo()
            {
                Console.WriteLine(nombre);
                Console.WriteLine(edad);
                Console.WriteLine(nacionalidad);
            }
        }
    }
}
