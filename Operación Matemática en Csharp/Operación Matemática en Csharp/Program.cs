using System;

namespace Operación_Matemática_en_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            char operacion = ' ';
            float resultado = 0f;
            String num1str = "";
            String num2str = "";
            float value;
            do
            {
                Console.WriteLine("Escribe el primer operando, asegúrate de que es un número");
                num1str = Console.ReadLine();
            } while (!float.TryParse(num1str, out value));
            num1 = float.Parse(num1str);
            do
            {
                Console.WriteLine("Escribe un operador válido ('+', '-', '*', '/' o '%')");
                operacion = Char.Parse(Console.ReadLine());
            } while (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/' && operacion != '%');

            do
            {
                do
                {
                    Console.WriteLine("Escribe el segundo operando, asegúrate de que es un número");
                    num2str = Console.ReadLine();
                } while (!float.TryParse(num2str, out value));
                num2 = float.Parse(num2str);
                if ((operacion == '/' || operacion == '%') && num2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre 0, por favor introduzca un segundo operando distinto de 0:");
                }
            } while ((operacion == '/' || operacion == '%') && num2 == 0);

            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '%':
                    resultado = num1 % num2;
                    break;
            }
            Console.WriteLine(num1 + operacion.ToString() + num2 + "=" + resultado);
        }
    }

}
