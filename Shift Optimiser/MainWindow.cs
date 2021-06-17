using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Optimiser
{
    public partial class MainWindow : Form
    {
        private Rota rota = new Rota();

        public MainWindow()
        {
            InitializeComponent();
            refreshTable();
        }

        public void refreshTable()
        {
            staffTable.Rows.Clear();
            staffTable.ColumnCount = 5;
            staffTable.Columns[0].HeaderText = "Name";
            staffTable.Columns[1].HeaderText = "Position";
            staffTable.Columns[2].HeaderText = "Contracted Hours";
            staffTable.Columns[3].HeaderText = "Contracted Days";
            staffTable.Columns[4].HeaderText = "Preferences";

            foreach (Staff staff in Global.staffMembers)
            {
                staffTable.Rows.Add(staff.name, staff.position, staff.contractHours, staff.contractDays);
            }

            staffTable.Refresh();
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaffPage addStaffPage = new AddStaffPage(this);
            addStaffPage.Show();
        }
    }
}
