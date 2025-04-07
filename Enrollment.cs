using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(textBox1.Text);
            string studentname = textBox2.Text;
            string course = textBox3.Text;
            string enrolldate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = "INSERT INTO enrolls (EID, StudentName, Course, EnrollDate) VALUES (@EID, @StudentName, @Course, @EnrollDate)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EID", eid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@enrolldate", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Inserted Successfully");
            EnrollData();
        }

        private void EnrollData()
        {
            string query = "SELECT * FROM enrolls";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(textBox1.Text);
            string studentname = textBox2.Text;
            string course = textBox3.Text;
            string enrolldate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string query = "UPDATE enrolls SET StudentName=@StudentName, Course=@Course, EnrollDate=@EnrollDate WHERE EID=@EID)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EID", eid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@enrolldate", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated Successfully");
            EnrollData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int eid = int.Parse(textBox1.Text);
            

            string query = "DELETE FROM enrolls WHERE EID=@EID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EID", eid);
                   

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Deleted Successfully");
            EnrollData();
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            EnrollData();
        }
    }
}
