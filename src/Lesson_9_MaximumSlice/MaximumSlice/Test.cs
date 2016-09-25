using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MaximumSlice
{
    class Test
    {
        [Test]
        public void MaximumSlice_Example()
        {

            var input = new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };
            Solution s = new Solution();

            var result = s.solution(input);

            // buy 1 sell 5
            Assert.AreEqual(356, result);
        }

        [Test]
        public void MaximumSlice_MinimumPrice()
        {
            var input = new int[] { 10, 11, 50, 8, 9, 10 };
            Solution s = new Solution();

            var result = s.solution(input);

            // Buy 0 sell 2
            Assert.AreEqual(40, result);
        }

        [Test]
        public void MaximumSlice_Test()
        {
            var input = new int[] { 100, 99, 98, 97, 100, 98 };
            Solution s = new Solution();

            var result = s.solution(input);

            // Buy 3 sell 4
            Assert.AreEqual(3, result);
        }

    }
}
