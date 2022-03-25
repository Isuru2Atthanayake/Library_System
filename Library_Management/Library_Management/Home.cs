using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addstudent mn = new Addstudent();
            mn.Show();
            this.Hide();

        }

        private void btnaddbooks_Click(object sender, EventArgs e)
        {
            Addbooks mn = new Addbooks();
            mn.Show();
            this.Hide();

        }

        private void btnlendbooks_Click(object sender, EventArgs e)
        {
            Lendbooks mn = new Lendbooks();
            mn.Show();
            this.Hide();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
