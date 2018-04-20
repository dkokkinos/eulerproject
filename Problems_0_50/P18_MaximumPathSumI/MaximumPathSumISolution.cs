using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P18_MaximumPathSumI
{
    public class MaximumPathSumISolution : ISolvable
    {
        public void Solve()
        {
            List<List<int>> piramid = new List<List<int>>();
            piramid = GeneratePiramid();

            

        }

        private List<List<int>> GeneratePiramid()
        {
            return new List<List<int>>()
            {
                new List<int>() {               3               },
                new List<int>() {              7,4              },
                new List<int>() {             2,4,6              },
                new List<int>() {            8,5,9,3              }
            };
        }
    }
}
