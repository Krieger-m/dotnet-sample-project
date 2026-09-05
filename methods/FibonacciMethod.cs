using System.Net;

namespace FibonacciMethod
{
    class FClass
    {
        public static int[] Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;

            List<int> res = new List<int>();

            res.Add(n1);
            res.Add(n2);

            for (int i = 2; i < n; i++)
            {
                int next = n1 + n2;
                res.Add(next);

                n1 = n2;
                n2 = next;
            }

            return res.ToArray();
        }
    }
}