using System;

/*******************************
 * Autor: Kevin Rääk
 * Curso: 1-DAM-M
 * Asignación: Ejercicio de condiciones compuestas
 * Fecha de asignación: 5 de febrero
 * *****************************/

namespace EjCondicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            Console.WriteLine("Escriba un mes: ");
            mes = Console.ReadLine();

            if (mes.ToLower().Equals("enero") || mes.ToLower().Equals("febrero") || mes.ToLower().Equals("marzo") || mes.ToLower().Equals("ene") || mes.ToLower().Equals("feb") || mes.ToLower().Equals("mar"))
            {
                Console.WriteLine(mes + " SI pertenece al primer trimestre del año.");
            }
            else
            {
                Console.WriteLine(mes + " NO pertenece al primer trimestre del año.");
            }
        }
    }
}
