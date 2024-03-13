using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Boletin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 2;

            List<int> list = new List<int>();
            Random generador = new Random();

            for (int i = 0; i < 50; i++)
            {
                list.Add(generador.Next(1, 26));
            }

            //Mostrar la lista
            Console.WriteLine("Lista generada: ");
            Funciones.escribeColeccion(list);

            switch (ejercicio)
            {
                case 1:
                    int posicion = list.IndexOf(2);
                    if (posicion == -1)
                    {
                        Console.WriteLine("No encontrado");
                    }
                    else
                    {
                        Console.WriteLine("Está en la posición : " + 2);
                    }

                    //Si queremos buscar todas las posiciones:
                    int pos = -1;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == 2)
                        {
                            pos = i;
                            Console.WriteLine(i);
                        }
                    }
                    if (posicion == -1)
                    {
                        Console.WriteLine("No hay ningún dos");
                    }

                    int suma = 0;
                    Console.WriteLine("Suma de los valores generados: ");
                    foreach (int valor in list)
                    {
                        suma = suma + valor;
                    }
                    Console.WriteLine(suma);
                    double media = suma / list.Count;
                    Console.WriteLine("La media es: " + media);

                    Console.WriteLine("Porcentaje de valores superiores a 20");
                    int contador = 0;
                    foreach (int valor in list)
                    {
                        if (valor > 20)
                        {
                            contador++;
                        }
                    }
                    double porcentaje20 = ((float)contador / list.Count) * 100;
                    Console.WriteLine("Hay un " + porcentaje20 + "% de números > 20");

                    Console.WriteLine("Valores almacenados: ");
                    Funciones.escribeColeccion(list);

                    Console.WriteLine("Valores sin repetidos: ");
                    HashSet<int> set = new HashSet<int>(list);

                    Funciones.escribeColeccion(set);


                    break;
                case 2:
                    List<String> tareas = new List<string>();
                    List<String> completadas = new List<string>();
                    int opcion = 0;

                    do
                    {
                        Console.WriteLine("1. Introducir tarea");
                        Console.WriteLine("2. Eliminar tarea");
                        Console.WriteLine("3. Contar tareas pendientes");
                        Console.WriteLine("4. Mostrar tareas pendientes");
                        Console.WriteLine("5. Mostrar tareas completadas");
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Introduzca la tarea: ");
                                String tarea = Console.ReadLine();
                                tareas.Add(tarea);
                                break;
                            case 2:
                                Console.WriteLine("Que tarea quiere eliminar: ");
                                int contador2 = 0;
                                foreach (String t in tareas)
                                {
                                    Console.WriteLine(contador2 + ". " + t);
                                    contador2++;
                                }
                                //  String tareaEliminar = Console.ReadLine();
                                int posicion2 = int.Parse(Console.ReadLine());

                                //1º Añadimos
                                completadas.Add(tareas[posicion2]);
                                tareas.RemoveAt(posicion2);
                                                              
                                break;
                            case 3:
                                Console.WriteLine("Nº de tareas pendientes: " + tareas.Count);
                                break;

                            case 4:
                                Console.WriteLine("Mostrar tareas pendientes:");
                                foreach(String t in tareas)
                                {
                                    Console.WriteLine(t);
                                }
                                Console.WriteLine();
                                break;
                             case 5:
                                Console.WriteLine("Mostrar tareas completadas: ");
                                foreach (String t in completadas)
                                {
                                    Console.WriteLine(t);
                                }
                                Console.WriteLine();
                                break;
                        }
                    } while (opcion < 6);

                    break;
                case 3:
                    HashSet<String> dnis = new HashSet<string>();
                    int opcion3 = 1;

                    switch (opcion3)
                    {
                        case 1:
                            Console.WriteLine("Intro dni: ");
                            String dni = Console.ReadLine(); 
                            dnis.Add(dni);

                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                            case 4:
                            String dniBusqueda = "12345678U";
                            if (dnis.Contains(dniBusqueda))
                            {
                                Console.WriteLine("El dni está en la bbdd");
                            }
                            else
                            {
                                Console.WriteLine("No está en la base de datos.");
                            }
                            break;
                    }
                    break;
                    case 4:
                    Dictionary<string, string> estadosYCapitales = new Dictionary<string, string>();

                    // Agregar estados y sus capitales al diccionario
                    estadosYCapitales.Add("Alabama", "Montgomery");
                    estadosYCapitales.Add("Alaska", "Juneau");
                    estadosYCapitales.Add("Arizona", "Phoenix");
                    estadosYCapitales.Add("Arkansas", "Little Rock");
                    estadosYCapitales.Add("California", "Sacramento");
                    estadosYCapitales.Add("Colorado", "Denver");
                    estadosYCapitales.Add("Connecticut", "Hartford");
                    estadosYCapitales.Add("Delaware", "Dover");
                    estadosYCapitales.Add("Florida", "Tallahassee");
                    estadosYCapitales.Add("Georgia", "Atlanta");

                    //Buscar la capital de un estado
                    String estado;
                    Console.WriteLine("Intro estado para saber su capital: ");
                    estado = Console.ReadLine();

                    String capitalBuscada = estadosYCapitales[estado];
                    Console.WriteLine("La capital es: " + capitalBuscada);

                    break;

                default:
                    break;

                  
            }
            Console.ReadLine();
        }
    }
}
