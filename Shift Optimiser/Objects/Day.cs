using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Optimiser
{
    class Day
    {
        public DayOfWeek date;
        public TimeSpan startTime;
        public TimeSpan endTime;
        public bool isCollection;
        public List<Shift> shifts = new List<Shift>();

        public Day(DayOfWeek date, TimeSpan startTime, TimeSpan endTime)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;

            if(startTime.Hours <= 6)
            {
                isCollection = true;
            }
        }

        public void Add(Shift shift)
        {
            shifts.Add(shift);
        }
    }
}
