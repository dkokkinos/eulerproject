using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P17_NumberLetterCounts_DesignPatterns
{
    public abstract class Operation
    {
        public abstract void Push(object value);
        public abstract object Pop();
    }

    public class SumOperation : Operation
    {
        public decimal sum = 0;
        private readonly bool _countSpaces;

        public SumOperation(bool countSpaces = false)
        {
            _countSpaces = countSpaces;
        }

        public override void Push(object value)
        {
            if (value is int v)
                this.sum += v;
            else if (value is decimal d)
                this.sum += d;
            else if (value is string s)
            {
                if (!this._countSpaces)
                    s = s.Replace(" ", "");
                this.sum += s.Length;
            }
        }

        public override object Pop()
        {
            return sum;
        }
    }

    public class AvgOperation : SumOperation
    {
        private int count;

        public AvgOperation(bool countSpaces = false) : base(countSpaces)
        {
        }

        public override void Push(object value)
        {
            base.Push(value);
            count++;
        }

        public override object Pop()
        {
            return sum / count;
        }
    }

}
