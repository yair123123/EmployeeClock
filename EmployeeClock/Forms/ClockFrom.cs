using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class ClockFrom : Form
    {
        public ClockFrom()
        {
            InitializeComponent();
        }
        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FromHandler.ShowFrom("LoginForm");
        }
    }
}
