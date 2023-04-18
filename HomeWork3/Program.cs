using System;

namespace HomeWork3
{
    internal class Program
    {
        public delegate void DelegatePrintColorText(string text);
        public delegate void DelegatePrintTextByColor(string text, ConsoleColor color);
        static void Main(string[] args)
        {
            DelegatePrintColorText del1 = PrintGreen;
            DelegatePrintColorText del2 = PrintMagenta;
            del1.Invoke("Green text");
            del2.Invoke("Magenta text");

            DelegatePrintTextByColor del3 = Print;
            del3.Invoke("Red TextByColor", ConsoleColor.Red);
            del3.Invoke("Yellow TextByColor", ConsoleColor.Yellow);
        }

        static void PrintGreen(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
        }

        static void PrintMagenta(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
        }
    }
}
