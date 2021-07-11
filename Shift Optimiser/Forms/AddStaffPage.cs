using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Shift_Optimiser
{
    public partial class AddStaffPage : Form
    {
        MainWindow _owner;
        public AddStaffPage(MainWindow owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            positionComboBox.SelectedIndex = -1;
            hoursNumericUpDown.Value = 40;
            daysNumericUpDown.Value = 5;
            overtimeCheckBox.Checked = false;
            collectionCheckBox.Checked = false;

            mondayComboBox.SelectedIndex = -1;
            tuesdayComboBox.SelectedIndex = -1;
            wednesdayComboBox.SelectedIndex = -1;
            thursdayComboBox.SelectedIndex = -1;
            fridayComboBox.SelectedIndex = -1;
            saturdayComboBox.SelectedIndex = -1;
            sundayComboBox.SelectedIndex = -1;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int[] shiftPrefrence = {
                mondayComboBox.SelectedIndex,
                tuesdayComboBox.SelectedIndex,
                wednesdayComboBox.SelectedIndex,
                thursdayComboBox.SelectedIndex,
                fridayComboBox.SelectedIndex,
                saturdayComboBox.SelectedIndex,
                sundayComboBox.SelectedIndex
            };

            Staff newStaff = new Staff(
                nameTextBox.Text,
                positionComboBox.Text,
                (int)hoursNumericUpDown.Value,
                (int)daysNumericUpDown.Value,
                overtimeCheckBox.Checked,
                collectionCheckBox.Checked,
                shiftPrefrence);

            Global.staffMembers.Add(newStaff);

            File.WriteAllText("staffconfig.json", string.Empty);
            using (StreamWriter file = File.CreateText("staffconfig.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Global.staffMembers);
            }

            _owner.refreshTable();
            Dispose();
        }
    }
}
