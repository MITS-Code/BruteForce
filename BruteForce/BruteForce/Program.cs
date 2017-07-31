using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[1000];
            for (int i = 0; i < testArray.Length; i++)
            {
                Random rng = new Random();
                testArray[i] = rng.Next(-100,100);
                Console.Out.WriteLine(i + " " + testArray[i]);
            }
            BruteForceBasic bfb = new BruteForceBasic();
            //TODO Implement Quadratic
            //TODO Implement Linear
            Console.Out.WriteLine("Max Subsequence Sum: " + MaxSubSequenceSum(testArray));
            Console.ReadKey();
        }

        
    }
}
