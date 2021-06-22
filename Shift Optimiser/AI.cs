using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Optimiser
{
    class AI
    {
        static public void Generate()
        {
            foreach (Staff staff in Global.staffMembers)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < Rota.days[i].shifts.Count; j++)
                    {
                        if (Rota.days[i].shifts[j].staff == staff)
                        {
                            string shiftType = null;
                            TimeSpan shiftStart = new TimeSpan();
                            TimeSpan shiftEnd = new TimeSpan();

                            switch (staff.shiftPreference[i])
                            {
                                case 0: // Avaliable
                                    break;

                                case 1: // Morning
                                    shiftType = staff.position + " - Day Shift";
                                    shiftStart = Rota.days[i].startTime;
                                    shiftEnd = shiftStart + TimeSpan.FromHours(staff.contractHours / staff.contractDays);
                                    Rota.days[i].shifts[j].ChangeShift(shiftType, shiftStart, shiftEnd);
                                    break;

                                case 2: // Afternoon
                                    shiftType = staff.position + " - Day Shift";
                                    shiftEnd = Rota.days[i].endTime;
                                    shiftStart = shiftEnd - TimeSpan.FromHours(staff.contractHours / staff.contractDays);
                                    Rota.days[i].shifts[j].ChangeShift(shiftType, shiftStart, shiftEnd);
                                    break;

                                case 3: // Unavaliable
                                    shiftType = "Day Off";
                                    shiftStart = shiftEnd = new TimeSpan(0);
                                    Rota.days[i].shifts[j].ChangeShift(shiftType, shiftStart, shiftEnd);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
