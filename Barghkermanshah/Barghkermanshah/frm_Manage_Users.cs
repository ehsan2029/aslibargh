using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

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
        private void insert_level()
        {
            Classconn clscon = new Classconn();
            SqlConnection con = new SqlConnection(clscon.connstr);
            string cmdString = "INSERT INTO  tbl_level (sathe_dastrasi) Values (@sathe_dastrasi)";
            string connString = clscon.connstr;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.CommandText = cmdString;
                    //comm.Parameters.AddWithValue("shomare_meli", TxtShomareMeli.Text);
                    comm.Parameters.AddWithValue("sathe_dastrasi", sathe_dastrasi.Text);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        //MessageBox.Show(this, "اطلاعات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        //Bind();
                        //this.usernTableAdapter.Fill(this.asalesam_bakhshDataSet5.usern);
                        //TxtShomareMeli.Text = "";
                        //sathe_dastrasi.Text = "";


                        //Bind();
                        //Clear();
                    }
                    catch
                    {
                        MessageBox.Show(this, "برنامه قادر به ذخیره سازی اطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
            }
        }
        private void insertuser_level()
        {
            Classconn clscon = new Classconn();
            SqlConnection con = new SqlConnection(clscon.connstr);
            string cmdString = "INSERT INTO  tbl_user_level (shomare_meli,sathe_dastrasi) Values (@shomare_meli,@sathe_dastrasi)";
            string connString = clscon.connstr;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("shomare_meli", TxtShomareMeli.Text);
                    comm.Parameters.AddWithValue("sathe_dastrasi", sathe_dastrasi.Text);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        //MessageBox.Show(this, "اطلاعات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        //Bind();
                        //this.usernTableAdapter.Fill(this.asalesam_bakhshDataSet5.usern);
                        //TxtShomareMeli.Text = "";
                        //sathe_dastrasi.Text = "";
                        

                        //Bind();
                        //Clear();
                    }
                    catch
                    {
                        MessageBox.Show(this, "برنامه قادر به ذخیره سازی اطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
            }
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TxtName.Equals("") || TxtFamily.Text.Equals("") || TxtShomareMeli.Text.Equals("") || TxtTavalod.Text.Equals("") || TxtMadrak.Text.Equals("") || TxtPhone.Text.Equals("") || TxtUsername.Text.Equals("") || sathe_dastrasi.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show(this, "اطلاعات ناقص هستند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            //-----------------------------------------------------------------
            Classconn clscon = new Classconn();
            SqlConnection con = new SqlConnection(clscon.connstr);
            SqlCommand com = new SqlCommand();
            int i = 0;
            com = new SqlCommand("SELECT COUNT(*) FROM View_user_level WHERE username= '" + TxtUsername.Text + "' and password='" + TxtPassword.Text + "' ", con);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                i = (int)com.ExecuteScalar();
            }//end if

            con.Close();

            if (i > 0)
            {
                MessageBox.Show(this, "کاربر با این مشخصات قبلا ثبت نام شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                return;
            }

            //------------------------------------------------------------

            string cmdString = "INSERT INTO  tbl_user (name,family,sale_tavalod,shomare_meli,email,madrak,telephone,username,password) Values (@name,@family,@sale_tavalod,@shomare_meli,@email,@madrak,@telephone,@username,@password)";
            string connString =clscon.connstr;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("name", TxtName.Text);
                    comm.Parameters.AddWithValue("family", TxtFamily.Text);
                    comm.Parameters.AddWithValue("sale_tavalod", TxtTavalod.Text);
                    comm.Parameters.AddWithValue("shomare_meli", TxtShomareMeli.Text);
                    comm.Parameters.AddWithValue("email", txtemail.Text);
                    comm.Parameters.AddWithValue("madrak", TxtMadrak.Text);
                    comm.Parameters.AddWithValue("telephone", TxtPhone.Text);
                    comm.Parameters.AddWithValue("username", TxtUsername.Text);
                    comm.Parameters.AddWithValue("password", TxtPassword.Text);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        //insert_level();
                        insertuser_level();
                        
                        MessageBox.Show(this, "اطلاعات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        //Bind();
                        this.view_user_levelTableAdapter.Fill(this.barghDataSet.View_user_level);
                        TxtName.Text="";
                         TxtFamily.Text="";
                         TxtTavalod.Text="";
                        TxtShomareMeli.Text="";
                         txtemail.Text="";
                         TxtMadrak.Text="";
                        TxtPhone.Text="";
                        TxtUsername.Text="";
                        TxtPassword.Text = "";
                        ////textBox9.Text = textBox1.Text;
                        //comboBox6.Text = comboBox3.Text;

                        //Bind();
                        //Clear();
                    }
                    catch
                    {
                        MessageBox.Show(this, "برنامه قادر به ذخیره سازی اطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
            }
        }
    }
}
