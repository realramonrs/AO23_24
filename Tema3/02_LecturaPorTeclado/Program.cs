using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LecturaPorTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que solicita al usuario DNI y Edad y salario
            String dni;
            byte edad;
            float salario;

            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce su edad: ");
              edad = byte.Parse(Console.ReadLine());
            //edad = Convert.ToByte(Console.ReadLine());


            Console.WriteLine("Introduzca su salario:");
            //  salario = float.Parse(Console.ReadLine());
            salario = Convert.ToSingle(Console.ReadLine());
            
            

            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Edad: " + edad);
            Console.ReadLine();

        }
    }
}
