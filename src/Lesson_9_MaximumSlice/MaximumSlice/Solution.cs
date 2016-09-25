using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSlice
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var N = A.Length;
            List<int> pnlList = new List<int>();
            pnlList.Add(0); // day 0

            // compute pnl
            for (int i = 0; i < N - 1; i++)
            {
                pnlList.Add(A[i + 1] - A[i]);
            }

            // now maximize the pnl with Kadane algorithm
            int maxSoFar = 0;
            int maxEndingHere = 0;

            foreach (var x in pnlList)
            {
                maxEndingHere = Math.Max(0, maxEndingHere + x);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
}
