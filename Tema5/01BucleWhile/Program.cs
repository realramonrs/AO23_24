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
            ConsoleColor[] colores = { ConsoleColor.Red, ConsoleColor.Yellow,ConsoleColor.Gray,ConsoleColor.Blue,ConsoleColor.White,ConsoleColor.DarkMagenta,ConsoleColor.DarkCyan};
            int n = 25;
            int m = 120;
            int contador = 0;

            i = n; //Inicializo la variable de control
            Console.WriteLine();
            Console.WriteLine("Valores entre " + n + " y " + m);
            int aleatorio = 0;
            int copia = 0;
            while (i <= m)
            {
                contador++;
                
                
                if (contador  % 10 == 0)
                {
                    aleatorio = new Random().Next(0, 6);
                    
                    while(aleatorio == copia)
                    {
                        aleatorio = new Random().Next(0, 6);

                    }
                    Console.ForegroundColor = colores[aleatorio];
           
                    
                }
                copia = aleatorio;
                Console.Write(i + " ");
                i = i + 1;
               
            }






            Console.ReadLine();
        }
    }
}
