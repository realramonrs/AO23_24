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
            //Programa que solicita al usuario DNI y Edad
            String dni;
            byte edad;

            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce su edad: ");
            edad = byte.Parse(Console.ReadLine());

            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Edad: " + edad);
            Console.ReadLine();

        }
    }
}
