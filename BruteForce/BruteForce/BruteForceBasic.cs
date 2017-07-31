using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class BruteForceBasic //N^3 complexity 
    {
        int maxSum = 0;//Init
        private int seqStart { get; set; }
        private int seqEnd{ get; set; }
        private Stopwatch sw = new Stopwatch();
        public int MaxSubSequenceSum(int[] input)
        {
            sw.Start();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    int thisSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        thisSum += input[k];
                    }
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
