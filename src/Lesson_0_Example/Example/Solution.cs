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
            int N = A.Length;
            if (N == 0)
                return -1;

            long prefix = 0;
            long sum = (from item in A select (long)item).Sum();

            for (int i = 0; i < N; i++)
            {
                long suffix = sum - prefix - (long)A[i];
                if (suffix == prefix)
                    return i;
                prefix += (long)A[i];
            }

            // Default, no equilibrium found
            return -1;
        }
    }
}
