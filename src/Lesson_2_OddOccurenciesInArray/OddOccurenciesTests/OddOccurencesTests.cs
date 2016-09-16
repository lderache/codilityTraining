using NUnit.Framework;
using OddOccurencies;

namespace OddOccurenciesTests
{
    public class OddOccurencesTests
    {
        [Test]
        public void Odd_Occurences_Example_Return_7()
        {
            OddOccurence oo = new OddOccurence();
            var data = new int[] { 9, 3, 9, 3, 9, 7, 9 };

            var result = oo.solution(data);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Odd_Occurences_Test_1()
        {
            OddOccurence oo = new OddOccurence();
            var data = new int[] { 1, 1, 1, 1, 1, 1, 2 };

            var result = oo.solution(data);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Odd_Occurences_Test_Big_Number()
        {
            OddOccurence oo = new OddOccurence();
            var data = new int[] { 2, 1, 2, 1, 1000000000, 1000000000, 6 };

            var result = oo.solution(data);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void Odd_Occurences_Test_More_Number()
        {
            OddOccurence oo = new OddOccurence();
            var data = new int[] { 2, 1, 2, 1, 3, 3, 3, 5, 5, 6, 6, 9, 9, 10, 10, 10, 11, 11, 10, 999, 1, 1, 999 };

            var result = oo.solution(data);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Odd_Occurences_Test_Extreme_Single()
        {
            OddOccurence oo = new OddOccurence();
            var data = new int[] { 6, 6, 2, 2, 3, 3, 4, 4, 5, 5, 1 };

            var result = oo.solution(data);

            Assert.AreEqual(1, result);
        }
    }
}
