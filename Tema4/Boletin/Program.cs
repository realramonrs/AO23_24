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
            if(ejercicio == 3)
            {
                double n0, n1, n2, n3;
                Console.WriteLine("ingrese el primer número");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el segundo número");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el tercer número");
                n3 = double.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    n0 = n1;
                    n1 = n2;
                    n2 = n0;
                }
                if (n2 > n3)
                {
                    n0 = n2;
                    n2 = n3;
                    n3 = n0;
                }
                if (n1 > n2)
                {
                    n0 = n1;
                    n1 = n2;
                    n2 = n0;
                }
                Console.WriteLine("los numeros ordenados de mayor a menor son " + n1 + n2 + n3);

            }
            else if (ejercicio == 4)
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
            else if (ejercicio == 5)
            {
                //Pico el ejercicio 5
                int n1, n2;
                n1 = 4;
                n2 = 1;
                int suma = n1 + n2;

                if (suma >= 0)
                {
                    double raiz = Math.Sqrt(suma);
                    Console.WriteLine("La raiz es: " + raiz);
                }
                else
                {
                    Console.WriteLine("No se puede calcular.");
                }
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

            else if (ejercicio == 8)
            {
                double presion, temperatura;
                presion = 4;
                temperatura = 450;

                if (presion > 2)
                {
                    Console.WriteLine("Abrir válvula");
                }
                if (temperatura > 500)
                {
                    Console.WriteLine("Reducir la temperatura");
                }

                if (presion <= 2 && temperatura <= 500)
                {
                    Console.WriteLine("Todo en orden");
                }

            }   
            else if(ejercicio == 11)
            {
                double nota = 0;
                Console.WriteLine("Introduce una nota");
                nota = double.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10)
                {
                    Console.WriteLine("Error en la nota");
                }
                else if(nota < 5)
                {
                    Console.WriteLine("Estás suspenso");
                }
                else if(nota< 6.5)
                {
                    Console.WriteLine("Aprobado");
                }
                else if(nota < 8.5)
                {
                    Console.WriteLine("Notable");
                }
                else 
                {
                    Console.WriteLine("Sobresaliente");
                }
            }

            else if (ejercicio == 14)
            {
                Console.WriteLine("a) Sumar");
                Console.WriteLine("b) Restar");
                Console.WriteLine("c) Multiplicar");
                Console.WriteLine("d) Dividir");
                Console.WriteLine("e) Raiz de la suma");
                char opcion = Char.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 'a':
                        int n1, n2;
                        int suma = 0;

                        n1 = 9;
                        n2 = 6;
                        suma = n1 + n2;
                        Console.WriteLine("Suma = " + suma);
                        break;
                    case 'b':
                        break;
                    case 'c':
                        break;
                    case 'd':
                        break;
                    case 'e':
                        break;
                    default:
                        Console.WriteLine("Opción errónea!");
                        break;

                }

            }
            else if(ejercicio ==21){
                int a, b, c;
                double sol11, sol22;
                bool solucion = true;
                sol11 = Double.NaN;
                sol22 = Double.NaN;

                a = 2;
                b = 4;
                c = 1;


                if (a == 0)
                {
                    if (b != 0)
                    {
                        sol11 = -c / b;
                        sol22 = sol11;
                    }
                    else
                    {
                        solucion = false;
                    }
                }
                else if (b == 0)
                {
                    double radicando = -c / a;
                    if (radicando >= 0)
                    {
                        sol11 = Math.Sqrt(radicando);
                        sol22 = -Math.Sqrt(radicando);
                    }
                    else
                    {
                        solucion = false;
                    }
                }
                else if (c == 0)
                {
                    sol11 = 0;
                    sol22 = -b / a;
                }
                else
                {
                    double radicando = b * b - 4 * a * c;
                    if (radicando >= 0)
                    {
                        sol11 = (-b + Math.Sqrt(radicando)) / (2 * a);
                        sol22 = (-b - Math.Sqrt(radicando)) / (2 * a);
                    }
                    else
                    {
                        solucion = false;
                    }
                }

                if (solucion)
                {
                    Console.WriteLine("Las soluciones son: ");
                    Console.WriteLine("x1 = " + sol11);
                    Console.WriteLine("x2 = " + sol22);
                }
                else
                {
                    Console.WriteLine("No tiene solución.");
                }
            }
            else if(ejercicio == 23)
            {
                int x, y, z;
                x = 5;
                y =7;
                z = 5;

                if(x<=y && x < z)
                {
                    //x es el menor
                    if (y < z)
                    {
                        Console.WriteLine(x + " < " + y + " < " + z);
                    }
                    else
                    {
                        Console.WriteLine(x + " < " + z + " < " + y);
                    }

                }//Cierra el if principal
                else if(y< z && y < x)
                {
                    //y es el menor
                    if(x < z)
                    {
                        Console.WriteLine(y + " < " + x + " < " + z);
                    }
                    else
                    {
                        Console.WriteLine(y + " < " + z + " < " + x);
                    }
                
                }
                else
                {
                    if(y < x)
                    {
                        Console.WriteLine(z + " < " + y + " < " + x);
                    }
                    else
                    {
                        Console.WriteLine(z + " < " + x + " < " + y);
                    }
                }


            }
            
            else
            {
                //Te has equivocado de ejercicio
            }



            Console.ReadLine();




        }
    }
}
