using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OddOccurencies;
namespace OddOccurenciesRun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            OddOccurence oc = new OddOccurence();
            var result = oc.solution(A);

            Console.WriteLine("Result {0}", result);
            Console.ReadKey();
        }
    }
}
