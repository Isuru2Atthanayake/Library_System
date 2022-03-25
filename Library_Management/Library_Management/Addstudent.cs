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
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Library_Management\\Library_Management\\Librarydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Addstudent(StudentID,Name,Phone,Email) values('" + tbid.Text + "','" + tbname.Text + "','" + tphone.Text + "','" + tbemai.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void Addstudent_Load(object sender, EventArgs e)
        {

        }

       private void btnbrows_Click(object sender, EventArgs e)
        {
          /*  try
            { using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "jpeg|*png", ValidateNames = true, Multiselect = false })
                { if (ofd.ShowDialog() == DialogResult.OK)
                        PictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Addbooks mn = new Addbooks();
            mn.Show();
            this.Hide();
        }

        private void btnnext1_Click(object sender, EventArgs e)
        {
            Lendbooks mn = new Lendbooks();
            mn.Show();
            this.Hide();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Addstudent";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv4.DataSource = a;
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbid.Text = "";
            tbname.Text = "";
            tphone.Text = "";
            tbemai.Text = "";
        }
    }
        
}

