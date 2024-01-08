using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso10
{
    class Program
    {

     

        static void Main(string[] args)
        {
            //Bucle do while
            //Programa que lee un número entre 1 y 5
            int numero = 0;

            do
            {
                Console.WriteLine("Intro número entre 1 y 5");
                numero = int.Parse(Console.ReadLine());
            }
            while (numero < 1 || numero > 5);

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Número 1:");
                    break;
                case 2:
                    Console.WriteLine("Número 2:");
                    break;
                case 3:
                    Console.WriteLine("Número 3:");
                    break;
                default:
                    Console.WriteLine("Número no está entre 1 y 3");
                    break;
            }

            char opcion = 'A';

            switch (opcion)
            {
                case 'A':

                    break;
                case 'B':

                    break;
                default:

                    break;
            }

            //Generar con un while :
            //50 , 55 , 60, 65 , 70 , 75

            int i = 50;

            while (i <= 75)
            {
                Console.Write(i + " ");
                i += 5;
            }

            //Mostrar el primer número múltiplo de 2 y 7 en un intervalo

            int n = 15;
            int m = 25;
            bool encontrado = false;
            Console.WriteLine();
            for(int j = n; j <= m; j++)
            {
                if(j % 2 == 0 && j % 7 == 0)
                {
                    encontrado = true;
                    Console.WriteLine(j + " es múltiplo de 2 y 7");
                    break;
                }
             
            }

            if (!encontrado)
            {
                Console.WriteLine("No hay múltiplos de 2 y 7");
            }


            int[] h = new int[10];
            int suma = 0;
            h[0] = 9;
            h[1] = 4;
            h[2] = 5;
            h[9] = 10;

            for(int u = 0; u < h.Length; u++)
            {
                suma = suma + h[u];
            }

          Class1.printMatriz(h);

            Console.WriteLine("Introduce un valor");
            h[5] = int.Parse(Console.ReadLine());
           

            Console.ReadLine();

        }
    }
}
