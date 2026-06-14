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
                        Console.WriteLine($"1. {seleccion.Suma}, 2.{seleccion.Resta}, 3.{seleccion.Multiplicacion}, 4.{seleccion.Division}, 5.{seleccion.Potenciacion}, 6.{seleccion.NumeroAzar}");
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
        static void juegoAzar()
        {
                       Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int intentos = 0;
            bool adivinado = false;
            Console.WriteLine("Bienvenido al juego de adivinar el número secreto entre 1 y 100.");
            while (!adivinado)
            {
                Console.Write("Ingresa tu intento: ");
                int intento;
                if (int.TryParse(Console.ReadLine(), out intento))
                {
                    intentos++;
                    if (intento == numeroSecreto)
                    {
                        adivinado = true;
                        Console.WriteLine($"¡Felicidades! Has adivinado el número secreto {numeroSecreto} en {intentos} intentos.");
                    }
                    else if (intento < numeroSecreto)
                    {
                        Console.WriteLine("El número secreto es mayor. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine("El número secreto es menor. Intenta de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
        }
    }
    enum seleccion
    {
        Suma = 1,
        Resta,
        Multiplicacion,
        Division,
        Potenciacion,
        NumeroAzar

    }
}
