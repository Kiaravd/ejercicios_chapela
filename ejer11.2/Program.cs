using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> animales = new List<string>();
            animales.Add("Delfin");
            animales.Add("León");
            animales.Add("Canguro");
            animales.Add("Pelicano");
            animales.Add("Rinoceronte");
            Console.WriteLine("Ingrese un nombre");
            string nombre = Console.ReadLine();
            animal anim = new animal(nombre);

            anim.insertar(animales);
            anim.leer();

        }
        public class animal
        {
            public animal(string nom) { nombreNuevo = nom; }
            string nombreNuevo;
            string ruta = "C:\\prueba\\";
            string archivo = "animales.txt";
            public void insertar( List <string> nombres)
            {
                int index = 0;
                for(int i = 0; i < nombres.Count(); i++)
                {
                    if (nombres[i] == "León")
                    {
                        index = i; break;
                    }
                }
                nombres.Insert(index + 1, nombreNuevo);

                StreamWriter objtxt;
                objtxt = File.CreateText(ruta + archivo);

                foreach(string nom in nombres)
                {
                    objtxt.WriteLine(nom);
                }
                objtxt.Close();
                Console.WriteLine("Archivo creado y escrito");

            }
            public void leer() {
                StreamReader objtxt;
                objtxt = File.OpenText(ruta + archivo);

                string linea = objtxt.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = objtxt.ReadLine();
                }
                objtxt.Close();
                Console.WriteLine("Archivo cerrado");

            }
        }
    }
}
