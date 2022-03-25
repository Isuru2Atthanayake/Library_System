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
    public partial class Lendbooks : Form
    {
        public Lendbooks()
        {
            InitializeComponent();
        }
        //---------------------data source is here------------------------------
        SqlDataReader dr;
        SqlCommand com = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Library_Management\\Library_Management\\Librarydb.mdf;Integrated Security=True;Connect Timeout=30");
        //---------------------data source is here------------------------------
        private void btnd1_Click(object sender, EventArgs e)
        {

            txtfech.Text = calenderiodate.Text;

            //  txtrango.Text = Calendariomonth.SelectionRange.ToString();
            txtini.Text = Calendariomonth.SelectionStart.ToString();
            // txtfin.Text = Calendariomonth.SelectionRange.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        private void tbd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            con.Open();
            string sql = "insert into Lend(studentid,bookid,startdate,enddate) values('" + tb1stu.Text + "','" + tb2bk.Text + "','" + txtfech.Text + "','" + txtini.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void Lendbooks_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           /* com.CommandText = "SELECT * FROM Lend WHERE studentid = ('" + tb1stu + "')";
            com.Connection = con;
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read()) ;
            tb1stu.Text = (dr["studentid"].ToString());
            tb2bk.Text = (dr["bookid"].ToString());
           // txtfech.Text = (dr["startdate"].ToString());
          //  txtini.Text = (dr["enddate"].ToString());


            MessageBox.Show("fg","Information", MessageBoxButtons.OK);
         */   {
                con.Close();

            }


        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Lend";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dtgv1.DataSource = a;
            con.Close();



        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            con.Open();

            string sql = "UPDATE Lend SET studentid=" + tb1stu.Text + ", bookid=" + tb2bk.Text + ", startdate=" + txtfech.Text + ", enddate=" + txtini.Text + " WHERE studentid= " + tb1stu.Text;
            SqlCommand com = new SqlCommand(sql, con);
            //  SqlDataAdapter s = new SqlDataAdapter(query,con);

            //  s.SelectCommand.BeginExecuteNonQuery();
            // msc.Connection = con;
            // msc.ExecuteNonQuery( );

       //------------------------------------------------------
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("sucess");

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        //------------------------------------------------------ 





            con.Close();
                MessageBox.Show("Updated sucessfully");
         }
             
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb1stu.Text = dtgv1.SelectedRows[0].Cells[0].Value.ToString();
            tb2bk.Text = dtgv1.SelectedRows[0].Cells[1].Value.ToString();
            txtfech.Text = dtgv1.SelectedRows[0].Cells[2].Value.ToString();
            txtini.Text = dtgv1.SelectedRows[0].Cells[3].Value.ToString();
         }

        private void txtini_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addstudent mn = new Addstudent();
            mn.Show();
            this.Hide();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            com.CommandText = "Delete FROM Lend WHERE studentid =('" + tb1stu + "')";
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("completed");
            tb1stu.Text = "";
            tb2bk.Text = "";
            txtfech.Text = "";
            txtini.Text = "";
            con.Close();
        }

        private void Btnhome_Click(object sender, EventArgs e)
        {
           Home mn = new Home();
            mn.Show();
            this.Hide();


        }

        private void btnStd_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select StudentID,Name from Addstudent";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv6.DataSource = a;
            con.Close();


        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select Bookname,BookID from Addbooks";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv7.DataSource = a;
            con.Close();
        }

        private void dgv6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb1stu.Text = dgv6.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dgv7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb2bk.Text = dgv7.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            string query = "Delete from Lend where studentid ='" + tb1stu.Text+ "'";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("completed");
            */
        }
    }
}
