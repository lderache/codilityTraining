using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodilityBinaryGap;

namespace BinaryGapRun
{
    class Program
    {
        static void Main(string[] args)
        {
            CodilityBinaryGap.BinaryGap bg = new CodilityBinaryGap.BinaryGap();
            var gap = bg.solution(9);
            Console.WriteLine("Binary Gap is {0}", gap);
            Console.ReadKey();
        }
    }
}
