using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin
{
    class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicio:4 - 8 ");
            ejercicio = int.Parse(Console.ReadLine());

            if(ejercicio == 4)
            {
                //Pico el ejercicio 4
                double nota1, nota2, nota3, media;

                Console.WriteLine("Intro nota 1: ");
                nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Intro nota 2: ");
                nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Intro nota 3: ");
                nota3 = double.Parse(Console.ReadLine());
                media = (nota1 + nota2 + nota3) / 3;

                if (media < 5)
                {
                    Console.WriteLine("Suspenso");
                }
                else
                {
                    Console.WriteLine("Aprobado");
                }

                Console.ReadLine();



            }
            else if(ejercicio == 5)
            {
                //Pico el ejercicio 5
                int n1, n2;
                n1 = 4;
                n2 = 1;
                int suma = n1 + n2;

                if(suma >= 0)
                {
                    double raiz = Math.Sqrt(suma);
                    Console.WriteLine("La raiz es: " + raiz);
                }
                else
                {
                    Console.WriteLine("No se puede calcular.");
                }

                else if (ejercicio == 6)
                {
                    String password = "hola";
                    String password2;
                    Console.WriteLine("Intro password: ");
                    password2 = Console.ReadLine();

                    if (password.Equals(password2))
                    {
                        Console.WriteLine("Iguales");
                    }
                    else
                    {
                        Console.WriteLine("Distintos");
                    }
                }
                else if (ejercicio == 7)
                {
                    int x1, x2;
                    Console.WriteLine("Intro numero 1 : ");
                    x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Intro numero 2: ");
                    x2 = int.Parse(Console.ReadLine());
                    long resultado;
                    if (x1 < x2)
                    {
                        resultado = (long)Math.Pow(x2, x1);
                    }
                    else
                    {
                        resultado = (long)Math.Pow(x1, x2);
                    }
                    Console.WriteLine("Resultado" + resultado);

                }

            else if(ejercicio == 8)
                {
                    double presion, temperatura;

                    if (presion > 2)
                    {
                        Console.WriteLine("Abrir válvula");
                    }
                    if (temperatura > 500)
                    {
                        Console.WriteLine("Reducir la temperatura");
                    }

                    if(presion<=2 && temperatura <= 500)
                    {
                        Console.WriteLine("Todo en orden");
                    }

                }
    


                
            }
            else
            {
                //Te has equivocado de ejercicio
            }








        }
    }
}
