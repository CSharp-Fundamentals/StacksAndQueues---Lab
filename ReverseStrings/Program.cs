using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> result = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                result.Push(text[i]);
            }

            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}
