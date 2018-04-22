using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Problems_0_50.P26_ReciprocalCycles
{
    public class ReciprocalCyclesSolution : ISolvable
    {
        public void Solve()
        {
            int d = 1000;
            int max_length = 0;
            int max_d = 0;
            for (int i = d; i > 1; i--)
            {
                int l = this.FindReciprocalCycle(i);
                if (l > max_length)
                {
                    max_length = l;
                    max_d = i;
                }
            }

            Console.WriteLine("the maximum reciprocal cycle is " + max_length + " with d=" + max_d);
        }

        private int FindReciprocalCycle(int i)
        {
            List<int> remainders = new List<int>();

            int currentRemainder = 1;
            int multiplier = 1;
            for(int count = 0; count < i; count++)
            {
                currentRemainder = (currentRemainder * multiplier) %i;
                remainders.Add(currentRemainder);
                multiplier = 10;
                if (currentRemainder == 0)
                    break;
                if (remainders.Take(remainders.Count - 1).Contains(currentRemainder))
                {
                    int from = remainders.IndexOf(currentRemainder);
                    int to = remainders.Count - 1;
                    int lenght = to - @from;
                    return lenght;
                }
            } 
            
            return 0;
        }
    }
}
