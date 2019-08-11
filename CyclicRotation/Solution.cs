using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            if (!A.Any())
                return new int[] { };

            if (A.Length > 100 && 0 < K && K < 100)
                return new int[] { };

            if (A.Where(x => x < -1000 || x > 1000).Any())
                return new int[] { };

            for (int i = 0; i < K; i++)
            {
                var newArr = SwipeFirstElementToEnd(A);
                A = newArr;
            }
            return A;
        }

        private int[] SwipeFirstElementToEnd(int[] arr)
        {
            IEnumerable<int> newArr = new List<int>() { arr.Last() };
            return newArr.Concat(arr.Take(arr.Length - 1)).ToArray();
        }
    }
}