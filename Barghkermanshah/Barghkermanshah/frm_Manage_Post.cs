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
    public partial class frm_Manage_Post : Form
    {
        public frm_Manage_Post()
        {
            InitializeComponent();
        }

        private void frm_Manage_Post_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barghDataSetnamepost.tbl_name_post' table. You can move, or remove it, as needed.
            this.tbl_name_postTableAdapter.Fill(this.barghDataSetnamepost.tbl_name_post);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (CmbOstan.Equals("") || TxtPostName.Text.Equals("") || CmbVoltage.Text.Equals("") )
            {
                MessageBox.Show(this, "اطلاعات ناقص هستند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            //-----------------------------------------------------------------
            Classconn clscon = new Classconn();
            SqlConnection con = new SqlConnection(clscon.connstr);
            SqlCommand com = new SqlCommand();
            //int i = 0;
            //com = new SqlCommand("SELECT COUNT(*) FROM View_user_level WHERE username= '" + TxtUsername.Text + "' and password='" + TxtPassword.Text + "' ", con);


            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //    i = (int)com.ExecuteScalar();
            //}//end if

            //con.Close();

            //if (i > 0)
            //{
            //    MessageBox.Show(this, "کاربر با این مشخصات قبلا ثبت نام شده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

            //    return;
            //}

            ////------------------------------------------------------------

            string cmdString = "INSERT INTO  tbl_name_post (ostan,voltage,name_post) Values (@ostan,@voltage,@name_post)";
            string connString = clscon.connstr;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("ostan", CmbOstan.Text);
                    comm.Parameters.AddWithValue("name_post", TxtPostName.Text);
                    comm.Parameters.AddWithValue("voltage", CmbVoltage.Text);
                    

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        MessageBox.Show(this, "اطلاعات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                        this.tbl_name_postTableAdapter.Fill(this.barghDataSetnamepost.tbl_name_post);
                        TxtPostName.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show(this, "برنامه قادر به ذخیره سازی اطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "del")
            {

                Classconn clscon = new Classconn();
                SqlConnection con = new SqlConnection(clscon.connstr);


                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_name_post where id_name_post = @id;SELECT * FROM tbl_name_post", con);
                cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
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
                BtnEdit.Enabled = true;
                //textBox1.Enabled = false;

                if (dataGridView1.Rows.Count > 0)
                {
                    //textBox1.Enabled = false;
                    var row = dataGridView1.Rows[e.RowIndex];     
                    CmbOstan.Text = row.Cells[3].Value.ToString();
                    TxtPostName.Text = row.Cells[5].Value.ToString();
                    CmbVoltage.Text = row.Cells[4].Value.ToString();
                    label13.Text = row.Cells[2].Value.ToString();
                    
                }


            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //  updateuser_level();

            if (CmbOstan.Equals("") || TxtPostName.Text.Equals("") || CmbVoltage.Text.Equals(""))
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
            SqlCommand cmd = new SqlCommand("update tbl_name_post set ostan=@ostan,name_post=@name_post,voltage=@voltage where id_name_post= @id_name_post", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("ostan", CmbOstan.Text);
            cmd.Parameters.AddWithValue("name_post", TxtPostName.Text);
            cmd.Parameters.AddWithValue("voltage", CmbVoltage.Text); 
            cmd.Parameters.AddWithValue("id_name_post", label13.Text);
            //cmd.Parameters.AddWithValue("id", label14.Text);

            //--------------------------------------------------
            con.Open();
            cmd.ExecuteNonQuery();
           // updateuser_level();
            MessageBox.Show(this, "تغییرات با موفقیت به ثبت رسید", "اتمام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            BtnOk.Enabled = true;
            BtnEdit.Enabled = false;
            TxtPostName.Text = "";

            this.tbl_name_postTableAdapter.Fill(this.barghDataSetnamepost.tbl_name_post);
            con.Close();
        }

        private void TxtSearchPostName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Classconn clscon = new Classconn();
                SqlConnection con = new SqlConnection(clscon.connstr);
                SqlDataAdapter adapt;
                DataTable dt;
                //con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from tbl_name_post", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                // SqlConnection con1 = new SqlConnection(clscon.connstr);
                con.Open();
                adapt = new SqlDataAdapter("select * from tbl_name_post where name_post like N'" + TxtSearchPostName.Text + "%' ", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                this.tbl_name_postTableAdapter.Fill(this.barghDataSetnamepost.tbl_name_post);
                //this.rostaTableAdapter.Fill(this.marzdbDataSet.rosta);
            }
            catch { MessageBox.Show(this, "برنامه قادر به نمایش اطلاعات نیست", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading); }
        }
    }
}
