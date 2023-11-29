using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Boletin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:
            Console.WriteLine("********* EJERCICIO 1 *********");
            int[] a1 = { 1, 2, 3, 4, 5, 6, 7,8,9,10};
            int[] a2 = new int[100]; // 1,2,3,4,5,6,7,8,9,10,... 100

            for(int i = 0; i < 100; i++)
            {
                a2[i] = i + 1;
            }
            //Visualizar los dos arrays
            for(int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("a2: ");
            Console.WriteLine();
            Funciones.printArray(a2);
            Console.WriteLine();
            //Ejercicio 2: 
            Funciones.printEnunciado(2);
            float[] a3 = new float[20];

            Funciones.printArray(a3);
            

            //Ejercicio 3: 
            Funciones.printEnunciado(3);
            int[] a4 = new int[10];

            a4[0] = -1;
            a4[2] = -1;
            a4[5] = -1;
            a4[9] = -1;

            Funciones.printArray(a4);

            //Ejercicio 4:
            Funciones.printEnunciado(4);

            String[] libros = new string[50];

            libros[0] = "Los Pilares de la Tierra";
            libros[1] = "El archivo de las tormentas";
            libros[2] = "Los bolechas";
            libros[3] = "Los secretos de Youtube";
            libros[4] = "El clan del oso cavernario";

            /* for(int i = 0; i < libros.Length; i++)
             {
                 Console.WriteLine(libros[i] + " ");
             }
             Console.WriteLine();*/

            Funciones.printArray(libros);

            Funciones.printEnunciado(5);

            short[] a5 = new short[4];

            for(int i = 0;i< a5.Length; i++)
            {
                Console.WriteLine("Intro valor posicion. " + i);
                a5[i] = short.Parse(Console.ReadLine());
            }

            Funciones.printArray(a5);

            Funciones.printEnunciado(6);

            double[] a6 = new double[8];

            //Actualizar la última pos a -1
            a6[a6.Length-1] = -1;

            for(int i = 0; i< a6.Length; i++)
            {
                Console.Write(a6[i] + " ");
            }

            Console.WriteLine();





            Console.ReadLine();
        }
    }
}
