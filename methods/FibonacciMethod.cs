using System.Net;
using System.Diagnostics;

namespace FibonacciMethod
{
    class FClass
    {
        public static int[] Fibonacci(int n)
        {
            Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
            Debug.WriteLine($"We are looking for {n} numbers");

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

                Debug.WriteLineIf(next == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
            }

            // If n2 is 5 continue, else break.
            // Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");

            return res.ToArray();
        }
    }
}