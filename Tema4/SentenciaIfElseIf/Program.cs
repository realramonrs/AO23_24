using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que clasifica un número como negativo, cero o positivo
            int numero = 900;

            if(numero < 0)
            {
                Console.WriteLine("Número negativo.");
            }
            else if(numero == 0)
            {
                Console.WriteLine("Número es cero.");
            }
            else
            {
                Console.WriteLine("Número positivo.");
            }

            //Programa que clasifica un número como múltiplo de 3 y de 5 o de uno de los dos o de ninguno

            int numeroX = 8;

            if(numeroX % 15 == 0)
            {
                Console.WriteLine("Múltiplo de 3 y de 5");
            }
            else if(numeroX % 3 == 0)
            {
                Console.WriteLine("Múltiplo de 3");
            }
            else if(numeroX % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 5");
            }
            else
            {
                Console.WriteLine("No es múltiplo de 3 ni de 5.");
            }

           

            //Para aprobar la asignatura debemos cumplir las siguientes condiciones:
            //Aprobar los exámenes
            //Aprobar las tareas
            // Buen comportamiento

            Boolean examenesAprobados = false;
            Boolean tareasAprobadas = false;
            Boolean comportamientoCorrecto = false;

            if (examenesAprobados)
            {
                if (tareasAprobadas)
                {
                    if (comportamientoCorrecto)
                    {
                        Console.WriteLine("Enhorabuena crack!");   
                    } // Fin if comportamientoCorrecto
                    else
                    {
                        Console.WriteLine("Exámenes y tareas aprobadas pero comportamiento incorrecto."); 
                    }
                } // Fin if tareasAprobadas
                else
                {
                    if (comportamientoCorrecto)
                    {
                        Console.WriteLine("Exámenes aprobados , tareas suspensas,comporatmiento ok");
                    }
                    else
                    {
                        Console.WriteLine("Exámenes aprobados , tareas suspensas y comportamiento deficiente");
                    }
                    
                }
            } // Fin examenes Aprobados
            else
            {
                if (tareasAprobadas)
                {
                    if (comportamientoCorrecto)
                    {
                        Console.WriteLine("Suspenso por los exámenes");
                    }
                    else
                    {
                        Console.WriteLine("Suspenso por exámenes y comportamiento");
                    }
                }
                else
                {
                    if (comportamientoCorrecto)
                    {
                        Console.WriteLine("Suspenso por exámenes por tareas pero comportamiento genial");
                    }
                    else
                    {
                        Console.WriteLine("Examen suspenso, tareas suspensas , comportamiento deficienet");
                    }
                }
                
            }






            //if (examenesAprobados && tareasAprobadas && comportamientoCorrecto)
            //{
            //    Console.WriteLine("Enhorabuena has aprobado");
            //}
            //else if (!examenesAprobados)
            //{
            //    if (!tareasAprobadas)
            //    {
            //        if (!comportamientoCorrecto)
            //        {
            //            Console.WriteLine("Mejor dedícate al parchís");
            //        }
            //        else {
            //            Console.WriteLine("Vaya desastre tío, exámenes y tareas suspensos");
            //        }
                    
            //    } // Cierra el if !tareasAprobadas
            //    else {
            //        Console.WriteLine("Exámenes suspensos.");
            //    }
                
            //}
            //else if (!tareasAprobadas)
            //{
            //    Console.WriteLine("Que triste suspender por no entregar las tareas");
            //}
            //else
            //{
            //    Console.WriteLine("Lo siento estás suspenso por cafre.");
            //}

            Console.ReadLine();
        }
    }
}
