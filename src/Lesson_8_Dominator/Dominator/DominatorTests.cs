using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Dominator
{
    class DominatorTests
    {
        [Test]
        public void Lesson_8_Dominator_Example()
        {
            var A = new int[] { 3, 4, 3, 2, 3, -1, 3, 3 };
            var d = new Dominator();

            var result = d.solution(A);

            var possibleResult = new int[] { 0, 2, 4, 6, 7 };
            Assert.IsTrue(possibleResult.Contains(result));
        }

        [Test]
        public void Lesson_8_Dominator_Empty()
        {
            var A = new int[] { };
            var d = new Dominator();

            var result = d.solution(A);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Lesson_8_Dominator_Single()
        {
            var A = new int[] { 3 };
            var d = new Dominator();

            var result = d.solution(A);
            Assert.AreEqual(0, result);
        }
    }
}
