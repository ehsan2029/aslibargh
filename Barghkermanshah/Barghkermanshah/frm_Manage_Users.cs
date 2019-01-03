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
            // TODO: This line of code loads data into the 'barghDataSet2.View_user_level' table. You can move, or remove it, as needed.
            this.view_user_levelTableAdapter.Fill(this.barghDataSet2.View_user_level);
            // TODO: This line of code loads data into the 'barghDataSet1.View_user_level' table. You can move, or remove it, as needed.
            //this.view_user_levelTableAdapter.Fill(this.barghDataSet1.View_user_level);
            // TODO: This line of code loads data into the 'barghDataSet.View_user_level' table. You can move, or remove it, as needed.
            //this.view_user_levelTableAdapter.Fill(this.barghDataSet.View_user_level);
            btnedite.Enabled = false;
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
        private void BtnOk_Click_1(object sender, EventArgs e)
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
                    //comm.CommandText = cmdString;
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
                        this.view_user_levelTableAdapter.Fill(this.barghDataSet2.View_user_level);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfilter.Text.Equals(""))
            {
                MessageBox.Show(this, "لطفاً اطلاعات را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;

            }
            try
            {
                Classconn clscon = new Classconn();
                SqlConnection con = new SqlConnection(clscon.connstr);
                SqlDataAdapter adapt;
                DataTable dt;
                //con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from View_user_level", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                //Classconn clscon = new Classconn();
                SqlConnection con2 = new SqlConnection(clscon.connstr);
                //con = new SqlConnection(cs);
                con2.Open();
                adapt = new SqlDataAdapter("select * from View_user_level where shomare_meli like N'" + txtfilter.Text + "%' ", con2);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con2.Close();
                this.view_user_levelTableAdapter.Fill(this.barghDataSet2.View_user_level);
            }
            catch { MessageBox.Show(this, "برنامه قادر به فیلتراطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "del")
            {


                //string constring = System.Configuration.ConfigurationSettings.AppSettings["constr"];
                //using (SqlConnection con = new SqlConnection(constring))
                //{
                //    using (SqlCommand cmd = new SqlCommand("DELETE FROM t2 where Id = @Id;SELECT * FROM t2", con))
                //    {
                //        cmd.Parameters.AddWithValue("@id", dataGridView2.Rows[e.RowIndex].Cells[2].Value);con.Open();

                Classconn clscon = new Classconn();
                SqlConnection con = new SqlConnection(clscon.connstr);


                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_user where id_user = @id;SELECT * FROM tbl_user", con);
                cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                //cmd.Parameters.AddWithValue("mard", textBox5.Text);

                //this.view_user_levelTableAdapter.Fill(this.barghDataSet1.View_user_level);
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "edite")
            {
                BtnOk.Enabled = false;
                btnedite.Enabled = true;
                //textBox1.Enabled = false;

                if (dataGridView1.Rows.Count > 0)
                {
                    //textBox1.Enabled = false;
                    var row = dataGridView1.Rows[e.RowIndex];

                    TxtName.Text = row.Cells[2].Value.ToString();
                    TxtFamily.Text = row.Cells[3].Value.ToString();
                    TxtTavalod.Text = row.Cells[4].Value.ToString();
                    txtemail.Text = row.Cells[5].Value.ToString();
                    TxtMadrak.Text = row.Cells[6].Value.ToString();
                    TxtPhone.Text = row.Cells[7].Value.ToString();
                    TxtUsername.Text = row.Cells[8].Value.ToString();
                    TxtPassword.Text = row.Cells[9].Value.ToString();
                    TxtShomareMeli.Text = row.Cells[10].Value.ToString();
                    sathe_dastrasi.Text = row.Cells[11].Value.ToString();
                    //comboBox3.Text = row.Cells[9].Value.ToString();

                    label12.Text = row.Cells[12].Value.ToString();
                    label13.Text = row.Cells[13].Value.ToString();
                    //and so on

                    //dataGridView1.CurrentCell = row.Cells[0]; //set focus to first cell in first row
                }


            }
        }
        private void updateuser_level()
        {
           
                Classconn clscon = new Classconn();
                SqlConnection con = new SqlConnection(clscon.connstr);
                SqlCommand cmd = new SqlCommand("update tbl_user_level set sathe_dastrasi=@sathe_dastrasi where id= @id", con);

                cmd.CommandType = CommandType.Text;

                //cmd.Parameters.AddWithValue("shomare_meli", TxtShomareMeli.Text);
                cmd.Parameters.AddWithValue("sathe_dastrasi", sathe_dastrasi.Text);
                cmd.Parameters.AddWithValue("id", label13.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show(this, "اطلاعات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
               // this.view_user_levelTableAdapter.Fill(this.barghDataSet2.View_user_level);
                con.Close();
           
        }
        private void btnedite_Click(object sender, EventArgs e)
        {
          //  updateuser_level();

            if (TxtName.Equals("") || TxtFamily.Text.Equals("") || TxtShomareMeli.Text.Equals("") || TxtTavalod.Text.Equals("") || TxtMadrak.Text.Equals("") || TxtPhone.Text.Equals("") || TxtUsername.Text.Equals("") || sathe_dastrasi.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show(this, "اطلاعات ناقص هستند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            //try
            //{
                //-----------------------------------------------------
                Classconn clscon = new Classconn();
                SqlConnection con = new SqlConnection(clscon.connstr);
                //SqlCommand cmd = new SqlCommand("UPDATE tbl_user SET  (name,family,sale_tavalod,shomare_meli,email,madrak,telephone,username,password) Values (@name,@family,@sale_tavalod,@shomare_meli,@email,@madrak,@telephone,@username,@password) WHERE id_user = id_user ", con);
                SqlCommand cmd = new SqlCommand("update tbl_user set name=@name,family=@family,sale_tavalod=@sale_tavalod,shomare_meli=@shomare_meli,email=@email,madrak=@madrak,telephone=@telephone,username=@username,password=@password where id_user= @id_user", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("name", TxtName.Text);
                cmd.Parameters.AddWithValue("family", TxtFamily.Text);
                cmd.Parameters.AddWithValue("sale_tavalod", TxtTavalod.Text);
                cmd.Parameters.AddWithValue("shomare_meli", TxtShomareMeli.Text);
                cmd.Parameters.AddWithValue("email", txtemail.Text);
                cmd.Parameters.AddWithValue("madrak", TxtMadrak.Text);
                cmd.Parameters.AddWithValue("telephone", TxtPhone.Text);
                cmd.Parameters.AddWithValue("username", TxtUsername.Text);
                cmd.Parameters.AddWithValue("password", TxtPassword.Text);
                cmd.Parameters.AddWithValue("id_user", label12.Text);
                //--------------------------------------------------
                con.Open();
                cmd.ExecuteNonQuery();
               updateuser_level();
                MessageBox.Show(this, "تغییرات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                BtnOk.Enabled = true;
                btnedite.Enabled = false;
                TxtName.Text = "";
                TxtFamily.Text = "";
                TxtTavalod.Text = "";
                TxtShomareMeli.Text = "";
                txtemail.Text = "";
                TxtMadrak.Text = "";
                TxtPhone.Text = "";
                TxtUsername.Text = "";
                TxtPassword.Text = "";

                this.view_user_levelTableAdapter.Fill(this.barghDataSet2.View_user_level);
                con.Close();
            //}
            //catch
            //{
            //    MessageBox.Show(this, "برنامه قادر به ذخیره سازی اطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            //}
                }
            }
        }

        
    
