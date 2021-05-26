using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
            Stack<string> expression = new Stack<string>(input);

            while (expression.Count>1)
            {
                int a = int.Parse(expression.Pop());
                string op = expression.Pop();
                int b = int.Parse(expression.Pop());

                if (op=="+")
                {
                    expression.Push((a+b).ToString());
                }
                else
                {
                    expression.Push((a - b).ToString());
                }
            }
            Console.WriteLine(expression.Pop());
        }
    }
}
