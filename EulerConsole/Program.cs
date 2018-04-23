using Interfaces;
using Problems_0_50.P26_ReciprocalCycles;
using Problems_0_50.P27_QuadraticPrimes;
using Problems_0_50.P28_NumberSpiralDiagonals;

namespace EulerConsole
{
    public class Program
    {

        static ISolvable Solvable => new NumberSpiralDiagonalsSolution();


        static void Main(string[] args)
        {
            ISolvable problem = Solvable;
            problem.Solve();
        }
        
    }
}
