using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Tomate");
            set.Add("Cebolla");
            set.Add("Lechuga");
            set.Add("Aceite");

            //Los elementos no son indexados
            //Recorrer un conjunto
            foreach(String s in set)
            {
                Console.WriteLine(s);
            }

            //Métodos comunes con listas
            Boolean encontrado = set.Contains("Aceite");

            set.Remove("Aceite");

            //Quitar duplicados de una lista

            List<int> lista = new List<int>();
            Random gen = new Random();
            for(int i = 0;i<20;i++)
            {
                lista.Add(gen.Next(1,11));
            }

            Console.WriteLine("Lista generada: ");

            foreach(int i in lista)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            HashSet<int> set2 = new HashSet<int>(lista);
            Console.WriteLine("Lista generada sin duplicados: ");
            foreach (int i in set2)
            {
                Console.Write(i + " ");
            }

            //Conjunto ordenado:
            SortedSet<int> cto = new SortedSet<int>(set2);

            Console.WriteLine("Ordenado de menor a mayor: ");
            foreach(int i in cto)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

        }
    }
}
