using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Optimiser.Objects
{
    class RotaCell
    {
        public TableLayoutPanel panel;
        public Label shiftType;
        public Label shiftTime;
        public ComboBox preferenceBox;

        public RotaCell()
        {
            panel = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 3,
                Dock = DockStyle.Fill
            };

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));

            shiftType = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = "Shift Type",
                TextAlign = ContentAlignment.MiddleCenter,
            };

            shiftTime = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Text = "Shift Time",
                TextAlign = ContentAlignment.MiddleCenter
            };

            preferenceBox = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
            };

            preferenceBox.Items.AddRange(new string[]
            {
            "Avaliable",
            "Morning",
            "Afternoon",
            "Unavaliable"
            });

            panel.Controls.Add(shiftType, 0, 0);
            panel.Controls.Add(shiftTime, 0, 1);
            panel.Controls.Add(preferenceBox, 0, 2);

        }

    }
}
