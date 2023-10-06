using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Boletin3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 4
            double radio, longitud, area, volumen;
            const double PI = 3.141516;
            
            Console.WriteLine("Introduce el radio: ");
            radio = double.Parse( Console.ReadLine());

             longitud = 2 * PI * radio;
             area = Math.PI * radio * radio;
             volumen = (4f / 3) * PI * radio * radio * radio;

            
            Console.WriteLine("Longitud: " + longitud);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Volumen: " + volumen);

            //Ejercicio 7
            Console.WriteLine("******* EJERCICIO 7 *******");
            double celsius, fahrenheit;
            Console.WriteLine("Introduce grados celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (9 / 5)*celsius + 32;
            Console.WriteLine("Grados Fahrenheit: " + fahrenheit);
           
            
            
            
            Console.ReadLine();





            //Ejercicio 5: 




            //Ejercicio 7: 

            // Ejercicio 8:
            Console.WriteLine();
            Console.WriteLine(" ********* EJERCICIO 8 *******");
            double presion, volumen8, temperatura, nMoles;
            const double R = 0.082;
            Console.WriteLine("Introduzca el volumen en litros: ");
            volumen8 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la temperatura en Kelvin: ");
            temperatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el nº de moles: ");
            nMoles = double.Parse(Console.ReadLine());

            presion = (nMoles * R * temperatura)/ volumen8;

            Console.WriteLine("Con un volumen de " + volumen8 + $" litros ,y una temperatura de {temperatura} kelvin," + nMoles +" moles de un gas ideal tienen una presión de " + presion + " atmósferas");
            //Ejercicio 10: 
            Console.WriteLine();
            Console.WriteLine(" *********Ejercicio 10 ********");
            float horas, tasa, salarioBruto;
            float irpf, salarioNeto;

            Console.WriteLine("Introduzca horas trabajadas : ");
            horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la tasa (precio / hora)");
            tasa = float.Parse(Console.ReadLine());
            Console.WriteLine("Que IRPF desea aplicar?");
            irpf = float.Parse(Console.ReadLine());

            salarioBruto = horas * tasa;
            salarioNeto = salarioBruto - (irpf*salarioBruto)/ 100;

            Console.WriteLine("Salario bruto: " + salarioBruto);
            Console.WriteLine("Salario neto : " + salarioNeto);

            //Ejercicio 9
            Console.WriteLine();
            Console.WriteLine("**********EJERCICIO 9 *******");

            int a = 2;
            int b = 5;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //Ejercicio 13
            Console.WriteLine(" ");
            Console.WriteLine("*******EJERCICIO 13 *******");

            short cateto1, cateto2;
            double hipotenusa;

            Console.WriteLine("Intro valor cateto 1: ");
            cateto1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Intro valor cateto 2: ");
            cateto2 = short.Parse(Console.ReadLine());

            double radicando = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            hipotenusa = Math.Sqrt(radicando);

            Console.WriteLine("Hipotenusa : " + hipotenusa);

            //Ejercicio 14
            Console.WriteLine();
            Console.WriteLine("********EJERCICIO 14 *******");
            float precioInicial, porcentajeDescuento, precioFinal,rebaja;

            Console.WriteLine("Introduce precio inicial: ");
            precioInicial = float.Parse(Console.ReadLine());

            Console.WriteLine("% descuento ? ");
            porcentajeDescuento = float.Parse(Console.ReadLine());

            rebaja = (precioInicial * porcentajeDescuento) / 100;

            precioFinal = precioInicial - rebaja;
            
            Console.WriteLine("Precio final " + precioFinal);













            
            Console.ReadLine();
        }
    }
}
