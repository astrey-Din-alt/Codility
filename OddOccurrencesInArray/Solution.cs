using System.Linq;

namespace OddOccurrencesInArray
{
    public class Solution
    {
        public int GetOddOccurrencesInArray(int[] arr)
        {
            if (!arr.Any())
                return 0;
            if (arr.Count() < 1 && arr.Count() > 1000000)
                return 0;
            if (arr.Where(x => x > 1000000000).Any())
                return 0;
            return arr.GroupBy(x => x).Select(g => new { key = g.Key, count = g.Count() }).Where(g => (g.count % 2) == 1).FirstOrDefault().key;
        }
    }
}