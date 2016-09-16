using NUnit.Framework;
using CodilityBinaryGap;

namespace BinaryGapTests
{
    public class BinaryGapTests
    {
        [Test]
        public void Binary_Gap_Of_9_Equal_2()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(9);
            Assert.AreEqual(2, gap);
        }

        [Test]
        public void Binary_Gap_Of_529_Equal_4()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(529);
            Assert.AreEqual(4, gap);
        }

        [Test]
        public void Binary_Gap_Of_20_Equal_1()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(20);
            Assert.AreEqual(1, gap);
        }

        [Test]
        public void Binary_Gap_Of_15_Equal_0()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(15);
            Assert.AreEqual(0, gap);
        }

        [Test]
        public void Binary_Gap_Of_1041_Equal_5()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(1041);
            Assert.AreEqual(5, gap);
        }

        [Test]
        public void Binary_Gap_Of_1_Equal_0()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(1);
            Assert.AreEqual(0, gap);
        }

        [Test]
        public void Binary_Gap_Of_2147483647_Equal_0()
        {
            BinaryGap bg = new BinaryGap();
            var gap = bg.solution(2147483647);
            Assert.AreEqual(0, gap);
        }
    }
}
