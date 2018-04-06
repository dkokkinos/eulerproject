using Interfaces;
using Problems_0_50.Largest_prime_factor;
using Problems_0_50.Multiplesof3and5;
using Problems_0_50.P2_Even_Fibonacci_numbers;
using Problems_0_50.P4_Largest_palindrome_product;
using Problems_0_50.P5_Smallest_multiple;
using Problems_0_50.P6_Sum_square_difference;
using Problems_0_50.P7_10001st_prime;
using Problems_0_50.P8_Largest_product_in_a_series;
using Problems_0_50.P9_Special_Pythagorean_triplet;
using Problems_0_50.Summation_of_primes;

namespace EulerConsole
{
    public class Program
    {
        static ISolvable Solvable => new SummationOfPrimesSolution();

        static void Main(string[] args)
        {
            ISolvable problem = Solvable;
            problem.Solve();
        }
        
    }
}
