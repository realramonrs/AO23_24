using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Boletin
{
    class Funciones
    {
        public static void printEnunciado(int ejercicio)
        {
            Console.WriteLine();
            Console.WriteLine("**************EJERCICIO " + ejercicio + "**************");
            Console.WriteLine();
        }
        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void printArray(short[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void printArray(float[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void printArray(String[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == null)
                {
                    break;
                }
                Console.WriteLine(a[i]);
            }
           
        }
    }
}
