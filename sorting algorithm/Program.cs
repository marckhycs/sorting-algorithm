using System;
using System.Collections.Generic;

namespace sorting_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.Write("How many numbers do you want to input? ");
            int total = int.Parse(Console.ReadLine());
            int start = 0;
            Console.WriteLine("Type here the numbers");

            while (start < total)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
                start++;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if (numbers[i]>numbers[j])
                    {
                        int sub = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = sub;
                    }
                }
            }
            Console.WriteLine(string.Format("Here is the sorted numbers: {0}", string.Join(",", numbers)));
        }
    }
}
