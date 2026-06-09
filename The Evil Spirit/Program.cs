using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Evil_Spirit
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static double suma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;  
        }
        static double resta(double num1, double num2)
        {
            double resultado = num1 - num2;
            if(resultado % 1 != 0)
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
}
