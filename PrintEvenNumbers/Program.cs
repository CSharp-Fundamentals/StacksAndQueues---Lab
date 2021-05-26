using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>(input);
            int length = numbers.Count;

            for (int i = 0; i < length; i++)
            {
                int current = numbers.Dequeue();
                if (current%2==0)
                {
                    numbers.Enqueue(current);
                }
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
