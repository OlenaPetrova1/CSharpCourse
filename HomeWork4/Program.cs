using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 30;
            var c = 1;

            var max = GetMaxValue(a,b,c);
            Console.WriteLine($"max = {max}");

            var min = GetMinValue(a,b,c);
            Console.WriteLine($"min = {min}");

            FindNearestValueTo20(a, b);

            int[] arr = new int[] { 1, 3, 5, 7, 1 };
            Console.WriteLine($"Sum of the array numbers = {GetArraySum(arr)}");
            Console.WriteLine($"Max value in array = {GetArrayMaxValue(arr)}");

        }

        static int GetMaxValue(int a, int b, int c)
        {
            if (a >= b && a >= c) return a;
            else if (b >= a  && b >= c) return b;
            else return c;
        }

        static int GetMinValue(int a, int b, int c)
        {
            if (a <= b && a <= c) return a;
            else if (b <= a && b <= c) return b;
            else return c;
        }

        static void FindNearestValueTo20(int a, int b)
        {
            if (Math.Abs(20 - a) < Math.Abs(20 - b))
                Console.WriteLine($"Nearest value to 20 is {a}");
            else if (Math.Abs(20 - b) < Math.Abs(20 - a))
                Console.WriteLine($"Nearest value to 20 is {b}");
            else if (Math.Abs(20 - a) == Math.Abs(20 - b))
                Console.WriteLine($"Nearest value to 20 is both numbers {a} and {b}");
            else 
                Console.WriteLine($"Values are equal");
        }

        static int GetArraySum(int[] array)
        {
            var sum = 0;
            for (var i = 0; i < array.Length; i++)  
                sum +=array[i];
            return sum;
        }

         static int GetArrayMaxValue(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue) maxValue = array[i];
            }
            return maxValue;
        }
    }
}
