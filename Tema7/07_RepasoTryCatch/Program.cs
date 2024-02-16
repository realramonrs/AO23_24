using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepasoTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Leer de un fichero que no existe
            try
            {
                StreamReader lector = new StreamReader(Directory.GetCurrentDirectory() + "\\hola.txt");

                while (!lector.EndOfStream)
                {
                    Console.WriteLine(lector.ReadLine());
                }

                lector.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error lectura fichero");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de acceso al fichero");
            }
            catch(Exception ex)
            {
                Console.WriteLine("A saber lo que ha pasado.");
            }

            Console.WriteLine("... se sigue ejecutando.");
            Console.ReadLine();
        }
    }
}
