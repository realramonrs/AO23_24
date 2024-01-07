using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EjemplosBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración matriz de 2 filas y 3 columnas
            int[,] m = new int[2,3];
           
            //Acceso a los elementos utilizando los dos índices, el de fila y el de columna
            m[0,0] = 1;
            m[0,1] = 2;
            m[1,0] = 3;
            m[1,1] = 4;

            //Declaración e inicialización:
            int[,] n = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Propiedad length devuelve número total de elementos
            int elementos = m.Length;
            Console.WriteLine("Total elementos = " + m.Length);

            //Propiedad GetLength(i) -->Devuelve número de elementos de la dimensión especificada
            int numeroFilas = m.GetLength(0);
            int numeroColumnas = m.GetLength (1);

           Console.WriteLine("Número de filas: " + numeroFilas);
            Console.WriteLine("Número de columnas: " + numeroColumnas);

            //Obtener último índice de fila 
            int filas = m.GetUpperBound(0);
            //Obtener último índice de columna.
            int columnas = m.GetUpperBound (1);

            Console.WriteLine("Último índice de columna: " + columnas);
            Console.WriteLine("Último índice de fila: " + filas);

            //Recorrer completamente una matriz 2D
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++) {

                    Console.Write(m[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Calcular la media de los elementos de una matriz
            double media = 0;
            int suma = 0;

            for(int i = 0;i < m.GetLength(0);i++)
            {
                for(int j = 0;j < m.GetLength(1);j++)
                {
                    suma = suma + m[i,j];
                }
            }
            media = suma / m.Length; 



            Console.ReadLine();
            

        }
    }
}
