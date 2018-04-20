using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P24_LexicographicPermutations
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Heap%27s_algorithm
    /// </summary>
    public class LexicographicPermutationsSolution : ISolvable
    {
        public void Solve()
        {

            generate(10, new int[10]
            {
                0,1,2,3,4,5,6,7,8,9
            });
            long x = this.list.ElementAt(999999);
            
        }

        private static int counter = 0;
        private SortedSet<long> list = new SortedSet<long>();

        private void generate(int n, int[] A)
        {
            if(n == 1)
            {
                list.Add(Int64.Parse(string.Join("", A)));
            }
            else
            {
                for (int i = 0; i < n-1; i++)
                {
                    generate(n - 1, A);
                    if (n % 2 == 0)
                    {
                        int temp = A[i];
                        A[i] = A[n - 1];
                        A[n - 1] = temp;
                    }
                    else
                    {
                        int temp = A[0];
                        A[0] = A[n - 1];
                        A[n - 1] = temp;
                    }
                }
                generate(n - 1, A);
            }
        }
        
    }
}
