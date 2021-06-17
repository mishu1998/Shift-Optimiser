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
            new Day(DayOfWeek.Monday, new TimeSpan(9,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Tuesday, new TimeSpan(6,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Wednesday, new TimeSpan(9,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Thursday, new TimeSpan(9,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Friday, new TimeSpan(9,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Saturday, new TimeSpan(9,0,0), new TimeSpan(23,0,0)),
            new Day(DayOfWeek.Sunday, new TimeSpan(11,0,0), new TimeSpan(23,0,0))
        };

        public static double rotaScore = 0;

        public void EvaluateRota()
        {
            foreach (Day day in days)
            {
                foreach (Shift shift in day.shifts)
                {
                    rotaScore += shift.score;
                }
            }
        }
    }
}
