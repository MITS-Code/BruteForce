using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class QuadraticBruteForce //N^2 Complexity
    {
        int maxSum = 0;//Init
        private int seqStart { get; set; }
        private int seqEnd { get; set; }
        private Stopwatch sw = new Stopwatch();
        public int MaxSubSequenceSum(int[] input)
        {
            sw.Start();
            for (int i = 0; i < input.Length; i++)
            {
                int thisSum = 0;
                for (int j = i; j < input.Length; j++)
                {
                    thisSum += input[j];
                    if (thisSum > maxSum)
                    {
                        maxSum = thisSum;
                        seqStart = i;
                        seqEnd = j;
                    }
                }
            }
            sw.Stop();
            return maxSum;
        }

        public long getTime()
        {
            return sw.ElapsedMilliseconds;
        }
    }
}
