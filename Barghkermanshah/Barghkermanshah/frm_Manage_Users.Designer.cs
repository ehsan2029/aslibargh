﻿namespace Barghkermanshah
{
    partial class frm_Manage_Voltages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manage_Voltages));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.TxtShomareMeli = new System.Windows.Forms.TextBox();
            this.TxtTavalod = new System.Windows.Forms.TextBox();
            this.TxtMadrak = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.CmbLevel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.barghDataSet = new Barghkermanshah.barghDataSet();
            this.viewuserlevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_user_levelTableAdapter = new Barghkermanshah.barghDataSetTableAdapters.View_user_levelTableAdapter();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barghDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserlevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Bardiya", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام خانوادگی:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(671, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "شماره ملی:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "سطح دسترسی:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(410, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "مدرک تحصیلی:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(667, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "نام کاربری:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(671, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "سال تولد:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(160, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "شماره همراه:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(671, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "رمز ورود:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(514, 9);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(149, 37);
            this.TxtName.TabIndex = 0;
            // 
            // TxtFamily
            // 
            this.TxtFamily.Location = new System.Drawing.Point(256, 8);
            this.TxtFamily.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.Size = new System.Drawing.Size(146, 37);
            this.TxtFamily.TabIndex = 1;
            // 
            // TxtShomareMeli
            // 
            this.TxtShomareMeli.Location = new System.Drawing.Point(6, 8);
            this.TxtShomareMeli.Margin = new System.Windows.Forms.Padding(4);
            this.TxtShomareMeli.MaxLength = 10;
            this.TxtShomareMeli.Name = "TxtShomareMeli";
            this.TxtShomareMeli.Size = new System.Drawing.Size(146, 37);
            this.TxtShomareMeli.TabIndex = 2;
            // 
            // TxtTavalod
            // 
            this.TxtTavalod.Location = new System.Drawing.Point(514, 54);
            this.TxtTavalod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTavalod.Name = "TxtTavalod";
            this.TxtTavalod.Size = new System.Drawing.Size(149, 37);
            this.TxtTavalod.TabIndex = 3;
            // 
            // TxtMadrak
            // 
            this.TxtMadrak.Location = new System.Drawing.Point(256, 52);
            this.TxtMadrak.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMadrak.Name = "TxtMadrak";
            this.TxtMadrak.Size = new System.Drawing.Size(146, 37);
            this.TxtMadrak.TabIndex = 4;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(6, 52);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone.MaxLength = 11;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(146, 37);
            this.TxtPhone.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.BtnOk);
            this.panel1.Controls.Add(this.CmbLevel);
            this.panel1.Controls.Add(this.TxtShomareMeli);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtFamily);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtPhone);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtMadrak);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtTavalod);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 191);
            this.panel1.TabIndex = 9;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(6, 101);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(146, 63);
            this.BtnOk.TabIndex = 9;
            this.BtnOk.Text = "ثبت";
            this.BtnOk.UseVisualStyleBackColor = false;
            // 
            // CmbLevel
            // 
            this.CmbLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.CmbLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.CmbLevel.BackColor = System.Drawing.SystemColors.Window;
            this.CmbLevel.FormattingEnabled = true;
            this.CmbLevel.ItemHeight = 30;
            this.CmbLevel.Items.AddRange(new object[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.CmbLevel.Location = new System.Drawing.Point(256, 97);
            this.CmbLevel.Name = "CmbLevel";
            this.CmbLevel.Size = new System.Drawing.Size(146, 38);
            this.CmbLevel.TabIndex = 8;
            this.CmbLevel.Text = "بازدیدکننده";
            this.CmbLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.saletavalodDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.madrakDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.shomaremeliDataGridViewTextBoxColumn,
            this.sathedastrasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewuserlevelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 274);
            this.dataGridView1.TabIndex = 10;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(514, 98);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(151, 37);
            this.TxtUsername.TabIndex = 10;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(514, 141);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(151, 37);
            this.TxtPassword.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(410, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "ایمیل:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 37);
            this.textBox1.TabIndex = 13;
            // 
            // barghDataSet
            // 
            this.barghDataSet.DataSetName = "barghDataSet";
            this.barghDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewuserlevelBindingSource
            // 
            this.viewuserlevelBindingSource.DataMember = "View_user_level";
            this.viewuserlevelBindingSource.DataSource = this.barghDataSet;
            // 
            // view_user_levelTableAdapter
            // 
            this.view_user_levelTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // saletavalodDataGridViewTextBoxColumn
            // 
            this.saletavalodDataGridViewTextBoxColumn.DataPropertyName = "sale_tavalod";
            this.saletavalodDataGridViewTextBoxColumn.HeaderText = "sale_tavalod";
            this.saletavalodDataGridViewTextBoxColumn.Name = "saletavalodDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // madrakDataGridViewTextBoxColumn
            // 
            this.madrakDataGridViewTextBoxColumn.DataPropertyName = "madrak";
            this.madrakDataGridViewTextBoxColumn.HeaderText = "madrak";
            this.madrakDataGridViewTextBoxColumn.Name = "madrakDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // shomaremeliDataGridViewTextBoxColumn
            // 
            this.shomaremeliDataGridViewTextBoxColumn.DataPropertyName = "shomare_meli";
            this.shomaremeliDataGridViewTextBoxColumn.HeaderText = "shomare_meli";
            this.shomaremeliDataGridViewTextBoxColumn.Name = "shomaremeliDataGridViewTextBoxColumn";
            // 
            // sathedastrasiDataGridViewTextBoxColumn
            // 
            this.sathedastrasiDataGridViewTextBoxColumn.DataPropertyName = "sathe_dastrasi";
            this.sathedastrasiDataGridViewTextBoxColumn.HeaderText = "sathe_dastrasi";
            this.sathedastrasiDataGridViewTextBoxColumn.Name = "sathedastrasiDataGridViewTextBoxColumn";
            // 
            // frm_Manage_Voltages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Bardiya", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "frm_Manage_Voltages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Managment";
            this.Load += new System.EventHandler(this.frm_Manage_Voltages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barghDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserlevelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtFamily;
        private System.Windows.Forms.TextBox TxtShomareMeli;
        private System.Windows.Forms.TextBox TxtTavalod;
        private System.Windows.Forms.TextBox TxtMadrak;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbLevel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPassword;
        private barghDataSet barghDataSet;
        private System.Windows.Forms.BindingSource viewuserlevelBindingSource;
        private barghDataSetTableAdapters.View_user_levelTableAdapter view_user_levelTableAdapter;
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
    }
}