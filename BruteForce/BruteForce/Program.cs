using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            for (int i = 0; i < 11; i++)
            {
                Thread th = new Thread(
                    () => bfb.MaxSubSequenceSum(testArray));
                Thread th1 = new Thread(
                    () => qbf.MaxSubSequenceSum(testArray));
                Thread th2 = new Thread(
                    () => lbf.MaxSubSequenceSum(testArray));
                th2.Start();
                th1.Start();
                th.Start();
            }
            Console.Out.WriteLine("Brute Force Basic     |Max Subsequence Sum: " + bfb.maxSum + " - Average Time taken: " + bfb.getTime() + "ms - O(N^3)");
            Console.Out.WriteLine("Quadratic Brute Force |Max Subsequence Sum: " + qbf.maxSum + " - Average Time taken: " + qbf.getTime() + "ms - O(N^2)");
            Console.Out.WriteLine("Linear Brute Force    |Max Subsequence Sum: " + lbf.maxSum + " - Average Time taken: " + lbf.getTime() + "ms - O(N)");
            Console.ReadKey();
        }

        
    }
}
