using System;


namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            var a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");
            var b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive:");

            if (a * b < 0)
                Console.WriteLine("True");
            else Console.WriteLine("False");

            ////---------------------------------------------------

            Console.WriteLine("Input first integer:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");
            b = Int32.Parse(Console.ReadLine());

            if (a + b == 20 || a == 20 || b == 20)
                Console.WriteLine("True");
            else Console.WriteLine("False");

            //-----------------------------------------------------

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1) Console.WriteLine(i);
            }

            //-------------------------------------------------------

            var sum = 0;
            var n = 500;

            for (int i = 2; i <= n; i++)
            {
                var flag = true;
                for (int j = 2; j < i; j++)
                    if (i % j == 0) flag = false;
                if (flag) sum = sum + i;

            }
            Console.WriteLine($"Sum of the first {n} prime numbers: {sum}");

            //-----------------------------------------------------------

            Console.WriteLine("Input a number :");
            var str = Console.ReadLine();
            sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                sum = sum + (int)Char.GetNumericValue(str[i]);
            }
            Console.WriteLine($"Sum of the digits : {sum}");
        }
    }
}
