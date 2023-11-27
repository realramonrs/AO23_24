using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correccion_ExamenBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int ejercicio;
            do
            {
                Console.WriteLine("Intro ejercicio 1 - 4:");
                ejercicio = int.Parse(Console.ReadLine());

                switch (ejercicio)
                {
                    case 1:
                        int i = 500;
                        while (i >= 100)
                        {
                            Console.Write(i + " ");
                            i -= 100;
                        }
                        Console.WriteLine();
                        i = 13;
                        while (i <= 25)
                        {
                            Console.Write(i + " ");
                            i += 2;
                        }
                        Console.WriteLine();
                        i = 100;
                        while (i >= 20)
                        {
                            Console.Write(i + " ");
                            i -= 20;
                        }
                        break;
                    case 2:
                        int n, m;
                        do
                        {
                            Console.WriteLine("Intro n : ");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Intro m > n : ");
                            m = int.Parse(Console.ReadLine());
                            int contador = 0;
                            for(i = n; i <= m; i++)
                            {
                                if(i % 2 == 1 && i % 7 == 0)
                                {
                                    Console.WriteLine(i + " ");
                                    contador++;
                                }
                                if(contador == 10)
                                {
                                    break;
                                }

                            }
                        }
                        while (n >= m);
                        break;
                    case 3:
                        int n3;
                        double suma = 0;
                        Console.WriteLine("Intro valor de n: ");
                        n3 = int.Parse(Console.ReadLine());

                        for(i = 10; i <= n3; i++)
                        {
                            suma = suma + 1 + i / (Math.Pow(i, 3) + 1);
                        }
                        Console.WriteLine("La suma es " + suma);
                        break;

                    case 4:
                        int n4, m4;

                        Console.WriteLine("Intro n4: ");
                        n4 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Intro m4: ");
                        m4 = int.Parse(Console.ReadLine());
                        Boolean primos = true;
                        for(i = 2; i < m4; i++)
                        {
                            if(n4 % i == 0 && m4 % i == 0)
                            {
                                Console.WriteLine("No son primos sí");
                                primos = false;
                                break;
                            }
                          }

                        if (primos)
                        {
                            Console.WriteLine("Son primos entre sí");
                        }

                        break;

                    case 5:
                        //Ejercicio 4 otra versión
                        //DOs números son amigos si la suma de los divisores de un número es igual al otro número
                        int n5, m5,suman5,sumam5;
                        suman5 = 0;
                        sumam5 = 0;
                        Console.WriteLine("Intro n5: ");
                        n5 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Intro m5: ");
                        m5 = int.Parse(Console.ReadLine());

                        for( i = 1; i <= n5/2; i++)
                        {
                            if (n5 % i == 0)
                            {
                                suman5 = suman5 + i;
                            }
                        }

                        for (i = 1; i <= m5 / 2; i++)
                        {
                            if (m5 % i == 0)
                            {
                                sumam5 = sumam5 + i;
                            }
                        }

                        if(suman5 == m5 && sumam5 == n5)
                        {
                            Console.WriteLine("Son amigos");
                        }
                        else
                        {
                            Console.WriteLine("No son amigos");
                        }



                        break;
                }
            }
            while (ejercicio < 1 || ejercicio > 4);
            Console.ReadLine();
        }
    }
}
