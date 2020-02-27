using System;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;

            Console.WriteLine("输入一个数字");
            while (!double.TryParse(Console.ReadLine(), out num1)) Console.WriteLine("输入错误，请输入一个数字");

            Console.WriteLine("输入另一个数字");
            while (!double.TryParse(Console.ReadLine(), out num2)) Console.WriteLine("输入错误，请输入一个数字");

            Console.WriteLine("输入运算符(+-*/)");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine(num2==0?"除零错误":$"{num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("输入错误，请输入运算符(+-*/)");
                    break;
            }
        }
    }
}
