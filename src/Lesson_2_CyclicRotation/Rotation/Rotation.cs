using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation
{
    public class Rotation
    {
        public int[] solution(int[] A, int K)
        {
            int[] result = new int[A.Length];

            for(int i = 0; i< A.Length; i++)
            {
                // new index
                var newIdx = i + K;

                while (newIdx >= A.Length)
                {
                    newIdx -= A.Length;
                }

                result[newIdx] = A[i];
            }
            return result;
        }
    }
}
