using System;

namespace BinaryGap
{
    public static class Recursion
    {
        public static int Solution(int n)
        {
            if (n < 0 || n > 2147483647)
                return 0;
            var binary = Convert.ToString(n, 2);
            return GetMaxBynaryGap(binary, 0);
        }

        private static int GetMaxBynaryGap(string str, int result)
        {
            int i;
            int currentCount = 0;
            bool startWithOne = false;
            bool endWithOne = false;
            if (str.Length == 0)
                return result;
            {
                for (i = 0; i < str.Length; i++)
                {
                    if (str[i] == '1' && !startWithOne)
                    {
                        startWithOne = true;
                        continue;
                    }
                    else if (str[i] == '0')
                    {
                        currentCount++;
                        continue;
                    }
                    else if (str[i] == '1' && !endWithOne)
                    {
                        endWithOne = true;
                        break;
                    }
                }
                str = str.Remove(0, (currentCount + 1));                
                if (currentCount > result && startWithOne && endWithOne)
                    result = currentCount;
                return GetMaxBynaryGap(str, result);
            }
        }
    }
}
