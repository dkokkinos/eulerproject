using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P9_Special_Pythagorean_triplet
{
    public class SpecialPythagoreanTripletSolution : ISolvable
    {
        public void Solve()
        {
            int desiredSum = 1000;
            int c = 0;
            int b = 0;
            int a = 0;

            for(c = 0; c < desiredSum; c++)
            {
                for(b = 0; b < c; b++)
                {
                    for(a = 0; a < b ; a++)
                    {
                        if (a + b + c == desiredSum && IsTriplet(a, b, c))
                            goto exit;
                    }
                }
            }

            exit:

            Console.WriteLine($"the triplet with sum {desiredSum} is {a} {b} {c} and its product is {a*b*c}");

        }

        private bool IsTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}
