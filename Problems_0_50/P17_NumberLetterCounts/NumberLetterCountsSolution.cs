using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P17_NumberLetterCounts
{
    public class NumberLetterCountsSolution : ISolvable
    {
        #region words
        string[] one = new string[]
           {
                "",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
           };

        string[] ten = new string[]
        {
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
        };

        string[] tenth = new string[]
        {
            "",
            "",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };
        #endregion words

        public void Solve()
        {
            int from = 1;
            int to = 1000;

            int sum = 0;
            for(int i= from; i <= to; i++)
            {
                Console.WriteLine(this.NumberToWord(i));
                sum += this.NumberToWord(i).Replace(" ", string.Empty).Length;
            }
            Console.WriteLine("the sum is " + sum);
        }

        private string NumberToWord(int number)
        {
            if(number.ToString().Length == 4)
            {
                return "one thousand";
            }
            return this.ThreeDigitNumberToWord(number);
        }

        private string ThreeDigitNumberToWord(int number)
        {
            int first = Convert.ToInt32(number.ToString().Substring(0, 1));
            string secondhalf = "";
            if (number.ToString().Length == 3)
            {
                secondhalf = this.TwoDigitNumberToWord(Convert.ToInt32(number.ToString().Substring(1, 2)));
                secondhalf = string.IsNullOrEmpty(secondhalf) == false ? "and " + secondhalf: string.Empty;
                return $"{this.one[first]} hundred {secondhalf}";
            }

            return this.TwoDigitNumberToWord(number);

        }

        private string TwoDigitNumberToWord(int number)
        {
            int second = 0;
            if (number < 10)
            {
                return this.OneDigitNumberToWord(number);
            }
            else if (number >= 10 && number < 20)
            {
                second = Convert.ToInt32(number.ToString().Substring(1, 1));
                return this.ten[second];
            }

            int first = Convert.ToInt32(number.ToString().Substring(0, 1));
            second = Convert.ToInt32(number.ToString().Substring(1, 1));

            return this.tenth[first] + this.one[second];
        }

        private string OneDigitNumberToWord(int number)
        {
            return this.one[number];
        }

    }
}
