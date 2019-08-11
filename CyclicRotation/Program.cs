using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {7, 6, 3, 8, 9 };
            int[] arr2 = new int[] { -3, -8, -9, 7, 6 };
            int[] arr3 = new int[] { 3, 8, 1000, -7, 6 };
            var sol = new Solution();
            var result1 = sol.solution(arr1,3);
            //Console.WriteLine("Initial data: " + string.Join(",", arr1));
            //Console.WriteLine("Result: " + string.Join(",", result1));
            //var result2 = sol.solution(arr2,3);
            //Console.WriteLine("Initial data: " + string.Join(",", arr2));
            //Console.WriteLine("Result: " + string.Join(",", result2));
            //var result3 = sol.solution(arr3,3);
            //Console.WriteLine("Initial data: " + string.Join(",", arr3));
            //Console.WriteLine("Result: " + string.Join(",", result3));
            Console.ReadKey();
        }
    }
}
