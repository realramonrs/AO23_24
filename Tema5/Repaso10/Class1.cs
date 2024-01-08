using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso10
{
    class Class1
    {
        public static int suma(int x,int y)
        {
            return x + y;
        }
       public static void printMatriz(int[] matriz)
        {
            for (int u = 0; u < matriz.Length; u++)
            {
                Console.Write(matriz[u] + " ");
            }
        }
    }
}
