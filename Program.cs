using System;

namespace Converter
{
    class Program
    {
        static int ConvertToInt(string stdin) {
            int power = stdin.Length - 1;
            int sum = 0;
            foreach (var num in stdin)
            {
                sum = sum + ((num - 48) * (int) Math.Pow(10, power));
                power--;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            Console.WriteLine(ConvertToInt(Console.ReadLine()));
        }
    }
}
