using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TiposVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            byte n1;
            //Inicializar una variable
            n1 = 10;
            byte n2 = n1;

            //Declarar varias variables en la misma linea
            short num1, num2, num3;
            num1 = 9;
            num2 = 10;
            num3 = 5;

            //Modificar el valor que hay guardado en una variable
            int x1 = 10;
            //Incrementar en uno el valor de x1
            x1 = x1 + 1;
            Console.WriteLine("x1 = " + x1);

            //Por ejemplo: Sumar 1 a la variable num1 de tipo Short
            num1 =  (short)(num1 + 1); //Conversión de int a short
            Console.WriteLine("num1 = " + num1);

            //Variables con números decimales
            double temperatura = 25.6;
            //Aumentar la temperatura en 10 grados.
            temperatura = temperatura + 10;
            Console.WriteLine("Temperatura : " + temperatura);
            Console.ReadLine();
            //Programa que a partir de la base y la altura , calcula el área de un triángulo
            double baseTriangulo, altura, area;
            baseTriangulo = 9;
            altura = 8.5;
            
            area = (baseTriangulo * altura) / 2;

            Console.WriteLine("Area = " + area);

            Console.ReadLine();

        }
    }
}
