using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Optimiser
{
    class Staff
    {
        public string name;
        public string position;
        public int contractHours;
        public int contractDays;
        public bool relief;
        public bool fullAccess;
        public bool overtime;
        public bool collection;
        public int[] shiftPreference;

        public Staff(string name, string position, int contractHours, int contractDays, bool overtime, bool collection, int[] shiftPreference)
        {
            this.name = name;
            this.position = position;
            this.contractHours = contractHours;
            this.contractDays = contractDays;
            this.overtime = overtime;
            this.collection = collection;
            this.shiftPreference = shiftPreference;

            switch (position)
            {
                case "Manager":
                case "Supervisor":
                    relief = true;
                    fullAccess = true;
                    break;

                case "Relief Supervisor":
                    relief = true;
                    fullAccess = false;
                    break;

                case "CSA":
                    relief = false;
                    fullAccess = false;
                    break;

            }
        }
    }
}
