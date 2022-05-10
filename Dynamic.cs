

namespace LuckyTickets
{
    static class dynamic
    {


        static public long count(long n)
        {

            long[] totals = new long[n * 9 + 1];
            long[] digits = new long[n * 9 + 1];
            long d, j, maxs, maxt, s, luckyTickets;

            for (d = 0; d <= 9; d++)
                totals[d] = 1;

            for (j = 2; j <= n; j++)
            {
                maxs = j * 9;
                maxt = maxs - 9;
                for (s = 0; s <= maxt; s++)
                    digits[s] = totals[s];

                for (s = 0; s < maxs; s++)
                    totals[s] = 0;

                for (d = 0; d <= 9; d++)
                    for (s = 0; s <= maxt; s++)
                        totals[s + d] += digits[s];
            }


            luckyTickets = 0;
            for (s = 0; s <= n * 9; s++)
                luckyTickets += totals[s] * totals[s];

            return luckyTickets;


        }


    }
}
