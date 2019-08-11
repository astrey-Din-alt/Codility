using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 3, 9, 7, 9, 3, 9 }; 
            var sol = new Solution();
            Console.WriteLine(sol.GetOddOccurrencesInArray(arr));
            Console.ReadKey();
        }
    }
}
