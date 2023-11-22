using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BoletinBucles
{
    class MisFunciones
    {
        public static void writeGreen(String titular)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(titular);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static Boolean isPrimo(int numero)
        {

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
