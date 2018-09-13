using System;
using System.Xml;

namespace KnockKnock.Web.Services
{
    public class FibonacciService : IFibonacciService
    {
        public long Calculate(long count)
        {
            return count >= 0 ? PositiveCount(count) : NegativeCount(count);
        }

        private static long PositiveCount(long count)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for (long i = 0; i < count; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return a;
        }

        private static long NegativeCount(long count)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for (long i = -1; i > count; i--)
            {
                c = a - b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
