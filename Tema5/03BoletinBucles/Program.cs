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

                    case 8:
                        int numero8;
                        Console.WriteLine("Introduce un numero ");
                        numero8 = int.Parse(Console.ReadLine());
                        int j = numero8;
                        for (;j<numero8 + 5; j++)
                        {
                            Console.WriteLine(j + " " + Math.Pow(j, 2) + " " + Math.Pow(j, 3));
                        }
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

                   
                    case 13:
                        int n13 = 120;
                        int suma13 = 0;
                        for(int z = 1; z <= n13/2; z++)
                        {
                            if(n13 % z == 0)
                            {
                                suma13 = suma13 + z;
                            }
                        }

                        if (suma13 == n13)
                        {
                            Console.WriteLine("Número perfecto.");
                        }
                        else
                        {
                            Console.WriteLine("Numero no perfecto");
                        }
                        break;

                    case 15:
                        writeGreen("Ejercicio 15: Factorial.");
                        int numero15;
                        long factorial = 1;
                        Console.WriteLine("Introduzca un número: ");
                        numero15 = int.Parse(Console.ReadLine());

                        for(i = numero15; i >= 1; i--)
                        {
                            factorial = factorial * i;
                        }
                        break;


                    case 17:
                        writeGreen("Ejercicio 17: Contar divisores.");
                        int numero17;
                        int contadorDivisores = 2;

                        Console.WriteLine("Intro número: ");
                       
                        numero17 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Los divisores de " + numero17 + " son:" );
                        Console.Write(1 + " ");
                        for (i = 2; i <= numero17/2; i++)
                        {
                            if(numero17 % i == 0)
                            {
                                contadorDivisores++;
                                Console.Write(i + " ");
                            }
                        }
                        Console.Write(numero17);
                        Console.WriteLine();
                        Console.WriteLine("El número " + numero17 + " tiene " + contadorDivisores + " divisores");

                        break;
                    case 18:
                        writeGreen("Ejercicio 18: Detectar número primo");
                        int numero18;
                        Boolean primo = true;
                        do
                        {
                            Console.WriteLine("Introduzca un número: ");
                            numero18 = int.Parse(Console.ReadLine());
                        }
                        while (numero18 < 1);

                        for(i = 2; i <= numero18 / 2; i++)
                        {
                            if(numero18 % i == 0)
                            {
                                primo = false;
                                break;
                            }
                        }
                        if (primo)
                        {
                            Console.WriteLine(numero18 + " es primo.");
                        }
                        else
                        {
                            Console.WriteLine(numero18 + " no es primo.");
                        }

                        break;
                    case 22:
                        writeGreen("Explicación Bucles Anidados: 10 filas de 10 asteriscos");

                        /*   for (i = 0; i < 10; i++)
                           {
                               for (j = 0; j < 10; j++)
                               {
                                   Console.Write("* ");

                               }
                               Console.WriteLine();
                        }
                        */
                        i = 0;
                        while (i < 10)
                        {
                            j = 0;
                            while (j < 10)
                            {
                                Console.Write("* ");
                                j++;
                            }
                            Console.WriteLine();
                            i++;
                        }

                        break;

                    case 25:
                        Random aleatorio = new Random();
                        
                        for(i = 0; i < 10; i++)
                        {
                            int numero25 = aleatorio.Next(-5,6);
                            Console.Write(numero25 + " ");
                        }
                        Console.WriteLine();
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
