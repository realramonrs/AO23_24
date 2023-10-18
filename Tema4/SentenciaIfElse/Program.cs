using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciaIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que clasifica un número como par o impar
            int numero = 12;

            if(numero % 2 == 0)
            {
                Console.WriteLine(numero + " es par.");
            }
            else
            {
                Console.WriteLine(numero + " es impar.");
            }

            //Programa que indica si un número es cero o distinto de cero
            int numero2 = 3;

            if (numero2 != 0)
            {
                Console.WriteLine(numero2 + " es distinto de 0");
            }
            else
            {
                Console.WriteLine(numero2 + " es igual a 0");
            }

            //Programa que clasifica un número como múltiplo de 3 o no

            int numero3 = 15;

            if(numero3 % 3 == 0)
            {
                Console.WriteLine(numero3 + " es múltiplo de 3");
            }
            else
            {
                Console.WriteLine(numero3 + " no es múltiplo de 3");
            }

            //Programa que a partir del salario bruto de un trabajador aplica
            // un irpf del 15% si el salario <= 1200€ y un irpf del 19% si es superior
            double salario , salarioNeto;
            Console.WriteLine("Introduzca el salario bruto: ");
            salario = double.Parse(Console.ReadLine());

            if(salario <= 1200)
            {
                salarioNeto = salario - salario * 0.15;
            }
            else
            {
                salarioNeto = salario - salario * 0.19;
            }

            Console.WriteLine("Salario neto: " + salarioNeto);

            







            Console.ReadLine();
        }
    }
}
