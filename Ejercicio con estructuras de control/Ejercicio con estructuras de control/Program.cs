using System;

namespace Ejercicio_con_estructuras_de_control
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            Console.WriteLine("Escribe cuántos números quieres generar:");
            int numero = int.Parse(Console.ReadLine());

            String numeros = "";
            String numerosPares = "";
            int contadorPares = 0;
            int[] pares = new int[numero];
            for (int i = 0; i < numero; i++)
            {
                int num = ran.Next(0, 100);
                numeros += num + " ";
                if ((num % 2) == 0)
                {
                    numerosPares += num + " ";
                    pares[contadorPares] = num;
                    contadorPares++;
                }
            }

            Console.WriteLine("Los números generados son:\n" + numeros);
            if (contadorPares > 0)
            {
                Console.WriteLine("De los cuáles, éstos son pares:\n" + numerosPares);

                if (contadorPares > 1)
                {
                    String productoPares = "";
                    int producto = 1;
                    for (int i = 0; i <= contadorPares - 1; i++)
                    {
                        if (i != contadorPares - 1)
                        {
                            productoPares += pares[i] + "x";
                        }
                        else
                        {
                            productoPares += pares[i];
                        }
                        producto = producto * pares[i];
                    }
                    Console.WriteLine("El producto de " + productoPares + " es: " + producto);
                }
            }
            else
            {
                Console.WriteLine("De los cuáles, ninguno es par.");
            }

        }
    }

}
