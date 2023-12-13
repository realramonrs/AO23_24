using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosAvanzados
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Algoritmo que indica si dos arrays son iguales: es decir, tienen el mismo tamaño y los mismos valores
            //int[] matriz = new int[10];
            //int[] matriz2 = new int[7];
            //Metodos.llenarArray(matriz,20);
            
            //Metodos.llenarArray(matriz2, 20);
            //Metodos.printArray(matriz);
            //Console.WriteLine();          
           
            //Metodos.printArray(matriz2);

            //int[] a = { 1, 2, 3 };
            //int[] b = { 1, 2, 3 };
            //Metodos.printArray(a);
            //Metodos.printArray(b);
            //a = b; //Ojo
            //b[0] = 9;
            //Metodos.printArray(a);
            //Metodos.printArray(b);
            //Console.WriteLine("Hashcode de a : " + a.GetHashCode());
            //Console.WriteLine("Hashcode de b : " + b.GetHashCode());
            //if(a == b)
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Diferentes.");
            //}





            //2. Algoritmo que obtiene la posición del primer número superior a la media del array
            //3. Algoritmo que obtiene el número más pequeño de un array.

            int[] matriz3 = new int[5];
            Metodos.llenarArray(matriz3, 50);
            int minimo = matriz3[0];
            
            

            
            for(int i = 1; i < matriz3.Length; i++)
            {
                if (minimo > matriz3[i])
                {
                    minimo = matriz3[i];
                }
            }
            Console.WriteLine("El mínimo es: " + minimo);
            //4. Algoritmo que ordena los elementos de un array de menor a mayor
            //Array.Sort(matriz3);
            matriz3 = new int[] {5,20,4,3,21,1};
            Metodos.printArray(matriz3);
            Console.WriteLine();
            Console.WriteLine("****** MÉTODO BURBUJA ********");
            Console.WriteLine();

            for(int i = 0; i < matriz3.Length; i++) {
                for (int j = 0; j < matriz3.Length - 1; j++)
                {
                    if (matriz3[j] > matriz3[j + 1])
                    {
                        int aux = matriz3[j];
                        matriz3[j] = matriz3[j + 1];
                        matriz3[j + 1] = aux;
                    }

                    Metodos.printArray(matriz3);
                    Console.WriteLine();
                }

                Console.WriteLine("Finalización iteración : " + i);
                Console.WriteLine();
                }

            Console.ReadLine();

        }
    }
}
