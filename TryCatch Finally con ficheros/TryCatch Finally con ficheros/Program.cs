using System;

namespace TryCatch_Finally_con_ficheros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*v---- LEER FICHERO ----v*/

            int counter = 0;
            string line;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Kraze\Desktop\archivoTexto.txt");
            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
                file.Close();
            }
            catch (Exception e)
            {
                file.Close();
                Environment.Exit(0);
            }
            System.Console.WriteLine("There were {0} lines.", counter);

            /*v---- ORDENAR ARRAY ----v*/

            byte tamano = 0;
            do
            {
                Console.WriteLine("De cuántos números quieres hacer el array? (AVISO: Tendrás que ir introduciendo los números uno a uno. MÁXIMO 254, MÍNIMO 2.");
                tamano = Byte.Parse(Console.ReadLine());
            } while (tamano < 2 || tamano > 254);

            int[] numeros = new int[tamano];
            String array = "";
            Console.WriteLine("Escribe " + tamano + " números separados por INTRO para rellenar el array:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                array += numeros[i] + " ";
            }
            Console.WriteLine("El array que has rellenado quedaría así:\n" + array);
            Array.Sort(numeros);
            array = "";
            for (int i = 0; i < numeros.Length; i++)
            {
                array += numeros[i] + " ";
            }
            Console.WriteLine("El array ordenado sería así:\n" + array);

        }
    }

}
