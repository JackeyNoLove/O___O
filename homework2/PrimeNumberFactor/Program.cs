using System;

namespace PrimeNumberFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("输入一个正整数");
            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("输入错误，请输入一个正整数");
            }

            for (int i = 2; i * i <= num; i++) 
            {
                while (num % i == 0)
                {
                    num /= i;
                    Console.Write(i + " ");
                }
            }
            if (num > 1) { Console.Write(num); }
        }
    }
}

