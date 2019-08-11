using System;

namespace OddOccurrencesInArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 9, 3, 9, 7, 9, 3, 9 };
            var sol = new Solution();
            Console.WriteLine(sol.GetOddOccurrencesInArray(arr));
            Console.ReadKey();
        }
    }
}