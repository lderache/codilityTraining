using NUnit.Framework;
using TapeEquilibrium;

namespace TapeEquilibriumTests
{
    public class TapeEquilibriumTests
    {
        [Test]
        public void Tape_Test_1()
        {
            TapeEquilibriumsolution tes = new TapeEquilibriumsolution();
            var result = tes.solution(new int[] { 3, 1, 2, 4, 3 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Tape_Test_2()
        {
            TapeEquilibriumsolution tes = new TapeEquilibriumsolution();
            var result = tes.solution(new int[] { 3, 1 });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Tape_Test_3()
        {
            TapeEquilibriumsolution tes = new TapeEquilibriumsolution();
            var result = tes.solution(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tape_Test_4()
        {
            TapeEquilibriumsolution tes = new TapeEquilibriumsolution();
            var result = tes.solution(new int[] { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Tape_Test_5()
        {
            TapeEquilibriumsolution tes = new TapeEquilibriumsolution();
            var result = tes.solution(new int[] { -1000, 1000 });
            Assert.AreEqual(2000, result);
        }
    }
}
