using System;
using System.Linq;

namespace BinaryGap
{
    public static class Solution
    {
        public static int solution(int N)
        {
            if (N < 0 || N > 2147483647)
                return 0;
            char[] binary = Convert.ToString(N, 2).ToCharArray();
            int result = 0;
            while (binary.Any())
            {
                binary = binary.SkipWhile(x => x.CompareTo('1') == 0).ToArray();
                var gap = binary.TakeWhile(x => x.CompareTo('0') == 0 && binary.Contains('1'));
                if (!gap.Any())
                    break;
                var count = gap.Count();
                binary = binary.Skip(count).ToArray();
                if (count > result)
                    result = count;
            }
            return result;
        }
    }
}