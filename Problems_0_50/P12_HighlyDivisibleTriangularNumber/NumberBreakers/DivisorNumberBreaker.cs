using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P12_HighlyDivisibleTriangularNumber.NumberBreakers
{
    public class DivisorNumberBreaker : INumberBreaker
    {
        public List<int> BreakNumber(int number)
        {
            List<int> res = new List<int>()
            {
                1
            };

            int i = 2;
            while (i < Math.Sqrt(number))
            {
                if (number%i == 0)
                {
                    res.Add(i);
                    if(i != (number / i))
                        res.Add(number / i);
                }

                i++;
            }
            
            res.Add(number);
            
            return res;
        }
    }
}
