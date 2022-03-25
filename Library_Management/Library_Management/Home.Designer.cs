namespace Library_Management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddbooks = new System.Windows.Forms.Button();
            this.btnlendbooks = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(142, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library System";
            // 
            // btnaddbooks
            // 
            this.btnaddbooks.BackColor = System.Drawing.Color.Yellow;
            this.btnaddbooks.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbooks.Location = new System.Drawing.Point(363, 363);
            this.btnaddbooks.Name = "btnaddbooks";
            this.btnaddbooks.Size = new System.Drawing.Size(380, 65);
            this.btnaddbooks.TabIndex = 1;
            this.btnaddbooks.Text = "Addbooks";
            this.btnaddbooks.UseVisualStyleBackColor = false;
            this.btnaddbooks.Click += new System.EventHandler(this.btnaddbooks_Click);
            // 
            // btnlendbooks
            // 
            this.btnlendbooks.BackColor = System.Drawing.Color.Yellow;
            this.btnlendbooks.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlendbooks.Location = new System.Drawing.Point(363, 607);
            this.btnlendbooks.Name = "btnlendbooks";
            this.btnlendbooks.Size = new System.Drawing.Size(380, 51);
            this.btnlendbooks.TabIndex = 2;
            this.btnlendbooks.Text = "Lendbooks";
            this.btnlendbooks.UseVisualStyleBackColor = false;
            this.btnlendbooks.Click += new System.EventHandler(this.btnlendbooks_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(363, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "Addstudents";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Cyan;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(975, 639);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(155, 50);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 701);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnlendbooks);
            this.Controls.Add(this.btnaddbooks);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddbooks;
        private System.Windows.Forms.Button btnlendbooks;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnexit;
    }
}