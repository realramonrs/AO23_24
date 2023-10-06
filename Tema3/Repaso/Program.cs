using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que lea 3 valores
            int a, b, c;
            double media, modulo;
            Console.WriteLine("Intro valor a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Intro valor b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Intro valor c : ");
            c = int.Parse(Console.ReadLine());
            //y calcule:
            //La media
            media = (a + b + c) / 3;
            //Calcule el módulo: Raiz(a2 + b2 + c2) --> Con dos decimales
            modulo = Math.Sqrt(a * a + b * b + c * c);
            modulo = Math.Round(modulo, 2);
            //Utilizando la librería Math obtener el más pequeño
            int menor = Math.Min(a, b);
            int menor2 = Math.Min(menor, c);
        }   
    }
}
