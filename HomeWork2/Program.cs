using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");

            double div = (double)a / b;
            Console.WriteLine($"{a} / {b} = {div}");

            double res;
            res = -1 + 4 * 6;
            Console.WriteLine($"-1 + 4*6 = {res}");

            res = (35 + 5) % 7;
            Console.WriteLine($"(35 + 5) % 7 = {res}");

            //res = 14.0 + -4.0 * 6.0 / 11.0;
            res = 14 + (double)-4 * 6 / 11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {res}");

            res = 2 + (double)15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {res}");

            //--------------------------------------------------

            Console.WriteLine("Input first number ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"First number = {a}, Second number = {b}");

            int temp = a; 
            a = b; b = temp;

            Console.WriteLine($"First number = {a}, Second number = {b}");

            //---------------------------------------------------

            Console.WriteLine("Input the first number to multiply ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the third number to multiply ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication of three numbers = {a * b * c}");
        }
    }
}
