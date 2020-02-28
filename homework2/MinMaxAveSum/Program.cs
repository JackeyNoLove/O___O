using System;

namespace MinMaxAveSum
{
    class Program
    {
        static void ReadIn(out int[]IntArray)
        {
            string Array = Console.ReadLine();
            string[] Splitted = Array.Split(' ');
            IntArray = new int[Splitted.Length];
            for (int i = 0; i < Splitted.Length; i++)
                IntArray[i] = int.Parse(Splitted[i]);
        }
        static void DealArray(int[] Array, out int Min, out int Max, out int Sum)
        {
            Min = Max = Sum = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Min > Array[i]) Min = Array[i];
                if (Max < Array[i]) Max = Array[i];
                Sum += Array[i];
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int[] IntArray;
                ReadIn(out IntArray);
                DealArray(IntArray, out int Min, out int Max, out int Sum);
                Console.WriteLine("Min:" + Min + " Max:" + Max + " Sum:" + Sum + " Ave:" + (double)Sum / IntArray.Length);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
