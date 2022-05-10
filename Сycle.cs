

namespace LuckyTickets
{
    public class Сycle
    {
        static int sum = 0;
        static int count = 0;
        public static int fullSearch()
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int q = 0; q <= 9; q++)
                    {
                        sum = i + j + q;
                        for (int w = 0; w <= 9; w++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                for (int r = 0; r <= 9; r++)
                                {
                                    if (sum == w + e + r)
                                    { count++; }
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }
    }


}
