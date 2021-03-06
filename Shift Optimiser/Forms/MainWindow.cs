using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shift_Optimiser.Forms;
using System.IO;
using Newtonsoft.Json;


namespace Shift_Optimiser
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadConfig();
            refreshTable();
        }

        private void LoadConfig()
        {
            try
            {
                string jsonRaw = File.ReadAllText("staffconfig.json");
                Global.staffMembers = JsonConvert.DeserializeObject<List<Staff>>(jsonRaw);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
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

        private void RotaButton_Click(object sender, EventArgs e)
        {
            RotaPage rotaPage = new RotaPage(this);
            rotaPage.Show();
        }
    }
}
