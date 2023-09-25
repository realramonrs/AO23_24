using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operadores1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores matemáticos: + , - , *, / , %
            //Estos operadores generan un valor cuyo tipo depende de los operandos
            // Por ejemplo: los operadores + , - y * :
            //   --> Si los operandos son short , o byte o int devuelve siempre un int
            byte x1 = 9;
            byte x2 = 10;
            int resultado = x1 + x2;
            byte resultado2 = (byte)(x1 + x2);

            //   --> Si hay dos tipos de operando, devuelve el de mayor capacidad
            long x3 =  900000;
            int x4 = 1000;
            int suma = (int)(x3 + x4);
            long suma2 = x3 + x4;

            // El operador / si los operandos son de tipo int devuelve un valor de tipo int,
            // aunque el resultado no sea exacto
            int a1 = 9;
            int a2 = 5;
            double division = a1 / a2;
            double division2 = (double)(a1 / a2); // Esto no funciona, pq ya se calculó como 1
            double division3 = (double)a1 / a2;
            Console.WriteLine("division= " + division);
            Console.WriteLine("division2 = " + division2);
            Console.WriteLine("division3 = " + division3);
            Console.ReadLine();

        }
    }
}
