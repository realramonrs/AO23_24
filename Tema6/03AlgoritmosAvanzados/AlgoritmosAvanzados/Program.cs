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
            int[] matriz = new int[10];
            int[] matriz2 = new int[7];
            Metodos.llenarArray(matriz,20);
            
            Metodos.llenarArray(matriz2, 20);
            Metodos.printArray(matriz);
            Console.WriteLine();          
           
            Metodos.printArray(matriz2);

            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };
            Metodos.printArray(a);
            Metodos.printArray(b);
            a = b; //Ojo
            b[0] = 9;
            Metodos.printArray(a);
            Metodos.printArray(b);
            Console.WriteLine("Hashcode de a : " + a.GetHashCode());
            Console.WriteLine("Hashcode de b : " + b.GetHashCode());
            if(a == b)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Diferentes.");
            }





            Console.ReadLine();



            //2. Algoritmo que obtiene la posición del primer número superior a la media del array
            //3. Algoritmo que obtiene el número más pequeño de un array.
        }
    }
}
