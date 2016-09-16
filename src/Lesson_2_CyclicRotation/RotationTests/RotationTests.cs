using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rotation;

namespace RotationTests
{
    public class RotationTests
    {
        [Test]
        public void Cyclic_Rotation_Test_1()
        {
            Rotation.Rotation r = new Rotation.Rotation();

            var result = r.solution(new int[] { 3, 8, 9, 7, 6 }, 1);

            Assert.AreEqual(new int[] { 6, 3, 8, 9, 7 }, result);
        }

        [Test]
        public void Cyclic_Rotation_Test_2()
        {
            Rotation.Rotation r = new Rotation.Rotation();

            var result = r.solution(new int[] { 3, 8, 9, 7, 6 }, 3);

            Assert.AreEqual(new int[] { 9, 7, 6, 3, 8 }, result);
        }

        [Test]
        public void Cyclic_Rotation_Test_3()
        {
            Rotation.Rotation r = new Rotation.Rotation();

            var result = r.solution(new int[] { 3, 8, 9, 7, 6 }, 28);

            Assert.AreEqual(new int[] { 9, 7, 6, 3, 8 }, result);
        }


        [Test]
        public void Cyclic_Rotation_Test_4()
        {
            Rotation.Rotation r = new Rotation.Rotation();

            var result = r.solution(new int[] { -1000, -999, -1, 0, 1000 }, 3);

            Assert.AreEqual(new int[] { -1, 0, 1000, -1000, -999 }, result);
        }
    }
}
