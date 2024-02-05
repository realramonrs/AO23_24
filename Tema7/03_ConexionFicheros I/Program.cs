using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConexionFicheros2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ruta = Directory.GetCurrentDirectory() + "\\series.txt";
         
            int opcion = 0;
            
            
            StreamWriter escritor = new StreamWriter(ruta,true);

            escritor.WriteLine("True Detective*HBO");
            escritor.WriteLine("The Wire*HBO");
            escritor.Close();

            StreamReader sr = new StreamReader(ruta);

            String registro = "";

            while (registro != null)
            {
                registro = sr.ReadLine();
                Console.WriteLine(registro);
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
