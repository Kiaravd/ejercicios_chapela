using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static ejer12.Program;

namespace ejer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Nombre nom = new Nombre();
                List<string> nombres = new List<string>();
                string ruta = "C:\\prueba\\";
                string nombre = "nombres.txt";
                StreamReader objtxt;
                objtxt = File.OpenText(ruta + nombre);
                string linea;
                linea = objtxt.ReadLine();
                while (linea != null)
                {
                    nombres.Add(linea);
                    linea = objtxt.ReadLine();
                }

                Console.WriteLine("Qué nombre desea insertar?");
                string name = Console.ReadLine();
                Console.WriteLine("En que posicion desea insertar el nombre?");
                for (int i = 0; i < nombres.Count; i++) { Console.WriteLine(i); }
                int index;

                try
                {
                    index = Convert.ToInt32(Console.ReadLine());
                    while (index < 0 || index > nombres.Count)
                    {
                        Console.WriteLine("Posición inválida. Elija otra:");
                        for (int i = 0; i < nombres.Count; i++) { Console.WriteLine(i); }
                        index = Convert.ToInt32(Console.ReadLine());
                    }
                    objtxt.Close();
                    nom.insertar(nombres, name, ruta, nombre, index);
                }
                catch (FormatException e) { Console.WriteLine(e.Message); }

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
           

        }
        public class Nombre
        {
           public Nombre() { }
           
            public void insertar(List<string> lista, string nom, string ruta, string rutnom, int ind) {
                lista.Insert(ind, nom);

                string temp = ruta + "temp.txt";
                File.WriteAllLines(temp, lista);

                File.Delete(ruta+rutnom);
                File.Move(temp, ruta + rutnom);



            }

        }
    }
}
