using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbersInfo = new Stack<int>(numbers);

            while (true)
            {
                string line = Console.ReadLine();

                if (line=="end")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0].ToLower();

                switch (command)
                {
                    case "add":
                        numbersInfo.Push(int.Parse(tokens[1]));
                        numbersInfo.Push(int.Parse(tokens[2]));
                        break;
                    case "remove":
                        int count = int.Parse(tokens[1]);
                        if (numbersInfo.Count>=count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbersInfo.Pop();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {numbersInfo.Sum()}");
        }
    }
}
