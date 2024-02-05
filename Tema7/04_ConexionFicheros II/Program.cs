using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ruta = Directory.GetCurrentDirectory();
            String rutaFichero = ruta + "\\series.txt";

            String[] registros = new string[100];

            //Recuperar la info del fichero series.txt
            StreamReader lector = new StreamReader(rutaFichero);

            String registro = "";
            int posicion = 0;

            while (registro != null)
            {
                registro = lector.ReadLine();
                //Guardar el registro en la primera pos vacía de la matriz
                registros[posicion] = registro;
                posicion++;

            }
            

            lector.Close();


            //Mostrar por pantalla la matriz de strings
            Console.WriteLine("Series almacenadas: ");
            foreach (String reg in registros){
                if (reg != null)
                {
                    Console.WriteLine(reg);
                }

            }

            int opcion = 1;
            char continuar;
            switch (opcion)
            {
                case 1:
                    StreamWriter escritor = new StreamWriter(rutaFichero, true);
                    Console.WriteLine("Introduzca su serie: ");
                    String serie = Console.ReadLine();
                    Console.WriteLine("En que plataforma se emite?");
                    String plataforma = Console.ReadLine();
                    escritor.WriteLine(serie + "*" + plataforma);

                    escritor.Close();


                    break;
                case 2:
                    //Ver series de una determinada plataforma:
                    String plataf;
                    Console.WriteLine("De qué plataforma quieres obtener información: ");
                    plataf = Console.ReadLine();

                    //Cuantas series hay y listarlas:
                    break;
            }
           

            Console.ReadLine();



        }
    }
}
