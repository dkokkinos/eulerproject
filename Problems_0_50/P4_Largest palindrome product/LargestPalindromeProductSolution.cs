using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P4_Largest_palindrome_product
{
    public class LargestPalindromeProductSolution : ISolvable
    {
        public void Solve()
        {
            int left = 999;
            int right = 999;
            long product = 0;
            long max = 0;
            int downLimit = 900;
            
            for (int i = left; i > downLimit; i--)
            {
                for (int j = right; j > downLimit; j--)
                {
                    product = i * j;
                    if (this.IsPalindrome(product.ToString()))
                    {
                        if(product > max)
                        {
                            max = product;
                            left = i;
                            right = j;
                        }
                    }
                }
            }
                
            Console.WriteLine($"the biggest digits produce a palindrome are {left} and {right} of {max}");

        }
        
        public bool IsPalindrome(string number)
        {
            int numberOfDigits = number.Length;
            for(int digit = 0; digit < numberOfDigits / 2; digit++)
            {
                if (number[digit] != number[number.Length - digit - 1])
                    return false;
            }
            return true;
        }
    }
}
