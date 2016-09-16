using System;
using System.Linq;

namespace TapeEquilibrium
{
    public class TapeEquilibriumsolution
    {
        public int solution(int[] A)
        {
            // initialize prefix and suffix value by cutting after first element
            int prefixSum = A[0];
            int suffixSum = A.Sum() - A[0];

            int bestResult = Math.Abs(prefixSum - suffixSum);

            for (int i = 1; i < A.Length - 1; i++)
            {
                prefixSum += A[i];
                suffixSum -= A[i];

                var newResult = Math.Abs(prefixSum - suffixSum);

                // Save the new result
                if (newResult < bestResult)
                    bestResult = newResult;
            }

            return bestResult;
        }
    }
}
