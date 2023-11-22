using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios :
            //1. Mostrar todos los números impares múltiplos de 3 en un rango
            int n = 100;
            int m = 400;

            int i = n;
            while (i <= m)
            {
                //Comprobar si es impar y múltiplo de 3
                if(i % 2 == 1 && i % 3 == 0)
                {
                    Console.Write(i + " ");
                }

                i=i+1;
            }
            Console.WriteLine();

            //2. Contar todos los números multiplos de 3 y 4 en el intervalo anterior
            int contador = 0;
            for(i = n; i <= m; i++)
            {
                if(i % 3 == 0 && i % 4 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("Hay " + contador + " múltiplos de 3 y 4");

            //3. Programa que suma los cuadrados de los números impares que hay entre n y m
            n = 1;
            m = 10;
            int suma = 0;
            for(i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    suma = suma + i * i;
                }
            }

            //4. Mostrar por pantalla los 10 primeros números impares entre n y m
            //5. Calcular la suma de los 10 últimos números del intervalo n y m.
            //6. Contar cuanto números mayores que el doble de n son múltiplos de 7.
            int contadorImpares = 0;
            n = 100;
            m = 400;
            for(i = n; i <= m; i++)
            {
                if(i % 2 == 1)
                {
                    Console.Write(i + " ");
                    contadorImpares++;
                }
                if (contadorImpares == 10)
                {
                    break;
                }
            }
            Console.WriteLine();
            int sumaX = 0;
            for(i = m - 10; i <= m; i++)
            {
                sumaX = sumaX + i;
            }
            Console.WriteLine("La suma de los 10 últimos valores es: " + sumaX);
            int contadorMultiplos7 = 0;
            for(i = n * 2; i <= m; i++)
            {
                if(i % 7 == 0)
                {
                    contadorMultiplos7++;
                }
            }

            i = n * 2;

            while (i <= m)
            {
                if(i % 7 == 0)
                {
                    contadorMultiplos7++;
                }
                i++;
            }
            
            Console.ReadLine();
        }
    }
}
