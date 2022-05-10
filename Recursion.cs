

namespace LuckyTickets
{
    class Recursion
    {
        long count=0;
        
        public long Run(int n)
        {
            count = 0;
            RecursionSeach(n, 0, 0);
            return count;
        }

        void RecursionSeach(int n, int sumA, int sumB)
        {
            if (n == 0)
            {
                if (sumA == sumB)
                    count++;
                return;
            }

            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                    RecursionSeach(n - 1, sumA + a, sumB + b);
        }
    }
}
