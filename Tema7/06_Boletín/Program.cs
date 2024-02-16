using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Boletín
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 1;
            do
            {
                Console.WriteLine("Introduzca ejercicio 1 - 10");
                ejercicio = int.Parse(Console.ReadLine());

                switch (ejercicio)
                {
                    case 1:
                        String[] matriculas = new string[50];
                        matriculas[0] = "1111-AAA";
                        matriculas[1] = "2222-ZZZ";
                        matriculas[2] = "3333-DDD";
                        matriculas[3] = "4344-GGR";
                        matriculas[4] = "9999-EEQ";

                       //Mostrar las matriculas que acaban por z
                        Console.WriteLine("Matriculas que acaban por Z");

                        foreach(String matricula in matriculas)
                        {
                            if (matricula is null)
                            {
                                break;
                            }
                            if (matricula.EndsWith("Z"))
                            {
                                Console.WriteLine(matricula);
                            }
                        }                       
                        Console.WriteLine("Matrículas que contienen el número 34");
                        
                        foreach(String matricula in matriculas)
                        {
                            if(matricula is null)
                            {
                                break;
                            }
                            else
                            {
                                if (matricula.Contains("34"))
                                {
                                    Console.WriteLine(matricula);
                                }
                            }
                        }

                        Console.WriteLine("c. Mostrar la parte numérica");

                        foreach(String matricula in matriculas)
                        {
                            if(matricula is null)
                            {
                                break;
                            }
                            //Console.WriteLine(matricula.Substring(0, 4));
                            Console.WriteLine(matricula.Split('-')[0]);
                        }

                        Console.WriteLine("d. Mostrar las letras de las matrículas");

                        foreach (String matricula in matriculas)
                        {
                            if (matricula is null)
                            {
                                break;
                            }
                            Console.WriteLine(matricula.Substring(5));
                           // Console.WriteLine(matricula.Split('-')[1]);
                        }

                       
                        //Volcar a un fichero
                        StreamWriter escritor = new StreamWriter(Directory.GetCurrentDirectory() + "\\matriculas.txt", true);
                        foreach(string m in matriculas)
                        {
                            if(m is null) { break; }
                            escritor.WriteLine(m);
                        }
                        escritor.Close();
                        break;
                    case 2:
                       
                        string prueba = "abracadabra";
                        Console.WriteLine("Buscar un caracter en :" + prueba);
                        char caracter = 'e';
                        int contador = 0;

                        for(int i = 0; i < prueba.Length; i++)
                        {
                            if (prueba[i] == caracter)
                            {
                                contador++;
                            }
                        }
                        Console.WriteLine(caracter + " aparece " +  contador + " veces");
                        break;

                    case 4:
                        Console.WriteLine("4. Palabras que empienzan por b");
                        string frase = "El bueno de Bruno perdió el balón";
                        Console.WriteLine("Frase: " + frase);

                        string[] palabras = frase.Split(' ');

                        foreach(string palabra in palabras)
                        {
                            if (palabra.StartsWith("b",StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(palabra);
                            }
                        }

                        break;
                }
            }
            while (ejercicio < 10);
            Console.ReadLine();
        }
    }
}
