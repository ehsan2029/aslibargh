using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barghkermanshah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void مدیریتکااربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Manage_Users usersabt = new frm_Manage_Users();
            usersabt.Show();
        }

        private void مدیریتشناسنامهپستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Manage_Post_Certificate frmpostc = new frm_Manage_Post_Certificate();
            frmpostc.Show();
        }

        private void ثبتپستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Manage_Post frmmp = new frm_Manage_Post();
            
            frmmp.Show();
        }
    }
}
