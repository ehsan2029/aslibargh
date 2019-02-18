namespace Barghkermanshah
{
    partial class frm_Manage_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manage_Users));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saletavalodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shomaremeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sathedastrasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewuserlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barghDataSet2 = new Barghkermanshah.barghDataSet2();
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSearchCodeMeli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSearchName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.CmbSatheDastrasi = new System.Windows.Forms.ComboBox();
            this.TxtCodeMeli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMadrak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTavalod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.view_user_levelTableAdapter = new Barghkermanshah.barghDataSet2TableAdapters.View_user_levelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserlevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barghDataSet2)).BeginInit();
            this.GbSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del,
            this.edite,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.saletavalodDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.madrakDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.shomaremeliDataGridViewTextBoxColumn,
            this.sathedastrasiDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewuserlevelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(894, 239);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // del
            // 
            this.del.HeaderText = "حذف";
            this.del.Name = "del";
            this.del.Text = "حذف";
            this.del.UseColumnTextForButtonValue = true;
            // 
            // edite
            // 
            this.edite.HeaderText = "ویرایش اطلاعات";
            this.edite.Name = "edite";
            this.edite.Text = "ویرایش";
            this.edite.UseColumnTextForButtonValue = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // saletavalodDataGridViewTextBoxColumn
            // 
            this.saletavalodDataGridViewTextBoxColumn.DataPropertyName = "sale_tavalod";
            this.saletavalodDataGridViewTextBoxColumn.HeaderText = "سال تولد";
            this.saletavalodDataGridViewTextBoxColumn.Name = "saletavalodDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "ایمیل";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // madrakDataGridViewTextBoxColumn
            // 
            this.madrakDataGridViewTextBoxColumn.DataPropertyName = "madrak";
            this.madrakDataGridViewTextBoxColumn.HeaderText = "مدرک";
            this.madrakDataGridViewTextBoxColumn.Name = "madrakDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "تلفن همراه";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "رمز عبور";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // shomaremeliDataGridViewTextBoxColumn
            // 
            this.shomaremeliDataGridViewTextBoxColumn.DataPropertyName = "shomare_meli";
            this.shomaremeliDataGridViewTextBoxColumn.HeaderText = "شماره ملی";
            this.shomaremeliDataGridViewTextBoxColumn.Name = "shomaremeliDataGridViewTextBoxColumn";
            // 
            // sathedastrasiDataGridViewTextBoxColumn
            // 
            this.sathedastrasiDataGridViewTextBoxColumn.DataPropertyName = "sathe_dastrasi";
            this.sathedastrasiDataGridViewTextBoxColumn.HeaderText = "سطح دسترسی";
            this.sathedastrasiDataGridViewTextBoxColumn.Name = "sathedastrasiDataGridViewTextBoxColumn";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewuserlevelBindingSource
            // 
            this.viewuserlevelBindingSource.DataMember = "View_user_level";
            this.viewuserlevelBindingSource.DataSource = this.barghDataSet2;
            // 
            // barghDataSet2
            // 
            this.barghDataSet2.DataSetName = "barghDataSet2";
            this.barghDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GbSearch
            // 
            this.GbSearch.BackColor = System.Drawing.Color.Transparent;
            this.GbSearch.Controls.Add(this.label14);
            this.GbSearch.Controls.Add(this.label13);
            this.GbSearch.Controls.Add(this.label12);
            this.GbSearch.Controls.Add(this.TxtSearchCodeMeli);
            this.GbSearch.Controls.Add(this.label11);
            this.GbSearch.Controls.Add(this.TxtSearchName);
            this.GbSearch.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GbSearch.ForeColor = System.Drawing.Color.Black;
            this.GbSearch.Location = new System.Drawing.Point(12, 12);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GbSearch.Size = new System.Drawing.Size(238, 192);
            this.GbSearch.TabIndex = 14;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "جستجو";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 28);
            this.label14.TabIndex = 5;
            this.label14.Text = "label14";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 28);
            this.label13.TabIndex = 4;
            this.label13.Text = "label13";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(117, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 28);
            this.label12.TabIndex = 3;
            this.label12.Text = "بر اساس کد ملی:";
            // 
            // TxtSearchCodeMeli
            // 
            this.TxtSearchCodeMeli.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSearchCodeMeli.Location = new System.Drawing.Point(6, 144);
            this.TxtSearchCodeMeli.Name = "TxtSearchCodeMeli";
            this.TxtSearchCodeMeli.Size = new System.Drawing.Size(217, 36);
            this.TxtSearchCodeMeli.TabIndex = 2;
            this.TxtSearchCodeMeli.TextChanged += new System.EventHandler(this.TxtSearchCodeMeli_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(145, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "بر اساس نام:";
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSearchName.Location = new System.Drawing.Point(6, 66);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Size = new System.Drawing.Size(217, 36);
            this.TxtSearchName.TabIndex = 0;
            this.TxtSearchName.TextChanged += new System.EventHandler(this.TxtSearchName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtPassword);
            this.groupBox2.Controls.Add(this.TxtUsername);
            this.groupBox2.Controls.Add(this.BtnOk);
            this.groupBox2.Controls.Add(this.CmbSatheDastrasi);
            this.groupBox2.Controls.Add(this.TxtCodeMeli);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtFamily);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtPhone);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtMadrak);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtTavalod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(650, 195);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEdit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Location = new System.Drawing.Point(7, 153);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(113, 36);
            this.BtnEdit.TabIndex = 35;
            this.BtnEdit.Text = "اعمال تغییرات";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.btnedite_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtEmail.Location = new System.Drawing.Point(125, 154);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(230, 36);
            this.TxtEmail.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(359, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 28);
            this.label10.TabIndex = 33;
            this.label10.Text = "ایمیل";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPassword.Location = new System.Drawing.Point(463, 159);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(109, 36);
            this.TxtPassword.TabIndex = 32;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUsername.Location = new System.Drawing.Point(462, 116);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(109, 36);
            this.TxtUsername.TabIndex = 31;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(7, 108);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(114, 39);
            this.BtnOk.TabIndex = 30;
            this.BtnOk.Text = "ثبت";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click_1);
            // 
            // CmbSatheDastrasi
            // 
            this.CmbSatheDastrasi.AutoCompleteCustomSource.AddRange(new string[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.CmbSatheDastrasi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbSatheDastrasi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.CmbSatheDastrasi.BackColor = System.Drawing.SystemColors.Window;
            this.CmbSatheDastrasi.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CmbSatheDastrasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CmbSatheDastrasi.FormattingEnabled = true;
            this.CmbSatheDastrasi.ItemHeight = 28;
            this.CmbSatheDastrasi.Items.AddRange(new object[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.CmbSatheDastrasi.Location = new System.Drawing.Point(211, 113);
            this.CmbSatheDastrasi.Margin = new System.Windows.Forms.Padding(2);
            this.CmbSatheDastrasi.Name = "CmbSatheDastrasi";
            this.CmbSatheDastrasi.Size = new System.Drawing.Size(144, 36);
            this.CmbSatheDastrasi.TabIndex = 29;
            this.CmbSatheDastrasi.Text = "بازدیدکننده";
            // 
            // TxtCodeMeli
            // 
            this.TxtCodeMeli.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtCodeMeli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCodeMeli.Location = new System.Drawing.Point(7, 22);
            this.TxtCodeMeli.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtCodeMeli.MaxLength = 10;
            this.TxtCodeMeli.Name = "TxtCodeMeli";
            this.TxtCodeMeli.Size = new System.Drawing.Size(114, 36);
            this.TxtCodeMeli.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(359, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "سطح دسترسی";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(125, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "شماره ملی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(576, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "رمز ورود";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtFamily
            // 
            this.TxtFamily.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFamily.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtFamily.Location = new System.Drawing.Point(211, 22);
            this.TxtFamily.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.Size = new System.Drawing.Size(144, 36);
            this.TxtFamily.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام خانوادگی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(575, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "نام کاربری";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPhone.Location = new System.Drawing.Point(7, 66);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtPhone.MaxLength = 11;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(114, 36);
            this.TxtPhone.TabIndex = 26;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtName.Location = new System.Drawing.Point(463, 22);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(109, 36);
            this.TxtName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(125, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "شماره همراه";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtMadrak
            // 
            this.TxtMadrak.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtMadrak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtMadrak.Location = new System.Drawing.Point(211, 66);
            this.TxtMadrak.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtMadrak.Name = "TxtMadrak";
            this.TxtMadrak.Size = new System.Drawing.Size(144, 36);
            this.TxtMadrak.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(576, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "نام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTavalod
            // 
            this.TxtTavalod.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTavalod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTavalod.Location = new System.Drawing.Point(463, 66);
            this.TxtTavalod.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtTavalod.Name = "TxtTavalod";
            this.TxtTavalod.Size = new System.Drawing.Size(108, 36);
            this.TxtTavalod.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(575, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "سال تولد";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(359, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "مدرک تحصیلی";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // view_user_levelTableAdapter
            // 
            this.view_user_levelTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_Manage_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.frm_Manage_Voltages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserlevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barghDataSet2)).EndInit();
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSearchName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.ComboBox CmbSatheDastrasi;
        private System.Windows.Forms.TextBox TxtCodeMeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMadrak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTavalod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEdit;
        private barghDataSet2 barghDataSet2;
        private System.Windows.Forms.BindingSource viewuserlevelBindingSource;
        private barghDataSet2TableAdapters.View_user_levelTableAdapter view_user_levelTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn edite;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saletavalodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madrakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shomaremeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sathedastrasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSearchCodeMeli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}