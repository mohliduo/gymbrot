using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GymBrot.View.User;

namespace GymBrot.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            LoadUserControlIntoPanel(new Home());
        }

        private void LoadUserControlIntoPanel(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
            control.BringToFront();
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel(new Home());
        }

        private void exerciseMenu_Click(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel(new Exercise());
        }

        private void activityMenu_Click(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel(new Activity());
        }
    }
}
