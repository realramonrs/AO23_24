using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            //calcular la raíz cuadrada
            float raiz = (float)Math.Sqrt(numero);
            //calcular la raíz enésima -->Math.pow(base,1/n)
            float raizCubica = (float)Math.Pow(numero, 1 / 3);

            //calcular una potencia
            int x = 9;
            int y = 4;
            //x elevado a y
            long potencia =(long) Math.Pow(x, y);

            //redondeo de valores
            float valor = 4.5f;

            float valorIntmenor = (float)Math.Floor(valor);
            Console.WriteLine(valor + " redondeado " + valorIntmenor);

            float valorIntmayor = (float)Math.Ceiling(valor);
            Console.WriteLine(valor + " redondeado up " + valorIntmayor);

            float valorIntCercano = (float)Math.Round(valor);
            Console.WriteLine(valor + " redondeo cercano " + valorIntCercano);

            //Ajuste número decimales

            float valor2 = 4.6789f;
           
            float valorRedondeado = (float)Math.Round(valor2, 3);
            valor2 = (float)Math.Round(valor2, 1);
            Console.WriteLine("valor2 = " + valor2);
            Console.WriteLine("vaorRedondeado = " + valorRedondeado);
            Console.ReadLine();

        }
    }
}
