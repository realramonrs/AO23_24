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


            
            
            
            Console.ReadLine();
        }
    }
}
