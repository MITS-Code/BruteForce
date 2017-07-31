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
            Console.Out.WriteLine("Populating array with Random integers...");
            Random rng = new Random();
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = rng.Next(-100,100);
            }
            Console.Out.WriteLine("Populated " + testArray.Length + " values");
            BruteForceBasic bfb = new BruteForceBasic();
            QuadraticBruteForce qbf = new QuadraticBruteForce();
            LinearBruteForce lbf = new LinearBruteForce();
            Console.Out.WriteLine("===============");
            Console.Out.WriteLine("Processing...");
            for (int i = 0; i < 10; i++)
            {
                bfb.MaxSubSequenceSum(testArray);
                qbf.MaxSubSequenceSum(testArray);
                lbf.MaxSubSequenceSum(testArray);
            }
            Console.Out.WriteLine("Brute Force Basic     |Max Subsequence Sum: " + bfb.MaxSubSequenceSum(testArray) + " - Average Time taken: " + bfb.getTime() + "ms - O(N^3)");
            Console.Out.WriteLine("Quadratic Brute Force |Max Subsequence Sum: " + qbf.MaxSubSequenceSum(testArray) + " - Average Time taken: " + qbf.getTime() + "ms - O(N^2)");
            Console.Out.WriteLine("Linear Brute Force    |Max Subsequence Sum: " + lbf.MaxSubSequenceSum(testArray) + " - Average Time taken: " + lbf.getTime() + "ms - O(N)");
            Console.ReadKey();
        }

        
    }
}
