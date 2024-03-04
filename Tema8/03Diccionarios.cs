using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String,String> dic = new Dictionary<String,String>();

            //Añadir pareja clave - valor
            dic.Add("12345679O", "Pedro Martinez,25,Programador");
            dic.Add("34567812F", "Lucía Jimenez,34, Administrativa");

            //Permite realizar búsquedas por clave:
            String trabajador = dic["12345679O"];

            Console.WriteLine(trabajador);

            //Si se le pasa un valor que no existe salta una excepción

            String trabajador2;
            Boolean encontrado = dic.TryGetValue("123456ddd79O", out trabajador2);

            if (encontrado == true)
            {
                Console.WriteLine(trabajador2);
            }

            else
            {
                Console.WriteLine("No encontrado");
            }

            //Recorrer un diccionario

            Console.WriteLine("Valores almacenados en el diccionario: ");
            foreach(KeyValuePair<String,String> entry in dic)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
            Console.ReadLine();
        }
    }
}
