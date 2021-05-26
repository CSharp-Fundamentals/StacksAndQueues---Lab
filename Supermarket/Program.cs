using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name=="Paid")
                {
                    Console.WriteLine(string.Join("\n", names));
                    names.Clear();
                    continue;
                }
                if (name=="End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    break;
                }
                names.Enqueue(name);
            }
        }
    }
}
