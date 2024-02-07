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
            String rutaFichero = ruta + @"\series.txt";
            //Recuperar datos del fichero
            String[] series = new string[100];

            StreamReader lector;
            try
            {
                lector = new StreamReader(rutaFichero);
                int posicion = 0;
                String registro = "";
                while (registro != null)
                {
                    registro = lector.ReadLine();
                    series[posicion] = registro;
                    posicion++;
                }
                lector.Close();

            } catch(IOException e)
            {
                // Console.WriteLine("El fichero no existe ");
                if (!File.Exists(rutaFichero)){
                    File.Create(rutaFichero);
                }               

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            int opcion = 0;
            do {
                Console.WriteLine("Escoja una opción: ");
                Console.WriteLine("1. Introducir nueva serie");
                Console.WriteLine("2. Consultar catálogo.");
                Console.WriteLine("3. Buscar serie.");
                Console.WriteLine("4. Ver series por plataforma.");
                Console.WriteLine("5. Salir del programa.");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca título: ");
                        String titulo = Console.ReadLine();
                        Console.WriteLine("Intro plataforma: ");
                        String plataforma = Console.ReadLine();
                        //Escribimos registro en el fichero
                        StreamWriter escritor = new StreamWriter(rutaFichero, true);
                        escritor.WriteLine(titulo + "*" + plataforma);

                        escritor.Close();


                        //Actualizar array de series
                        for(int i = 0; i < series.Length; i++)
                        {
                            if (series[i] == null)
                            {
                                series[i] = titulo + "*" + plataforma;
                                break;
                            }
                        }
                        break;
                    case 2:
                        //Consultar el catálogo --> Consultamos el array local de series
                        foreach(String s in series)
                        {
                            if (s != null)
                            {
                                Console.WriteLine(s);
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        //Buscar Serie
                        Console.WriteLine("Que serie desea buscar?");
                        String serie = Console.ReadLine();

                        foreach(String s in series)
                        {
                            //Estructura registro --> nombre serie*plataforma
                            //Obtenemos la cadena que hay antes del asterisco
                            if (s == null)
                            {
                                Console.WriteLine("Serie no encontrada.");
                                break;
                            }
                            String[] trozos = s.Split('*');
                            if (serie.Equals(trozos[0],StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Serie encontrada. Información: ");
                                Console.WriteLine("Plataforma : " + trozos[1]);
                                break;
                            }

                        }

                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:

                        break;
                }
                
            } while (opcion!=5);
            Console.WriteLine("El programa se sigue ejecutando");
            Console.ReadLine();
            




        }
    }
}
