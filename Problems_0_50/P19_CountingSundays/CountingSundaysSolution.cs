using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P19_CountingSundays
{
    public class CountingSundaysSolution : ISolvable
    {
        public void Solve()
        {
            int fromYear = 1901;
            int toYear = 2000;
            int sundays = 0;

            for(int year = fromYear; year <= toYear; year++)
            {
                for( int month = 1; month <= 12; month++)
                {
                    DateTime dt = new DateTime(year, month, 1 );
                    if (dt.DayOfWeek == DayOfWeek.Sunday)
                        sundays++;
                }
            }
            Console.WriteLine(sundays);
        }
        
    }
}
