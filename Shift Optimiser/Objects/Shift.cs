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

            duration = shiftEnd - shiftStart;
        }

        public void ChangeShift(string shiftType, TimeSpan shiftStart, TimeSpan shiftEnd)
        {
            this.shiftType = shiftType;
            this.shiftStart = shiftStart;
            this.shiftEnd = shiftEnd;

            duration = shiftEnd - shiftStart;
        }
    }
}
