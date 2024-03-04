using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //Insertar elementos
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            //Contar elementos
            int elementos = list.Count; //No es la capacidad es el número de posiciones no null
            //Obtener la capacidad
            int capacidad = list.Capacity;

            //Se puede recuperar un elemento por el índice
            int valorPosicion = list[2];
            //Se pueded buscar un elemento con método contains
            Boolean encontrado = list.Contains(2);

            //o con el método indexOf
            int pos = list.IndexOf(2);



            Console.WriteLine("Lista original: ");
            //Recorrer una lista para ver sus valores
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Lista original con for tradicional: ");
            //Con un for tradicional sería
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
           
            // insertar en una determinada posicion
            list.Insert(0, 9);

            Console.WriteLine("Lista tras insertar valor 9: ");
            
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Eliminar un elemento por posicion
            list.RemoveAt(0);

            //Eliminar un elemento por valor
            list.Remove(2);

            Console.WriteLine("Lista tras eliminar valores: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
