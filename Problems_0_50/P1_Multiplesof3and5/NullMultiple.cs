using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.Multiplesof3and5
{
    public class NullMultiple : Multiple
    {
        public override int Number
        {
            get
            {
                return -1;
            }
        }

        public override bool IsDivisible(int number)
        {
            return false;
        }
    }
}
