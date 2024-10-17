using System;
using System.Collections.Generic;

namespace ejer08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int promedio_edades = 0;
            int edad_max = 0;
            int edad_min = 1000;
            int sum_mat = 0;
            int indice_edad_max = -1; // Para almacenar el índice del alumno de mayor edad

            Console.WriteLine("Cuantos alumnos desea agregar? ");
            int cant = Convert.ToInt32(Console.ReadLine());
            alumno[] alum = new alumno[cant];
            for (int i = 0; i < cant; i++) { alum[i] = new alumno(); }
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Nombre del alumno {0}", i + 1);
                alum[i].nombre = Console.ReadLine();
                Console.WriteLine("Apellido del alumno {0}", i + 1);
                alum[i].apellido = Console.ReadLine();
                Console.WriteLine("Edad del alumno {0}", i + 1);
                alum[i].edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de materias aprobadas {0}", i + 1);
                alum[i].cant_materias_aprob = Convert.ToInt32(Console.ReadLine());

                sum_mat += alum[i].cant_materias_aprob;
                promedio_edades += alum[i].edad;
   
                // Determinar edad máxima y mínima
                if (edad_max < alum[i].edad)
                {
                    edad_max = alum[i].edad;
                    indice_edad_max = i; // Actualizar el índice del alumno mayor
                }
                if (edad_min > alum[i].edad)
                {
                    edad_min = alum[i].edad;
                }
            }

            // Mostrar datos de los alumnos
            for (int i = 0; i < cant; i++)
            {
                alum[i].mostrar_datos();
            }

            // Calcular y mostrar estadísticas
            Console.WriteLine("La edad en promedio es: {0}", (promedio_edades / cant));
            Console.WriteLine("La edad maxima es {0} y la minima {1}", edad_max, edad_min);
            Console.WriteLine("Suma de las materias aprobadas {0}", sum_mat);
            Console.WriteLine("Suma de las materias aprobadas en promedio {0}", (sum_mat / cant));

            // Verificar si el alumno de mayor edad tiene más materias aprobadas
            int max_materias_aprobadas = alum[indice_edad_max].cant_materias_aprob;
            bool es_max_aprobado = true; 

            for (int i = 0; i < cant; i++)
            {
                if (i != indice_edad_max && alum[i].cant_materias_aprob > max_materias_aprobadas)
                {
                    es_max_aprobado = false;
                    break;
                }
            }

            if (es_max_aprobado)
            {
                Console.WriteLine("El alumno de mayor edad ({0} {1}) tiene la mayor cantidad de materias aprobadas: {2}",
                    alum[indice_edad_max].nombre, alum[indice_edad_max].apellido, max_materias_aprobadas);
            }
            else
            {
                Console.WriteLine("El alumno de mayor edad ({0} {1}) NO tiene la mayor cantidad de materias aprobadas.",
                    alum[indice_edad_max].nombre, alum[indice_edad_max].apellido);
            }
        }

        public class alumno
        {
            public alumno() { }
            public string nombre;
            public string apellido;
            public int edad;
            public int cant_materias_aprob;

            public void mostrar_datos()
            {
                Console.WriteLine("Nombre: {0} Apellido: {1} Edad: {2} Materias aprobadas: {3}", nombre, apellido, edad, cant_materias_aprob);
            }
        }
    }
}
