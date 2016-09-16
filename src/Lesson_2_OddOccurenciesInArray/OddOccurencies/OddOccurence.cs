using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurencies
{
    public class OddOccurence
    {
        public int solution(int[] A)
        {
            var orderedData = A.OrderByDescending(x => (long)x).ToArray();

            for(int i = 0; i< orderedData.Count(); i += 2 )
            {
                // Extreme case, last one is the single number
                if (i == orderedData.Count() - 1)
                    return orderedData[i];

                if (orderedData[i] == orderedData[i + 1])
                    continue;
                else
                    return orderedData[i];
            }

            return 0;
        }
    }
}
