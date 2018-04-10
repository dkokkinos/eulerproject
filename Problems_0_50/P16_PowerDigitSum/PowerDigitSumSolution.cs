using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problems_0_50.P16_PowerDigitSum
{
    public class PowerDigitSumSolution : ISolvable
    {
        public void Solve()
        {
            var res = BigInteger.Pow(2, 1000);
            int sum = 0;
            foreach(var r in res.ToString())
            {
                sum += Convert.ToInt32( r.ToString() );
            }
            Console.WriteLine("sum is " + sum);
        }
    }
}
