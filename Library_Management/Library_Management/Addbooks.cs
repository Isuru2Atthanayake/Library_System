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

namespace Library_Management
{
    public partial class Addbooks : Form
    {
        public Addbooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Library_Management\\Library_Management\\Librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnsave_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string sql = "insert into Addbooks(Bookname,BookID,Author) values('" + tbbname.Text + "','" + tbbid.Text + "','" + tbauthor.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void Addbooks_Load(object sender, EventArgs e)
        {

        }

        private void tbbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbauthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Addstudent mn = new Addstudent();
            mn.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

        private void Btnlend_Click(object sender, EventArgs e)
        {
            Lendbooks mn = new Lendbooks();
            mn.Show();
            this.Hide();

        }

        private void Btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Addbooks";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv3.DataSource = a;
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbbname.Text = "";
            tbbid.Text = "";
            tbauthor.Text = "";
            
        }
    }
}
