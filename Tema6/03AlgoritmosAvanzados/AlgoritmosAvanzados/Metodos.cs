using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosAvanzados
{
    class Metodos
    {

        public static void llenarArray(int[] a)
        {
            Random generador = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = generador.Next();
            }
        }


        public static void llenarArray(int[] a,int limiteSuperior)
        {
            Random generador = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = generador.Next(limiteSuperior);
            }
        }

        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
