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
        private int timesRun = 0;
        private long totalTime = 0;
        private Stopwatch sw = new Stopwatch();

        public int MaxSubSequenceSum(int[] input)
        {
            timesRun += 1;
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
            totalTime += sw.ElapsedMilliseconds;
            return maxSum;
        }

        public long getTime()
        {
            long o = totalTime / timesRun;
            return o;
        }
    }
}
