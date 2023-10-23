using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            char continuar;

            do
            {
                Console.WriteLine("Escoge una opción: ");
                Console.WriteLine("a) Saludar");
                Console.WriteLine("b) Animar");
                Console.WriteLine("c) Despedir");
                Console.WriteLine("d) Salir del programa");
                opcion = Char.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 'a':
                        Console.WriteLine("Hola !!!");
                        break;
                    case 'b':
                        Console.WriteLine("Vamoooos !!!");
                        break;
                    case 'c':
                        Console.WriteLine("Hasta la próxima!!!");
                        break;
                    default:
                        Console.WriteLine("Te has equivocado.");
                        break; //Opcional

                } // Llave que cierra el switch
                Console.WriteLine("Quiere volver al menú: s->sí/n->no");
                continuar = Console.ReadKey().KeyChar;//Para que no espere a que el usuario pulse Enter
                Console.WriteLine();
                
            } // LLave que cierra el bucle do
            while (continuar=='s');
        }
    }
}
