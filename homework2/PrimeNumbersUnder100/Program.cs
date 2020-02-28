using System;

namespace PrimeNumbersUnder100
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] PrimeNum = new bool[101];
            for (int i = 2; i < 101; i++)
            {
                PrimeNum[i] = true;
            }
            for (int i = 2; i <= 10; i++)
            {
                if (PrimeNum[i])
                {
                    for (int j = 2; i * j < 101; j++)
                    {
                        PrimeNum[i * j] = false;
                    }
                }
            }
            for (int i = 2; i < 101; i++)
                if (PrimeNum[i])
                {
                    Console.Write(i + " ");
                }
        }
    }
}
