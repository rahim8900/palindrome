using System;
namespace Palindrom
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int number = input.Length;
            int x = Convert.ToInt32(input);
            double s = x;
            double y = 0;
            for(int i = 1; i <= number; i++)
            {
                y = (s % 10 * Math.Pow(10, number-i)) + y;
                s = Math.Truncate(s /10);
            }
            if(x == y)Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
