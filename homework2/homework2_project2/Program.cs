using System;

namespace homework2_project2
{
    class Program
    {
        static void DealArray(int[] Array,out int Min,out int Max,out int Sum)
        {
            Min = Max = Sum = Array[0];
            for(int i = 1; i < Array.Length; i++)
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
                string Array = Console.ReadLine();              
                string[] Splitted = Array.Split(' ');                  
                int[] IntArray = new int[Splitted.Length];
                for (int i = 0; i < Splitted.Length; i++)        
                    IntArray[i] = int.Parse(Splitted[i]);

                int Min, Max, Sum;
                DealArray(IntArray,out Min,out Max,out Sum);
                Console.WriteLine("Min:"+ Min+ " Max:"+ Max+ " Sum:"+ Sum+ " Ave:"+ (double)Sum / IntArray.Length);
            }
            catch
            {
                Console.WriteLine("输入非整数");
            }
        }
    }
}
