namespace FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            if (X < 1 && X > 1000000000)
                return 0;
            if (Y < 1 && Y > 1000000000)
                return 0;
            if (D < 1 && D > 1000000000)
                return 0;
            if (X > Y)
                return 0;

            int dist = X;
            int count = 0;
            while (dist < Y)
            {
                count++;
                dist += D;
            }
            return count;
        }
    }
}