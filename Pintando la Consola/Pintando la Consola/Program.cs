using System;

namespace Pintando_la_Consola
{
    class Program
    {
        protected static void WriteAt(ConsoleColor[] colors)
        {
            try
            {
                Random ran = new Random();
                int randomChar = ran.Next(5);
                char[] carac = { '.', '*', 'x', '-', '!' };
                int charColor = ran.Next(16);
                int charBackgrColor = ran.Next(16);
                int posX = ran.Next(80);
                int posY = ran.Next(24);

                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = colors[charColor];
                Console.BackgroundColor = colors[charBackgrColor];
                Console.Write(carac[randomChar]);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;

            for (int j = 0; j < 3000; j++)
            {
                WriteAt(colors);
            }

            Console.SetCursorPosition(80, 24);
            Console.ResetColor();
        }
    }

}
