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
    public partial class frm_Manage_Voltages : Form
    {
        public frm_Manage_Voltages()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Manage_Voltages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barghDataSet.View_user_level' table. You can move, or remove it, as needed.
            this.view_user_levelTableAdapter.Fill(this.barghDataSet.View_user_level);

        }
    }
}
