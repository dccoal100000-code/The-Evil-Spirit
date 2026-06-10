using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_Evil_Spirit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = 1; double num2 = 1;

            bool t = true;
            do
            {
                try
                {
                    Console.WriteLine("por favor dame un numero");
                    num1 = Convert.ToDouble(Console.ReadLine());
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("La division entre cero no se puede selecciona otro numero");
                    t = false;
                }
                try
                {
                    Console.WriteLine("por favor dame un numero");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("La division entre cero no se puede selecciona otro numero");
                    t = false;
                }
            } while (t == false);
            seleccion selecion = new seleccion();
            Console.WriteLine("bienvenido al menu de seleccion de peraciones ");
            Console.WriteLine($"1. {seleccion.Suma}, 2.{seleccion.Resta}, 3.{seleccion.Multiplicacion}, 4.{seleccion.Division}");
            seleccion ss = (seleccion)Enum.Parse(typeof(seleccion), Console.ReadLine());
            switch (ss)
            {
                case seleccion.Suma:
                    suma(num1, num2);
                    break;
                case seleccion.Resta:
                    resta(num1, num2);
                    break;
                case seleccion.Multiplicacion:
                    multiplicacion(num1, num2);
                    break;
               



            }
        }
        static double suma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }
        static double resta(double num1, double num2)
        {
            double resultado = num1 - num2;
            if (resultado % 1 != 0)
            {
                Console.WriteLine("tu resultado tiene decimales");
            }
            return resultado;
        }
        static double multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
      
    }
    enum seleccion
    {
        Suma = 1,
        Resta,
        Multiplicacion,
        Division
    }
}
