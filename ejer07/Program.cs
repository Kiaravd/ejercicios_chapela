using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            viaje pasajero = new viaje();
            string parar = "si";
            int cant_pasajeros= 0;
            int total_peso = 0;
            int pasajero_estacion1 = 0;
            int pasajero_estacion2 = 0;
            int peso_max = 0;
            int peso_min = 1000;
            do
            {
                Console.WriteLine("Ingresar datos de pasajero:");
                Console.WriteLine("Nombre");
                pasajero.nombre_pasajero = Console.ReadLine();
                Console.WriteLine("Numero de pasaje");
                pasajero.num_pasaje = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha");
                pasajero.fecha = Console.ReadLine();
                Console.WriteLine("Peso de valijas");
                pasajero.peso_valijas = Convert.ToInt32(Console.ReadLine());
                total_peso += pasajero.peso_valijas;
                if (peso_max< pasajero.peso_valijas)
                {
                    peso_max = pasajero.peso_valijas;
                }
                if (peso_min > pasajero.peso_valijas)
                {
                    peso_min = pasajero.peso_valijas;
                }
                Console.WriteLine("Destino: estacion 1 o estacion 2");
                pasajero.destino = Console.ReadLine();
                if (pasajero.destino == "estacion 1")
                {
                    pasajero.destino = " estacion 1, 150km";
                    pasajero_estacion1++;
                }
                else
                {
                    pasajero.destino = " estacion 2, 250km";
                    pasajero_estacion2++;
                }
                pasajero.mostrar_datos();
                cant_pasajeros++;
                Console.WriteLine("Desea agregar otro pasajero? si o no");
                parar = Console.ReadLine();
            } while (parar == "si");
            Console.WriteLine("peso total de valijas: {0}", total_peso);
            Console.WriteLine("peso minimo de valijas: {0}", peso_min);
            Console.WriteLine("peso maximo de valijas: {0}", peso_max);
            Console.WriteLine("Cantidad de pasajeros: {0}", cant_pasajeros);
            Console.WriteLine("Cantidad de pasajeros estacion 1: {0}", pasajero_estacion1);
            Console.WriteLine("Cantidad de pasajeros estacion 2: {0}", pasajero_estacion2);
        }
        public class viaje
        {
            public viaje() { }
            public int num_pasaje;
            public string nombre_pasajero;
            public string fecha;
            public int peso_valijas;
            public string destino;
            public void mostrar_datos()
            {
                Console.WriteLine("La información del pasajero es: ");
                Console.WriteLine("Numero de pasaje {0}", num_pasaje);
                Console.WriteLine("Nombre de pasajero {0}", nombre_pasajero);
                Console.WriteLine("Fecha de viaje {0}", fecha);
                Console.WriteLine("Peso de valijas {0}", peso_valijas);
                Console.WriteLine("destino: {0}", destino);
                
            }
        }
    }
}
