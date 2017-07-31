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
            //instance Vars
            int[] testArray = new int[1000];
            int iterations = 100;

            //Processing
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
            Console.Out.WriteLine("Processing " + iterations + " iterations of each method...");
            Console.Out.WriteLine("Please watch CPU Temps!!!");

            for (int i = 0; i < iterations; i++) //More advanced threading example: https://stackoverflow.com/questions/29626685/how-to-run-two-threads-parallel
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

            //Outputting
            Console.Out.WriteLine("Brute Force Basic     |Max Subsequence Sum: " + bfb.maxSum + " - Average Time taken: " + bfb.getTime() + "ms - O(N^3)");
            Console.Out.WriteLine("Quadratic Brute Force |Max Subsequence Sum: " + qbf.maxSum + " - Average Time taken: " + qbf.getTime() + "ms - O(N^2)");
            Console.Out.WriteLine("Linear Brute Force    |Max Subsequence Sum: " + lbf.maxSum + " - Average Time taken: " + lbf.getTime() + "ms - O(N)");
            Console.ReadKey();
        }

        
    }
}
