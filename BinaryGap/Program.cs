using System;

namespace BinaryGap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                int n;
                var line = Console.ReadLine();
                var isInt = int.TryParse(line, out n);
                var binary = Convert.ToString(n, 2);
                if (!isInt)
                    Console.WriteLine("Line is not number");
                else
                {
                    var result = Recursion.Solution(n);//Solution.solution(n);
                    Console.WriteLine($"Number {n} binary {binary} lenght is {result}");
                }
            }
        }
    }
}