using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funciones de la variable char
            //  --> isDigit, isLetter, isUpper, isLower ....
            //Funciones de la variable String
            // indexOf, substring, indexOfAny, split , length
            //startsWith , endsWith, contains, replace.

            //Algoritmo que valida si un String está compuesto por dos caracteres
            //con el formato A9

            string entrada;

            bool correcto = true;
            do
            {
                Console.WriteLine("Introduzca un codigo con formato A9");
                entrada = Console.ReadLine();
                //Primero validamos que esté formado por dos caracteres
                if (entrada.Length != 2)
                {
                    correcto = false;
                    Console.WriteLine("El código no tiene dos caracteres");
                }
                else
                {
                    if (char.IsLetter(entrada[0]) && char.IsDigit(entrada[1]))
                    {
                        correcto = true;
                        Console.WriteLine("Formato correcto");
                    }
                    else
                    {
                        correcto = false;
                        Console.WriteLine("El código debe tener formato A9");
                    }
                }
            } while (!correcto);
            Console.ReadLine();

            Console.WriteLine("*********** Segundo ejercicio *******");
            //Algoritmo que indica cuantas palabras empiezan por A
            string entrada2 = "A lo loco se vive mejor . Algunas veces";
            string[] palabras = entrada2.Split(' ');
            int contador = 0;
            Console.WriteLine(entrada2);
            foreach(string palabra in palabras)
            {
                if(palabra.StartsWith("A") || palabra.StartsWith("a")){
                    contador++;
                }
            }
            if(contador == 0)
            {
                Console.WriteLine("No hay palabras que empiezan por a|A");
            }
            else
            {
                Console.WriteLine("Hay " + contador + " palabras que empiezan por A|a");
            }

            // Programa que cambia los espacios de un String por asteriscos
            //Problema: Los Strings son inmutables , no se pueden modificar
            string entrada3 = "The Wire es la mejor serie de todos los tiempos.";
            string entrada4 = entrada3 + " Teneis que verla";

            entrada3 = entrada3.Replace(' ', ',');           


            Console.WriteLine(entrada3);

            string[] matriculas = new string[100];
            matriculas[0] = "2345-ASD";
            matriculas[1] = "3490-QWE";
            matriculas[2] = "1111-TRE";
            matriculas[3] = "9090-QWE";

            Console.ReadLine();
        }

    }
}
