using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programa que muestre por pantalla los números entre el 100 y el 150

            int i = 100; // Inicializando la variable de control

            while (i <= 150)
            {
                Console.Write(i + " ");
                //Sumando 1 a la i
                i++; // Lo mismo que escribir => i = i +1;
            }
            Console.WriteLine();

            Console.WriteLine("Números Impares entre 100 y 150 : ");

            //Resetear la variable i
            i = 101;

            while (i < 150)
            {
                Console.Write(i + " ");
                i += 2;
            }

            //Mostrar en rojo los números pares entre 100 y 150 , los impares en blanco

            i = 100;
            Console.WriteLine();
            Console.WriteLine("ROJO Y BLANCO:");
            while (i <= 150)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i + " ");
                }
                i++;
            }

            //Mostrar los valores entre n y m , cambiando de color cada 10 valores.





            Console.ReadLine();
        }
    }
}
