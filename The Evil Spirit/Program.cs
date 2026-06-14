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
            seleccion ss = seleccion.Suma;

            bool t = true;
           double resultado = 0;

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
                do
                {
                    try
                    {


                        Console.WriteLine("bienvenido al menu de seleccion de peraciones ");
                        Console.WriteLine($"1. {seleccion.Suma}, 2.{seleccion.Resta}, 3.{seleccion.Multiplicacion}, 4.{seleccion.Division}, 5.{seleccion.Potenciacion}");
                        ss = (seleccion)Enum.Parse(typeof(seleccion), Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("selecciona una opcion valida");
                    }
                } while (ss != seleccion.Suma && ss != seleccion.Resta && ss != seleccion.Multiplicacion && ss != seleccion.Division);
                switch (ss)
                {
                    case seleccion.Suma:
                        resultado = suma(num1, num2);
                        break;
                    case seleccion.Resta:
                        resultado = resta(num1, num2);
                        break;
                    case seleccion.Multiplicacion:
                        resultado = multiplicacion(num1, num2);
                        break;
                    case seleccion.Division:
                      resultado = division(num1, num2);
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
        static double division(double num1, double num2)
        {
            double resultado = num1 / num2;
            return resultado;
        }
          
        static double potencia(double num1, double num2)
        {
            double resultado = 1;
            for (int i = 0; i < num2; i++)
            {
                resultado *= num1;
            }
            return resultado;
        }
        static void MostrarResultado(double resultado)
        {
            Console.WriteLine("tu resultado es " + resultado);
        }
    }
    enum seleccion
    {
        Suma = 1,
        Resta,
        Multiplicacion,
        Division,
        Potenciacion
    }
}
