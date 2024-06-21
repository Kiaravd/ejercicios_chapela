using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJ1
            //Console.WriteLine("ingresar 2 numeros: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Suma: "+ (n1+n2));
            //Console.WriteLine("Resta: "+ (n1 - n2));
            //if (n2 == 0)
            //{
            //    Console.WriteLine("No se puede dividir por 0");
            //}
            //else { Console.WriteLine("Division: " + (n1 / n2)); }
            //Console.WriteLine("Multiplicacion: "+ (n1 * n2));

            string sino = "si";
            double sueldobrut=0;
            int sueldonet=0;
            double aportesjubi=0;
            double obrasocialsum=0;

            do
            {
                Console.WriteLine("Ingresar nombre de docente:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Horas trabajadas de docente:");
                int horastrabajo = Convert.ToInt32(Console.ReadLine());
                int totaldinero = horastrabajo * 4200;
                Console.WriteLine("Nombre: "+nombre );
                Console.WriteLine("horas trabajadas: "+ horastrabajo);
                Console.WriteLine("Sueldo bruto: {0}", totaldinero-(totaldinero*0.11+totaldinero*0.04));
                Console.WriteLine("Sueldo neto:{0}",  totaldinero);
                Console.WriteLine("Sueldo retenido:{0}", (totaldinero * 0.11 + totaldinero * 0.04));
                Console.WriteLine("Aporte jubilatorio:{0}", (totaldinero * 0.11));
                aportesjubi += totaldinero * 0.11;
                obrasocialsum += totaldinero * 0.04;
                sueldonet += totaldinero;
                sueldobrut += totaldinero - (totaldinero * 0.11 + totaldinero * 0.04);
                Console.WriteLine("Obra social:{0}", (totaldinero * 0.04));
                Console.WriteLine("TOTAL DE DATOS INGRESADOS:");
                Console.WriteLine("obra social:"+ obrasocialsum);
                Console.WriteLine("jubilacion:"+ aportesjubi);
                Console.WriteLine("bruto:"+ sueldobrut);
                Console.WriteLine("neto:"+ sueldonet);

                Console.WriteLine("Desea seguir ingresando docentes?");
                sino = Console.ReadLine();

            } while (sino=="si");




        }
    }
}
