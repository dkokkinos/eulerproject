using Interfaces;
using Problems_0_50.P26_ReciprocalCycles;

namespace EulerConsole
{
    public class Program
    {

        static ISolvable Solvable => new ReciprocalCyclesSolution();


        static void Main(string[] args)
        {
            ISolvable problem = Solvable;
            problem.Solve();
        }
        
    }
}
