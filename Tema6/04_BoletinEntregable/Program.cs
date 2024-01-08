using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BoletinEntregable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduzca el numero de elementos del array:");
            n = int.Parse(Console.ReadLine());
            int[] matriz31 = new int[n];
           
            //LLenar todas las posiciones con un número negativo
            for(int i = 0; i < matriz31.Length; i++)
            {
                matriz31[i] = -1;
            }

            Random r = new Random();
            for(int i = 0; i < 5; i++)
            {
                matriz31[i] = r.Next(1, 20);
            }
            for(int i = n - 1; i > n - 6; i--)
            {
                matriz31[i] = r.Next(1, 20);
            }

            for(int i = 5; i < n - 6; i++)
            {
                matriz31[i] = 0;
            }

            Console.WriteLine("Primera posicion: " + matriz31[0]);
            Console.WriteLine("Última posición: " + matriz31[matriz31.Length - 1]);

            //Crear una copia del Array
            int[] matriz31Copia = new int[n];

            /* for(int i = 0; i < matriz31.Length; i++)
             {
                 matriz31Copia[i] = matriz31[i];
             }*/

            Array.Copy(matriz31, matriz31Copia, n);

            //Ordenar el array: Método de la burbuja
            Array.Sort(matriz31Copia);

            int suma = 0;
            for(int i = 0; i < 10; i++)
            {
                suma = suma + matriz31[i] + matriz31Copia[i];
            }

         
           //Aumentar en 10 todas las posiciones del array copia
           for(int i = 0; i < matriz31Copia.Length; i++)
            {
                matriz31Copia[i] += 10;
            }

            //Calcular la media
            int suma2 = 0;
            double media = 0;

            foreach(int v in matriz31)
            {
                suma2 = suma2 + v;
            }

            media = suma2 / matriz31.Length;

            Console.WriteLine("La media es : " + media);

            //Poner a cero posiciones con valorez > media

            for(int i = 0; i < matriz31.Length; i++)
            {
                if(matriz31[i] > media)
                {
                    matriz31[i] = 0;
                }
            }

            //Buscar valor en ambos arrays
            int valor = 0;
            Console.WriteLine("Intro valor que desea buscar: ");
            valor = int.Parse(Console.ReadLine());

            int pos1 = -1;
            int pos2 = -1;
           // bool encontrado = false;
            for(int i = 0;i< matriz31.Length; i++)
            {
                if(matriz31[i] == valor)
                {
                    pos1 = i;
                  //  encontrado = true;
                    break;
                }
              
            }
            if(pos1 == -1)
            {
                Console.WriteLine("Valor no encontrado en matriz origial.");
            }
            else
            {
                Console.WriteLine(valor + " está en la posición del array original : " + pos1);
            }

            pos2 = Array.IndexOf(matriz31Copia, valor);

            if(pos2 < 0)
            {
                Console.WriteLine("Vanor no encontrado en matriz copia");
            }
            else
            {
                Console.WriteLine(valor + " está en la posición del array copia : " + pos2);
            }


            //33. Calcular la desviación con respecto a la media

            int[] matriz33 = { 7, 8, 9, 4, 5, 3, 1 };
            int suma33 = 0;
            double media33 = 0;

            foreach(int v in matriz33)
            {
                suma33 = suma33 + v;
            }
            media33 = suma33 / matriz33.Length;





        }
    }
}
