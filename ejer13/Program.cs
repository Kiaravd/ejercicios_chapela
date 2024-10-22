using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo trian = new triangulo();
            string siono = "Si";
            double supersuma = 0;

            try
            {
                do
                {
                    Console.WriteLine("ingresar lados de un triangulo");
                    Console.WriteLine("Lado 1");
                    try
                    {
                        trian.lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Lado 2");
                        trian.lado2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Lado 3");
                        trian.lado3 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException) { Console.WriteLine("El formato no corresponde"); continue; }
                    trian.QueEs();
                    trian.EsRectangulo();
                    trian.superficie();
                    supersuma += trian.area;
                    Console.WriteLine("Desea ingresar más triangulos? Escriba Si o no");
                    siono = Console.ReadLine();

                } while (siono == "Si");
                Console.WriteLine("Suma superficies: " + supersuma);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public class triangulo
        {
            public triangulo() { }
            public double lado1;
            public double lado2;
            public double lado3;
            public double area;

            public void QueEs()
            {
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Es un trangulo equilatero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado3 == lado2)
                {
                    Console.WriteLine("Es un trangulo isoceles");
                }
                else
                {
                    Console.WriteLine("Es un trangulo Escaleno");
                }

            }
            public void EsRectangulo()
            {
                double a, b, c;
                if (lado1 >= lado2 && lado1 >= lado3)
                {
                    c = lado1;
                    a = lado2;
                    b = lado3;
                }
                else if (lado2 >= lado1 && lado2 >= lado3)
                {
                    c = lado2;
                    a = lado1;
                    b = lado3;
                }
                else
                {
                    c = lado3;
                    a = lado1;
                    b = lado2;
                }

                if (c * c == a * a + b * b)
                {
                    Console.WriteLine("Es un triangulo rectangulo");
                }
                else
                {
                    Console.WriteLine("No es un triangulo rectangulo");
                }

            }
            public void superficie()
            {
                double semiperimetro = (lado1 + lado2 + lado3) / 2;

                // calculo área con fórmula de Herón
                // math.sqrt calcula raiz cuadrada
                area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

                Console.WriteLine("El área del triángulo es: " + area);
            }
        }
    }
}

