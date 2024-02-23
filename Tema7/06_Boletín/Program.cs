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

                    case 3:
                        string dni;
                        Boolean correcto = true;
                        Console.WriteLine("Intro DNI: ");
                        dni = Console.ReadLine();

                        if(dni.Length != 9)
                        {
                            correcto = false;
                            Console.WriteLine("El dni no tiene el formato adecuado");
                        }
                        else
                        {
                            //Validar 1ue hay 8 digitos en las 8 primeras posiciones
                            for(int i = 0; i < 8; i++)
                            {
                                if (!char.IsDigit(dni[i]))
                                {
                                    correcto = false;
                                    Console.WriteLine("El dni no tiene 8 digitos");
                                    break;
                                }
                            }

                            if (correcto)
                            {
                                if (!char.IsLetter(dni[8]))
                                {
                                    correcto=false;
                                    Console.WriteLine("El DNI no tiene una letra en su última posición");
                                }
                            }

                            if (correcto)
                            {
                                //Si llego hasta aquí es porque el dni tiene formato correcto
                                //Ahora tengo que evaluar que la letra se corresponda con el número
                                char[] letras =  { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                                //Obtener resto de la división del numero entre 23
                                int resto = int.Parse(dni.Substring(0, 8)) % 23;

                                if (dni[8] != letras[resto])
                                {
                                    correcto = false;
                                    Console.WriteLine(" La letra no se corresponde debería de ser la letra: " + letras[resto]);
                                }

                        }

                            if (correcto)
                            {
                                Console.WriteLine("El dni es correcto!");
                            }
                        }




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

                        case 6:
                        string frase6;
                        int contadorAbas = 0;
                        Console.WriteLine("Intro frase: ");
                        frase6 = Console.ReadLine();
                        string cadenaBusqueda;
                        Console.WriteLine("Intro la cadena que desea buscar:");
                        cadenaBusqueda = Console.ReadLine(); 

                        string[] palabrasEj6 = frase6.Split(' ');

                        foreach(String p in palabrasEj6)
                        {
                            if (p.Contains(cadenaBusqueda))
                            {
                                contadorAbas++;
                            }
                        }

                        Console.WriteLine("Hay " + contadorAbas + " palabras que contienen " + cadenaBusqueda);

                        break;
                    case 9:
                        String frase9;
                        Console.WriteLine("Intro frase:");
                        frase9 = Console.ReadLine();

                        frase9 = frase9.Replace(' ', '*');
                        Console.WriteLine(frase9);
                        break;
                    case 10:
                        String registro = "nombre*fecha?2300";
                        int salario = int.Parse(registro.Split('?')[1]);
                        Console.WriteLine("El salario es de: " + salario);
                        String registro2 = "nombre*2500!19Agosto1990";
                        int salario2 = int.Parse(registro2.Split('*', '!')[1]);

                        Console.WriteLine("El salario2 es de :" + salario2);

                        if(salario2 > 1000)
                        {
                            Console.WriteLine("Mayor que 1000");
                        }
                        else
                        {
                            Console.WriteLine("Menor que 1000");
                        }



                        break;

                }
            }
            while (ejercicio < 10);
            Console.ReadLine();
        }
    }
}
