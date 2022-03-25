namespace Library_Management
{
    partial class Lendbooks
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
            this.S = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnd1 = new System.Windows.Forms.Button();
            this.tb1stu = new System.Windows.Forms.TextBox();
            this.tb2bk = new System.Windows.Forms.TextBox();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.Calendariomonth = new System.Windows.Forms.MonthCalendar();
            this.calenderiodate = new System.Windows.Forms.DateTimePicker();
            this.txtrango = new System.Windows.Forms.TextBox();
            this.txtini = new System.Windows.Forms.TextBox();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btnhome = new System.Windows.Forms.Button();
            this.dgv6 = new System.Windows.Forms.DataGridView();
            this.dgv7 = new System.Windows.Forms.DataGridView();
            this.btnStd = new System.Windows.Forms.Button();
            this.btnbooks = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).BeginInit();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(0, 12);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(86, 18);
            this.S.TabIndex = 0;
            this.S.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "BookID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select End Date";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Black;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Cyan;
            this.btnsave.Location = new System.Drawing.Point(195, 628);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(134, 55);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnd1
            // 
            this.btnd1.BackColor = System.Drawing.Color.Aqua;
            this.btnd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd1.Location = new System.Drawing.Point(450, 344);
            this.btnd1.Name = "btnd1";
            this.btnd1.Size = new System.Drawing.Size(110, 55);
            this.btnd1.TabIndex = 5;
            this.btnd1.Text = "Calculate lend period";
            this.btnd1.UseVisualStyleBackColor = false;
            this.btnd1.Click += new System.EventHandler(this.btnd1_Click);
            // 
            // tb1stu
            // 
            this.tb1stu.Location = new System.Drawing.Point(144, 7);
            this.tb1stu.Name = "tb1stu";
            this.tb1stu.Size = new System.Drawing.Size(334, 22);
            this.tb1stu.TabIndex = 7;
            // 
            // tb2bk
            // 
            this.tb2bk.Location = new System.Drawing.Point(144, 53);
            this.tb2bk.Name = "tb2bk";
            this.tb2bk.Size = new System.Drawing.Size(334, 22);
            this.tb2bk.TabIndex = 8;
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(143, 31);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(334, 22);
            this.txtfech.TabIndex = 11;
            this.txtfech.TextChanged += new System.EventHandler(this.tbd1_TextChanged);
            // 
            // Calendariomonth
            // 
            this.Calendariomonth.Location = new System.Drawing.Point(144, 192);
            this.Calendariomonth.Name = "Calendariomonth";
            this.Calendariomonth.TabIndex = 13;
            this.Calendariomonth.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // calenderiodate
            // 
            this.calenderiodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calenderiodate.Location = new System.Drawing.Point(144, 123);
            this.calenderiodate.Name = "calenderiodate";
            this.calenderiodate.Size = new System.Drawing.Size(334, 22);
            this.calenderiodate.TabIndex = 15;
            // 
            // txtrango
            // 
            this.txtrango.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtrango.Location = new System.Drawing.Point(-28, 6);
            this.txtrango.Multiline = true;
            this.txtrango.Name = "txtrango";
            this.txtrango.Size = new System.Drawing.Size(1604, 10);
            this.txtrango.TabIndex = 16;
            // 
            // txtini
            // 
            this.txtini.Location = new System.Drawing.Point(143, 70);
            this.txtini.Multiline = true;
            this.txtini.Name = "txtini";
            this.txtini.Size = new System.Drawing.Size(334, 23);
            this.txtini.TabIndex = 17;
            this.txtini.TextChanged += new System.EventHandler(this.txtini_TextChanged);
            // 
            // txtfin
            // 
            this.txtfin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtfin.Location = new System.Drawing.Point(-28, 736);
            this.txtfin.Multiline = true;
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(1604, 10);
            this.txtfin.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "enddate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "startdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Start date";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Black;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Cyan;
            this.btnsearch.Location = new System.Drawing.Point(845, 282);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(131, 56);
            this.btnsearch.TabIndex = 23;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.calenderiodate);
            this.groupBox1.Controls.Add(this.Calendariomonth);
            this.groupBox1.Controls.Add(this.tb2bk);
            this.groupBox1.Controls.Add(this.tb1stu);
            this.groupBox1.Controls.Add(this.btnd1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Location = new System.Drawing.Point(20, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 417);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Details of lend period";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtini);
            this.groupBox2.Controls.Add(this.txtfech);
            this.groupBox2.Location = new System.Drawing.Point(20, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 117);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(627, 59);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowTemplate.Height = 24;
            this.dtgv1.Size = new System.Drawing.Size(913, 215);
            this.dtgv1.TabIndex = 27;
            this.dtgv1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv1_MouseDoubleClick);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Black;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Cyan;
            this.btnview.Location = new System.Drawing.Point(355, 629);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(126, 57);
            this.btnview.TabIndex = 28;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Cyan;
            this.btnupdate.Location = new System.Drawing.Point(1015, 282);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 57);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Black;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Cyan;
            this.btndelete.Location = new System.Drawing.Point(46, 628);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 58);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Clear";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1281, 762);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1125, 764);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btnhome
            // 
            this.Btnhome.BackColor = System.Drawing.Color.Black;
            this.Btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnhome.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btnhome.Location = new System.Drawing.Point(955, 764);
            this.Btnhome.Name = "Btnhome";
            this.Btnhome.Size = new System.Drawing.Size(155, 47);
            this.Btnhome.TabIndex = 32;
            this.Btnhome.Text = "Home";
            this.Btnhome.UseVisualStyleBackColor = false;
            this.Btnhome.Click += new System.EventHandler(this.Btnhome_Click);
            // 
            // dgv6
            // 
            this.dgv6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv6.Location = new System.Drawing.Point(627, 424);
            this.dgv6.Name = "dgv6";
            this.dgv6.RowTemplate.Height = 24;
            this.dgv6.Size = new System.Drawing.Size(436, 241);
            this.dgv6.TabIndex = 33;
            this.dgv6.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv6_CellDoubleClick);
            // 
            // dgv7
            // 
            this.dgv7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv7.Location = new System.Drawing.Point(1087, 424);
            this.dgv7.Name = "dgv7";
            this.dgv7.RowTemplate.Height = 24;
            this.dgv7.Size = new System.Drawing.Size(453, 241);
            this.dgv7.TabIndex = 34;
            this.dgv7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv7_MouseDoubleClick);
            // 
            // btnStd
            // 
            this.btnStd.BackColor = System.Drawing.Color.Cyan;
            this.btnStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStd.Location = new System.Drawing.Point(627, 687);
            this.btnStd.Name = "btnStd";
            this.btnStd.Size = new System.Drawing.Size(163, 38);
            this.btnStd.TabIndex = 35;
            this.btnStd.Text = "View Student";
            this.btnStd.UseVisualStyleBackColor = false;
            this.btnStd.Click += new System.EventHandler(this.btnStd_Click);
            // 
            // btnbooks
            // 
            this.btnbooks.BackColor = System.Drawing.Color.Aqua;
            this.btnbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooks.Location = new System.Drawing.Point(1087, 687);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(150, 38);
            this.btnbooks.TabIndex = 36;
            this.btnbooks.Text = "View Books";
            this.btnbooks.UseVisualStyleBackColor = false;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "This Displays Student Name and ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1083, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "This Displays Book Name and ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "This Displays Student ID,Book ID and Lend Details.";
            // 
            // Lendbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1578, 828);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.btnStd);
            this.Controls.Add(this.dgv7);
            this.Controls.Add(this.dgv6);
            this.Controls.Add(this.Btnhome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtfin);
            this.Controls.Add(this.txtrango);
            this.Controls.Add(this.btnsave);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Lendbooks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lendbooks";
            this.Load += new System.EventHandler(this.Lendbooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnd1;
        private System.Windows.Forms.TextBox tb1stu;
        private System.Windows.Forms.TextBox tb2bk;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.MonthCalendar Calendariomonth;
        private System.Windows.Forms.DateTimePicker calenderiodate;
        private System.Windows.Forms.TextBox txtrango;
        private System.Windows.Forms.TextBox txtini;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btnhome;
        private System.Windows.Forms.DataGridView dgv6;
        private System.Windows.Forms.DataGridView dgv7;
        private System.Windows.Forms.Button btnStd;
        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}