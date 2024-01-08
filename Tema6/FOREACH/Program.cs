using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = { 8, 5, 4, 3, 2 };

           
            foreach(int x in matriz)
            {
                Console.Write(x + " ");
                
            }

            //Calcular la suma
            int suma = 0;
            foreach(int valor in matriz)
            {
                suma = suma + valor;
            }

            //No se puede modificar la colección de datos que se recorre
            foreach(int valor in matriz){ 
                if(valor == 0)
                {
                //    valor += 10;
                }
            }
            Console.ReadLine();
        }
    }
}
