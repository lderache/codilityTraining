using NUnit.Framework;
using Example;
using System.Linq;

namespace ExampleTest
{
    public class ExampleTest
    {
        [Test]
        public void Example_Test_Demo_Array()
        {
            int[] A = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            ExampleSolution ex = new ExampleSolution();
            int[] equilibriums = new int[] { 1, 3, 7 };

            var result = ex.Solution(A);

            Assert.IsTrue(equilibriums.Contains(result));
        }

        [Test]
        public void Example_Test_P_Equal_N_Minus_1()
        {
            int[] A = new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 7 };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Example_Test_P_Equal_0()
        {
            int[] A = new int[] { 1, 1, 1, -2 };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Example_Extreme_Numbers_Overflow()
        {
            int[] A = new int[] { 2147483647, 2147483647, 0, 2147483647, 2147483647 };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Example_No_Equilibrium()
        {
            int[] A = new int[] { 1, 2147483647, 0 };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Example_Sum_0()
        {
            int[] A = new int[] { 0, 0, 0 };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Example_Single()
        {
            int[] A = new int[] { 1000 };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Example_Empty()
        {
            int[] A = new int[] { };
            ExampleSolution ex = new ExampleSolution();

            var result = ex.Solution(A);

            Assert.AreEqual(-1, result);
        }

    }
}
