using Shift_Optimiser.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shift_Optimiser.Forms
{
    public partial class RotaPage : Form
    {
        MainWindow _owner;
        List<RotaCell> rotaCells = new List<RotaCell>();
        List<Label> staffLabels = new List<Label>();
        public RotaPage(MainWindow owner)
        {
            InitializeComponent();

            staffLabels = new List<Label> {
            staffLabel1,
            staffLabel2,
            staffLabel3,
            staffLabel4,
            staffLabel5,
            staffLabel6
            };

            _owner = owner;
            Generate();
            RefreshTable();
        }

        private void Generate()
        {
            int staffCount = Global.staffMembers.Count;

            for (int j = 0; j < staffCount; j++)
            {

                staffLabels[j].Text = Global.staffMembers[j].name + "\n" + Global.staffMembers[j].position;

                for (int i = 1; i < 8; i++)
                {
                    RotaCell cell = new RotaCell();
                    mainLayoutPanel.Controls.Add(cell.panel, i, j + 1);
                    rotaCells.Add(cell);

                    Rota.days[i - 1].Add(new Shift(Global.staffMembers[j], "Avaliable", Rota.days[i - 1].date, new TimeSpan(0), new TimeSpan(0)));
                }
            }
        }

        private void RefreshTable()
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (Shift shift in Rota.days[i].shifts)
                {
                    foreach (Label label in staffLabels)
                    {
                        if(label.Text == shift.staff.name + "\n" + shift.staff.position)
                        {
                            int staffID = staffLabels.IndexOf(label);
                            RotaCell currentCell = rotaCells[staffID * 7 + i];
                            currentCell.shiftType.Text = shift.shiftType;
                            if(shift.duration != new TimeSpan(0))
                            currentCell.shiftTime.Text = shift.shiftStart.ToString(@"hh\:mm") + " - " + shift.shiftEnd.ToString(@"hh\:mm") + " (" + shift.duration.TotalHours.ToString() + "h)";
                            else
                            {
                                currentCell.shiftTime.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            AI.Generate();
            RefreshTable();
        }
    }
}
