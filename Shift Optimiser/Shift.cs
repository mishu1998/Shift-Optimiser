using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Optimiser
{
    class Shift
    {
        public Staff staff;
        public string shiftType;
        public DayOfWeek shiftdate;
        public TimeSpan shiftStart;
        public TimeSpan shiftEnd;
        public TimeSpan duration;
        public double score;

        public Shift(Staff staff, string shiftType, DayOfWeek shiftdate, TimeSpan shiftStart, TimeSpan shiftEnd)
        {
            this.staff = staff;
            this.shiftType = shiftType;
            this.shiftdate = shiftdate;
            this.shiftStart = shiftStart;
            this.shiftEnd = shiftEnd;
            score = 0;

            duration = shiftEnd - shiftStart;

            switch (shiftdate)
            {
                case DayOfWeek.Monday:
                    ScoreByPrefrence(0);
                    break;

                case DayOfWeek.Tuesday:
                    ScoreByPrefrence(1);
                    break;

                case DayOfWeek.Wednesday:
                    ScoreByPrefrence(2);
                    break;

                case DayOfWeek.Thursday:
                    ScoreByPrefrence(3);
                    break;

                case DayOfWeek.Friday:
                    ScoreByPrefrence(4);
                    break;

                case DayOfWeek.Saturday:
                    ScoreByPrefrence(5);
                    break;

                case DayOfWeek.Sunday:
                    ScoreByPrefrence(6);
                    break;
            }
            ScoreDuration();
        }

        private void ScoreByPrefrence(int day)
        {
            switch (staff.shiftPreference[day])
            {
                case -1:
                    score += 5;
                    break;

                case 0:
                    if (shiftStart.Hours <= 11 && shiftEnd.Hours <= 16)
                        score += 10;
                    else
                        score -= 15;
                    break;

                case 1:
                    if (shiftStart.Hours >= 14)
                        score += 10;
                    else
                        score -= 15;
                    break;
            }


        }

        private void ScoreDuration()
        {
            double durationScore = duration.TotalHours - (staff.contractHours / staff.contractHours);
            if ((durationScore > 0 && !staff.overtime) || durationScore < 0)
                score -= Math.Abs(durationScore);
        }
    }
}
