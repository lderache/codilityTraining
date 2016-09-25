using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominator
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return -1;

            Dictionary<int, int> occurences = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (occurences.ContainsKey(A[i]))
                {
                    occurences[A[i]]++;
                }
                else
                {
                    occurences.Add(A[i], 1);
                }
            }

            var first = occurences.OrderByDescending(x => x.Value).First();

            if (first.Value > A.Length / 2)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == first.Key)
                        return i;
                }
            }

            return -1;
        }
    }
}
