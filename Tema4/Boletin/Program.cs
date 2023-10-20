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


                Console.ReadLine();



            }
            else if(ejercicio == 5)
            {
                //Pico el ejercicio 5
            }
            else
            {
                //Te has equivocado de ejercicio
            }








        }
    }
}
