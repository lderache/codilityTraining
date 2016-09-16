using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityBinaryGap
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            string binaryRep = Convert.ToString(N,2);

            string binaryRepWithoutTrailingZeros = binaryRep.TrimEnd('0');

            var gapsOrders = binaryRepWithoutTrailingZeros.Split('1').OrderByDescending(x => x.Length);

            return gapsOrders.ElementAt(0).Length;
        }
    }
}
