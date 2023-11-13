using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bucle For
            //Mostrar numeros entre 1 y 20 por pantalla
            for (int i = 1; i <= 20; i = i + 1)
            {
                Console.Write(i + " ");
            }


            //Calcular la suma de todos los número entre n y m
            int n = 15;
            int m = 30;
            int suma = 0; //n + n +1 + n+2 + n+3 + n+4 ....
            Console.WriteLine();
            for(int i = n; i <= m; i++)
            {
                suma = suma + i;
            }
            Console.Write("La suma es: " + suma);

            //Calcular la suma de los números impares entre n y m
            int sumaImpares = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    sumaImpares = sumaImpares + i;
                }
            }

            Console.WriteLine("La suma de valores impares: " + sumaImpares);

            //Salir prematuramente de un bucle --> Sentencia break
            //Encontrar el primer número múltiplo de 3, 7 y 8 a la vez en un rango
            int limiteInferior = 1200;
            int limiteSuperior = 35000;

            for(int i = limiteInferior;i <= limiteSuperior; i++)
            {
                if(i % 3 == 0 && i % 7 == 0 && i % 8 == 0)
                {
                    Console.WriteLine("Primer múltiplo de 3 7 y 8 es " + i);
                    break;
                }
            }

            //Ignorar repetición  --> continue
            //Sumar todos los números menos los que son múltiplos de 3 y 7 a la vez en un rango
            int suma2 = 0;
            for(int i = limiteInferior;i<= limiteInferior; i++)
            {
                if(i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                suma2 = suma2 + i;
            }

            Console.ReadLine();






            Console.ReadLine();
        }
       
    }
}
