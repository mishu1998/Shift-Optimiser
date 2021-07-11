using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Optimiser
{
    class Rota
    {
        public static Day[] days =
        {
            new Day(DayOfWeek.Monday, new TimeSpan(8,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Tuesday, new TimeSpan(6,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Wednesday, new TimeSpan(8,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Thursday, new TimeSpan(8,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Friday, new TimeSpan(8,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Saturday, new TimeSpan(8,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Sunday, new TimeSpan(11,0,0), new TimeSpan(23,0,0))
        };

        public static int[,] staffing = new int[7, 24];
        public static double rotaScore = 0;

    }
}
