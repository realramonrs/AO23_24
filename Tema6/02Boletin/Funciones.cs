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

        //Método que llena un array con números aleatorios
        public static void llenarArray(int[] matriz)
        {
            Random generador = new Random();

            for(int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = generador.Next();
            }
        }

        public static void llenarArray(int[] matriz,int limInferior,int limSuperior)
        {
            Random generador = new Random();

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = generador.Next(limInferior,limSuperior+1);
            }
        }

        public static void llenarArray(double[] matriz,int limInferior,int limSuperior)
        {
            Random generador = new Random();

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = generador.NextDouble();
            }
        }

    } //************* FINAL DE LA CLASE ****************************

   



}
