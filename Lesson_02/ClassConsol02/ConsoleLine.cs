using System;

namespace Finances
{
    class ConsoleLine
    {
        public void WriteEnd(ConsoleColor color, string massage)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(massage);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void InputSum(ConsoleColor color, string massage)
        {
            Console.ForegroundColor = color;
            Console.Write(massage);
        }
    }
}
