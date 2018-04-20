using Interfaces;
using Problems_0_50.P15_LatticePaths;

namespace EulerConsole
{
    public class Program
    {
        static ISolvable Solvable => new LatticePathsSolution();

        static void Main(string[] args)
        {
            ISolvable problem = Solvable;
            problem.Solve();
        }
        
    }
}
