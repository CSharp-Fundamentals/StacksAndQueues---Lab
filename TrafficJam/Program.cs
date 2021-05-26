using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (true)
            {
                string car = Console.ReadLine();

                if (car=="end")
                {
                    break;
                }
                if (car=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count<1)
                        {
                            continue;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                    continue;
                }
                cars.Enqueue(car);
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
