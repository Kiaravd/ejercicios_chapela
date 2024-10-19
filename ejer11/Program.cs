using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ejer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Agregarnom agregarnom = new Agregarnom();

            do
            {
                Console.WriteLine("Que desea hacer con el archivo?");
                Console.WriteLine("Darle de alta: marque 1");
                Console.WriteLine("Leerlo: marque 2");
                Console.WriteLine("Agregar o apendizar: marque 3");
                Console.WriteLine("salir: marque 4");

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        List<string> palabras = new List<string>();
                        Console.WriteLine("Cuantas palabras deseas agregar?");
                        int cant = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine(" Palabra {0}: ", i + 1);
                            palabras.Add(Console.ReadLine());
                        }
                        agregarnom.darAlta(palabras);
                        break;
                    case 2:
                        agregarnom.leer();
                        break;
                    case 3:
                        List<string> palabras2 = new List<string>();
                        Console.WriteLine("Cuantas palabras deseas agregar?");
                        int cant2 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cant2; i++)
                        {
                            Console.WriteLine(" Palabra {0}: ", i + 1);
                            palabras2.Add(Console.ReadLine());
                        }
                        agregarnom.escribir(palabras2);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo..");
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor correcto");
                        break;
                }
            } while (opcion != 4);
        }

        public class Agregarnom
        {
            public Agregarnom() { }
            public string nombre;
            string ruta = "C:\\prueba\\";
            string archivo = "programando.txt";
            public void darAlta(List<string> nombres) {
                StreamWriter objtext;
                objtext = File.CreateText(ruta + archivo);
                for (int i = 0; i < nombres.Count; i++)
                {
                    objtext.WriteLine(nombres[i]);
                }
                objtext.Close();
                Console.WriteLine("Escrito y cerrado");
            }
            public void leer() {
                string linea;
                StreamReader objtext;
                try
                {
                    objtext = File.OpenText(ruta + archivo);
                    linea = objtext.ReadLine();
                    while (linea != null) { Console.WriteLine(linea); linea = objtext.ReadLine(); }
                    objtext.Close();
                }
                catch (Exception e){ Console.WriteLine(e.Message); }
                
            }
            public void escribir(List <string> nombres) {

                StreamWriter objtext;
                objtext = File.AppendText (ruta + archivo);

                for (int i = 0; i < nombres.Count; i++)
                {
                    objtext.WriteLine(nombres[i]);
                }
                objtext.Close();
                Console.WriteLine("Palabra/s agregadas");
            }
        }
    }
}
