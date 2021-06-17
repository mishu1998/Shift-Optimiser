using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Optimiser.Forms
{
    public partial class RotaPage : Form
    {
        MainWindow _owner;
        public RotaPage(MainWindow owner)
        {
            InitializeComponent();
            _owner = owner;
        }
    }
}
