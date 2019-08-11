using System;

namespace FrogJmp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sol = new Solution();
            int X = 35,
                Y = 1523845,
                D = 53;
            var result = sol.solution(X, Y, D);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}