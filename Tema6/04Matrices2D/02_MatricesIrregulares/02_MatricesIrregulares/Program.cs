using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MatricesIrregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] temperaturas = new int[3][];
            temperaturas[0] = new int[3];
            temperaturas[1] = new int[5];
            temperaturas[2] = new int[7];

            //Inicializamos a valores Random
            Random generador  = new Random();

            for(int i = 0;i<temperaturas.GetLength(0);i++)
            {
                for(int j = 0; j < temperaturas[i].Length; j++)
                {
                    temperaturas[i][j] = generador.Next(1, 11);
                }
            }

            //Mostramos por pantalla


            for (int i = 0; i < temperaturas.GetLength(0); i++)
            {
                for (int j = 0; j < temperaturas[i].Length; j++)
                {
                   Console.Write(temperaturas[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
