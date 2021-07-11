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
        public double score = 0;

        public Shift(Staff staff, string shiftType, DayOfWeek shiftdate, TimeSpan shiftStart, TimeSpan shiftEnd)
        {
            this.staff = staff;
            this.shiftType = shiftType;
            this.shiftdate = shiftdate;
            this.shiftStart = shiftStart;
            this.shiftEnd = shiftEnd;

            duration = shiftEnd - shiftStart;
            Evaluate();
        }

        public void ChangeShift(string shiftType, TimeSpan shiftStart, TimeSpan shiftEnd)
        {
            this.shiftType = shiftType;
            this.shiftStart = shiftStart;
            this.shiftEnd = shiftEnd;

            duration = shiftEnd - shiftStart;
            Evaluate();
        }

        public void Evaluate()
        {
            // Offset due to the enum starting from Sunday as opposed to Monday
            int offset = (int)shiftdate + 1;
            if(offset == 7)
            {
                offset = 0;
            }

            if(duration.TotalHours != 0)
            switch (staff.shiftPreference[offset])
            {
                case 0:
                        score += 5;
                        break;

                case 1:
                        if(shiftStart.TotalHours <= 12)
                            score += 5;
                        else
                            score -= 10;
                    break;

                case 2:
                        if (shiftStart.TotalHours > 12)
                            score += 5;
                        else
                            score -= 10;
                    break;

                case 3:
                        score -= 1000;
                    break;
            }
        }
    }
}
