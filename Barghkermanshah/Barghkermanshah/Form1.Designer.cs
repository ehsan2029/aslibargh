namespace Barghkermanshah
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مدیریتکااربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتپستToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتشناسنامهپستToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکااربرانToolStripMenuItem,
            this.ثبتپستToolStripMenuItem,
            this.مدیریتشناسنامهپستToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتکااربرانToolStripMenuItem
            // 
            this.مدیریتکااربرانToolStripMenuItem.Name = "مدیریتکااربرانToolStripMenuItem";
            this.مدیریتکااربرانToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.مدیریتکااربرانToolStripMenuItem.Text = "مدیریت کاربران";
            this.مدیریتکااربرانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکااربرانToolStripMenuItem_Click);
            // 
            // ثبتپستToolStripMenuItem
            // 
            this.ثبتپستToolStripMenuItem.Name = "ثبتپستToolStripMenuItem";
            this.ثبتپستToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ثبتپستToolStripMenuItem.Text = "ثبت پست";
            this.ثبتپستToolStripMenuItem.Click += new System.EventHandler(this.ثبتپستToolStripMenuItem_Click);
            // 
            // مدیریتشناسنامهپستToolStripMenuItem
            // 
            this.مدیریتشناسنامهپستToolStripMenuItem.Name = "مدیریتشناسنامهپستToolStripMenuItem";
            this.مدیریتشناسنامهپستToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.مدیریتشناسنامهپستToolStripMenuItem.Text = "مدیریت شناسنامه پست";
            this.مدیریتشناسنامهپستToolStripMenuItem.Click += new System.EventHandler(this.مدیریتشناسنامهپستToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 321);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "تست";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکااربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتپستToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتشناسنامهپستToolStripMenuItem;
    }
}

