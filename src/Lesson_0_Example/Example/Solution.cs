using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class ExampleSolution
    {
        public int Solution(int[] A)
        {
            long prefix = A[0];
            long suffix = (from item in A select (long)item).Sum() - A[0];
            int N = A.Length;

            // special case if P = 0
            if (suffix == 0)
                return 0;

            for (int i = 1; i < N - 1; i++)
            {
                if (i - 1 > 0)
                    prefix += A[i - 1];
                suffix -= A[i];

                if (prefix == suffix)
                    return i;

                // Special case if P = N-1
                if (i == (N - 2))
                {
                    if ((prefix + A[i]) == 0)
                        return i;
                }
            }

            // Default, no equilibrium found
            return -1;
        }
    }
}
