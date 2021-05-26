using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Queue<string> children = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine())-1;

            while (children.Count!=1)
            {
                for (int i = 0; i < n; i++)
                {
                    string kid = children.Dequeue();
                    children.Enqueue(kid);
                }
                Console.WriteLine($"Removed {children.Dequeue()}");
            }
            Console.WriteLine($"Last is {string.Join("",children)}");
        }
    }
}
