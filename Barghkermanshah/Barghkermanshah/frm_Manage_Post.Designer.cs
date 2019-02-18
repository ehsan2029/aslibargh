namespace Barghkermanshah
{
    partial class frm_Manage_Post
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
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSearchPostName = new System.Windows.Forms.TextBox();
            this.GbInf = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TxtPostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.CmbVoltage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbOstan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barghDataSetnamepost = new Barghkermanshah.barghDataSetnamepost();
            this.tblnamepostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_name_postTableAdapter = new Barghkermanshah.barghDataSetnamepostTableAdapters.tbl_name_postTableAdapter();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idnamepostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.GbSearch.SuspendLayout();
            this.GbInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barghDataSetnamepost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnamepostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GbSearch
            // 
            this.GbSearch.BackColor = System.Drawing.Color.Transparent;
            this.GbSearch.Controls.Add(this.label13);
            this.GbSearch.Controls.Add(this.label11);
            this.GbSearch.Controls.Add(this.TxtSearchPostName);
            this.GbSearch.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GbSearch.ForeColor = System.Drawing.Color.Black;
            this.GbSearch.Location = new System.Drawing.Point(12, 12);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GbSearch.Size = new System.Drawing.Size(240, 122);
            this.GbSearch.TabIndex = 15;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "فیلتر اطلاعات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(117, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "بر اساس نام پست:";
            // 
            // TxtSearchPostName
            // 
            this.TxtSearchPostName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSearchPostName.Location = new System.Drawing.Point(8, 71);
            this.TxtSearchPostName.Name = "TxtSearchPostName";
            this.TxtSearchPostName.Size = new System.Drawing.Size(226, 36);
            this.TxtSearchPostName.TabIndex = 0;
            this.TxtSearchPostName.TextChanged += new System.EventHandler(this.TxtSearchPostName_TextChanged);
            // 
            // GbInf
            // 
            this.GbInf.Controls.Add(this.BtnEdit);
            this.GbInf.Controls.Add(this.TxtPostName);
            this.GbInf.Controls.Add(this.label1);
            this.GbInf.Controls.Add(this.BtnOk);
            this.GbInf.Controls.Add(this.CmbVoltage);
            this.GbInf.Controls.Add(this.label2);
            this.GbInf.Controls.Add(this.CmbOstan);
            this.GbInf.Controls.Add(this.label4);
            this.GbInf.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GbInf.Location = new System.Drawing.Point(258, 12);
            this.GbInf.Name = "GbInf";
            this.GbInf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GbInf.Size = new System.Drawing.Size(410, 122);
            this.GbInf.TabIndex = 16;
            this.GbInf.TabStop = false;
            this.GbInf.Text = "اطلاعات";
            this.GbInf.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEdit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Location = new System.Drawing.Point(77, 71);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(110, 39);
            this.BtnEdit.TabIndex = 35;
            this.BtnEdit.Text = "اعمال تغییرات";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TxtPostName
            // 
            this.TxtPostName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPostName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPostName.Location = new System.Drawing.Point(215, 72);
            this.TxtPostName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtPostName.Name = "TxtPostName";
            this.TxtPostName.Size = new System.Drawing.Size(108, 36);
            this.TxtPostName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(327, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام پست:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(5, 71);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(67, 39);
            this.BtnOk.TabIndex = 30;
            this.BtnOk.Text = "ثبت";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CmbVoltage
            // 
            this.CmbVoltage.AutoCompleteCustomSource.AddRange(new string[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.CmbVoltage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbVoltage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.CmbVoltage.BackColor = System.Drawing.SystemColors.Window;
            this.CmbVoltage.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CmbVoltage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CmbVoltage.FormattingEnabled = true;
            this.CmbVoltage.ItemHeight = 28;
            this.CmbVoltage.Items.AddRange(new object[] {
            "63",
            "132",
            "230",
            "400"});
            this.CmbVoltage.Location = new System.Drawing.Point(5, 24);
            this.CmbVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.CmbVoltage.Name = "CmbVoltage";
            this.CmbVoltage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbVoltage.Size = new System.Drawing.Size(67, 36);
            this.CmbVoltage.TabIndex = 29;
            this.CmbVoltage.Text = "63";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(76, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "سطح ولتاژ (کیلوولت)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbOstan
            // 
            this.CmbOstan.AutoCompleteCustomSource.AddRange(new string[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.CmbOstan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbOstan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.CmbOstan.BackColor = System.Drawing.SystemColors.Window;
            this.CmbOstan.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CmbOstan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CmbOstan.FormattingEnabled = true;
            this.CmbOstan.ItemHeight = 28;
            this.CmbOstan.Items.AddRange(new object[] {
            "کرمانشاه"});
            this.CmbOstan.Location = new System.Drawing.Point(215, 27);
            this.CmbOstan.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOstan.Name = "CmbOstan";
            this.CmbOstan.Size = new System.Drawing.Size(108, 36);
            this.CmbOstan.TabIndex = 29;
            this.CmbOstan.Text = "کرمانشاه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(327, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "نام استان:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del,
            this.edite,
            this.idnamepostDataGridViewTextBoxColumn,
            this.ostanDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn,
            this.namepostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblnamepostBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(545, 215);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barghDataSetnamepost
            // 
            this.barghDataSetnamepost.DataSetName = "barghDataSetnamepost";
            this.barghDataSetnamepost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblnamepostBindingSource
            // 
            this.tblnamepostBindingSource.DataMember = "tbl_name_post";
            this.tblnamepostBindingSource.DataSource = this.barghDataSetnamepost;
            // 
            // tbl_name_postTableAdapter
            // 
            this.tbl_name_postTableAdapter.ClearBeforeFill = true;
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
            // idnamepostDataGridViewTextBoxColumn
            // 
            this.idnamepostDataGridViewTextBoxColumn.DataPropertyName = "id_name_post";
            this.idnamepostDataGridViewTextBoxColumn.HeaderText = "id_name_post";
            this.idnamepostDataGridViewTextBoxColumn.Name = "idnamepostDataGridViewTextBoxColumn";
            this.idnamepostDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnamepostDataGridViewTextBoxColumn.Visible = false;
            // 
            // ostanDataGridViewTextBoxColumn
            // 
            this.ostanDataGridViewTextBoxColumn.DataPropertyName = "ostan";
            this.ostanDataGridViewTextBoxColumn.HeaderText = "استان";
            this.ostanDataGridViewTextBoxColumn.Name = "ostanDataGridViewTextBoxColumn";
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "voltage";
            this.voltageDataGridViewTextBoxColumn.HeaderText = "ولتاژ";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            // 
            // namepostDataGridViewTextBoxColumn
            // 
            this.namepostDataGridViewTextBoxColumn.DataPropertyName = "name_post";
            this.namepostDataGridViewTextBoxColumn.HeaderText = "نام پست";
            this.namepostDataGridViewTextBoxColumn.Name = "namepostDataGridViewTextBoxColumn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 28);
            this.label13.TabIndex = 36;
            this.label13.Text = "label3";
            this.label13.Visible = false;
            // 
            // frm_Manage_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbInf);
            this.Controls.Add(this.GbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Manage_Post";
            this.Text = "مدیریت پست ها";
            this.Load += new System.EventHandler(this.frm_Manage_Post_Load);
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            this.GbInf.ResumeLayout(false);
            this.GbInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barghDataSetnamepost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblnamepostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSearchPostName;
        private System.Windows.Forms.GroupBox GbInf;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.ComboBox CmbOstan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbVoltage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private barghDataSetnamepost barghDataSetnamepost;
        private System.Windows.Forms.BindingSource tblnamepostBindingSource;
        private barghDataSetnamepostTableAdapters.tbl_name_postTableAdapter tbl_name_postTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn edite;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnamepostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
    }
}