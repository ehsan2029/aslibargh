﻿namespace Barghkermanshah
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnedite = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.sathe_dastrasi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtfilter);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(321, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر اطلاعات";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "فیلتر";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(94, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "نام پست را وارد کنید";
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(22, 70);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(217, 23);
            this.txtfilter.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnedite);
            this.groupBox2.Controls.Add(this.TxtFamily);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnOk);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sathe_dastrasi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(347, 164);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnedite
            // 
            this.btnedite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnedite.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnedite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnedite.Location = new System.Drawing.Point(10, 109);
            this.btnedite.Name = "btnedite";
            this.btnedite.Size = new System.Drawing.Size(105, 39);
            this.btnedite.TabIndex = 35;
            this.btnedite.Text = "اعمال تغییرات";
            this.btnedite.UseVisualStyleBackColor = false;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(10, 62);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(105, 39);
            this.BtnOk.TabIndex = 30;
            this.BtnOk.Text = "ثبت";
            this.BtnOk.UseVisualStyleBackColor = false;
            // 
            // sathe_dastrasi
            // 
            this.sathe_dastrasi.AutoCompleteCustomSource.AddRange(new string[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.sathe_dastrasi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sathe_dastrasi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.sathe_dastrasi.BackColor = System.Drawing.SystemColors.Window;
            this.sathe_dastrasi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sathe_dastrasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sathe_dastrasi.FormattingEnabled = true;
            this.sathe_dastrasi.ItemHeight = 16;
            this.sathe_dastrasi.Items.AddRange(new object[] {
            "کرمانشاه"});
            this.sathe_dastrasi.Location = new System.Drawing.Point(158, 21);
            this.sathe_dastrasi.Margin = new System.Windows.Forms.Padding(2);
            this.sathe_dastrasi.Name = "sathe_dastrasi";
            this.sathe_dastrasi.Size = new System.Drawing.Size(108, 24);
            this.sathe_dastrasi.TabIndex = 29;
            this.sathe_dastrasi.Text = "کرمانشاه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(270, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "استان";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtFamily
            // 
            this.TxtFamily.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFamily.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtFamily.Location = new System.Drawing.Point(158, 60);
            this.TxtFamily.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.Size = new System.Drawing.Size(105, 23);
            this.TxtFamily.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(268, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام پست";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(81, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "سطح ولتاژ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "بازدیدکننده",
            "سرپرست",
            "ناظر",
            "ادمین"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Items.AddRange(new object[] {
            "63 KV",
            "132 KV",
            "230 KV",
            "400 KV"});
            this.comboBox1.Location = new System.Drawing.Point(10, 21);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(67, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "63 KV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del,
            this.edite});
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 242);
            this.dataGridView1.TabIndex = 17;
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
            // frm_Manage_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Manage_Post";
            this.Text = "مدیریت پست ها";
            this.Load += new System.EventHandler(this.frm_Manage_Post_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnedite;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.ComboBox sathe_dastrasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.DataGridViewButtonColumn edite;
    }
}