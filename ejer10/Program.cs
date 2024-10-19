using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string fecha;
            try
            {
                Console.WriteLine("Nombre del doctor ");
                Nombre =Console.ReadLine();
                Console.WriteLine("fecha ");
                fecha = Console.ReadLine();
                Consultas consul = new Consultas(Nombre, fecha);
                consul.telefono = 33434;
                consul.direccion = "Av jujuy 988";
                consul.nombre = "Consultorio San Vicente";
                consul.MostrarDatos();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

 
            Urgencias urgen = new Urgencias();
            Console.WriteLine("Ingrese los siguientes datos:");
            try
            {
                Console.WriteLine("Edad del paciente ");
                urgen.edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nombre del paciente ");
                urgen.NombrePaciente = Console.ReadLine();
                urgen.telefono = 3243;
                urgen.direccion = "Av jujuy 988";
                urgen.nombre = "Consultorio San Vicente";
                urgen.MostrarDatos();

            }
            catch (Exception e) {
                Console.WriteLine("Error: {0}", e.Message);
            }

        }
        abstract public class CentroMedico
        {
            public string nombre;
            public string direccion;
            public int telefono;

            public virtual void MostrarDatos()
            {
                Console.WriteLine("El centro medico {0} con dirección {1} y telefono {2}", nombre, direccion, telefono);
            }
        }

        public class Consultas : CentroMedico
        {
            public Consultas(string nombre, string fech)
            {
                NombreDoc = nombre;
                fecha = fech;
            }
            public string NombreDoc;
            public string fecha;

            public override void MostrarDatos()
            {
                base.MostrarDatos();
                Console.WriteLine("Su consulta es con el medico {0} el día {1}", NombreDoc, fecha);
            }
        }

        public class Urgencias : CentroMedico
        {
            public Urgencias() { }
            public string NombrePaciente;
            public int edad;

            public override void MostrarDatos()
            {
                base.MostrarDatos();
                Console.WriteLine("El paciente {0} tiene la edad {1}", NombrePaciente, edad);
            }

        }
    }
}
