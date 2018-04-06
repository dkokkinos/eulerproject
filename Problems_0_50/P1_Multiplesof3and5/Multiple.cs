using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.Multiplesof3and5
{
    public abstract class Multiple
    {
        public Multiple Successor { get; set; }

        public abstract int Number { get; }

        public virtual bool IsDivisible(int number)
        {
            if (number % this.Number == 0)
                return true;
            return this.Successor.IsDivisible(number);
        }
        
    }
}
