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
                if (num < 48 || num > 57)
                    throw new Exception(num + " não é um numero");
                sum = sum + ((num - 48) * (int) Math.Pow(10, power));
                power--;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            try {
               Console.WriteLine(ConvertToInt(Console.ReadLine())); 
            } catch (Exception e) {
                Console.Write(e.Message);
            }
            
        }
    }
}
