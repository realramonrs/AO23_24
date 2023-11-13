using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BoletinBucles
{
    class Program
    {
        static void writeGreen(String titular)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(titular);
            Console.ForegroundColor = ConsoleColor.White;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("************Boletín de Bucles*********");
            char opcion;
            do
            {
               writeGreen("Escoja un ejercicio entre 5 y 25");
                int ejercicio = int.Parse(Console.ReadLine());

                switch (ejercicio)
                {
                    case 5:

                        writeGreen("Ejercicio 5: ");
                        int i = 320;

                        while (i >= 160)
                        {
                            Console.Write(i + " ");
                            i = i - 20;
                        }
                        Console.WriteLine();
                      
                        break;
                    case 6:

                        writeGreen("Ejercicio 6:");

                        for ( i = 0;i<= 100; i++) { 
                            if(i % 5 == 0 && i % 7 == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        writeGreen("Ejercicio 7");
                        int numero;
                        Console.WriteLine("Introduzca un número: ");
                        numero = int.Parse(Console.ReadLine());

                        writeGreen("Tabla de multiplicar del número " + numero);

                        for(i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(numero + " x " + i + " = " + numero * i);
                        }
                        Console.WriteLine();
                        break;


                    case 10:
                        writeGreen("Ejercicio 10 : Sumar los m primeros números.");

                        int m = -1;
                        int suma = 0;
                        int contador = 0;
                        do
                        {
                            if (contador == 0)
                            {
                                Console.WriteLine("Introduzca un números positivo: ");
                                m = int.Parse(Console.ReadLine());
                            }
                            else if(contador == 1)
                            {
                                Console.WriteLine("Por favor introduzca UN NÚMERO POSITIVO");
                                m = int.Parse(Console.ReadLine());
                            }
                            else if(contador == 2)
                            {
                                Console.WriteLine("Introduce un número positivo. PRIMER AVISO");
                                m = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Déjalo , esto no es lo tuyo.");
                            }
                           
                            contador++;
                        }
                        while (m < 0 && contador <= 3);

                        //Comprobar que se puede calcular la suma
                        if (m > 0)
                        {
                            for (i = 1; i <= m; i++)
                            {
                                suma = suma + i;
                            }
                            Console.WriteLine("La suma es : " + suma);

                        }
                        break;

                    case 12:
                        writeGreen("Ejercicio 12. Sumar los divisores de un número.");
                        int n12 = 0;
                        int sumaDivisores = 0;

                        do
                        {
                            Console.WriteLine("Intro numero mayor que cero:");
                            n12 = int.Parse(Console.ReadLine());
                        }
                        while (n12 <= 0);

                        sumaDivisores = 1 + n12;
                        for(i = 2; i <= n12/2; i++)
                        {
                            if(n12 % i == 0)
                            {
                                sumaDivisores = sumaDivisores + i;
                            }
                        }
                        Console.WriteLine("La suma de los divisores es: " + sumaDivisores);
                        break;
                    default:
                        Console.WriteLine("Ejercicio no existe.");
                        break;
                }
                Console.WriteLine("Desea volver al menú inicial : s/n");
                opcion = Char.ToLower(char.Parse(Console.ReadLine()));
            } //Cierro la llave del do
            while (opcion=='s');
        }
    }
}
