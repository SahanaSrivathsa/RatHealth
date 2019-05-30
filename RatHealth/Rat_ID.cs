using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatHealth
{
    public partial class Rat_ID : Form
    {
        private readonly Form RatHealthWindow;
        public Rat_ID()
        {
            InitializeComponent();
        }

        

        private void ratid_TextChanged(object sender, EventArgs e)
        {
            RatHealthCheck.rat_no = ratid.Text;
        }

        private void save_ratID_Click(object sender, EventArgs e)
        {
            var window = new RatHealthCheck();
            window.ShowDialog();
            this.Close();
            

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            RatHealthCheck.name_val = name.Text;
        }
    }
}
