using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class LinearBruteForce
    {
        public int maxSum = 0;//Init
        private int seqStart { get; set; }
        private int seqEnd { get; set; }
        private int timesRun = 0;
        private long totalTime = 0;
        private Stopwatch sw = new Stopwatch();
        public void MaxSubSequenceSum(int[] input)
        {
            timesRun += 1;
            sw.Start();
            int thisSum = 0;
            for (int i = 0, j = 0; j < input.Length; j++)
            {
                thisSum += input[j];
                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                    seqStart = i;
                    seqEnd = j;
                }
                else if (thisSum < 0)
                {
                    i = j + 1;
                    thisSum = 0;
                }
            }
            sw.Stop();
            totalTime += sw.ElapsedMilliseconds;
        }

        public long getTime()
        {
            long o = totalTime / timesRun;
            return o;
        }
    }
}
