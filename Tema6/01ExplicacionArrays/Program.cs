using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ExplicacionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que trabaje con 10 valores de tipo int
            int[] notas = new int[10];

            //Modificar posiciones 0, 3 y 7
            notas[0] = 9;
            notas[3] = 7;
            notas[7] = 5;

            //Visualizar todas las posiciones por pantalla
         //   Console.WriteLine(notas[0] + " " + notas[1] + " " + notas[2]);

            for(int i = 0; i < 10; i++)
            {
                Console.Write(notas[i] + " ");
            }

            // Hacer un programa que solicite al usuario 5 notas y las almacene
            //en las primeras posiciones del array
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Intro nota " + i );
                notas[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < 10; i++)
            {
                Console.Write(notas[i] + " ");
            }
            //A continuación calcular la media de estas 5 primeras notas.

            int suma = 0;
            double media = 0;
            for(int i = 0; i < 5; i++)
            {
                suma = suma + notas[i];
            }
            media = suma / 5;

            Console.WriteLine("La media es : " + media);

            Console.ReadLine();


            //Inicializar un array con valores
            float[] temperaturas = { 1.6f, 17.5f, 20, 6f, 12.5f };

            int capacidad = temperaturas.Length; // --> Obtiene la capacidad del array
            Console.WriteLine("Número de temperaturas almacenadas: " + capacidad);
            Console.ReadLine();
             }
    }
}
