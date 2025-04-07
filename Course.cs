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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeManagement
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int courseid = int.Parse(textBox1.Text);
            string course = textBox2.Text;
            string duration = textBox3.Text;


            string query = "INSERT INTO courses (CourseID, Course, Duration) VALUES (@CourseID, @Course, @Duration)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseid);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@Duration", duration);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Inserted Successfully");
            CourseData();
        }

        private void CourseData()
        {
            string query = "SELECT * FROM courses";

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
            int courseid = int.Parse(textBox1.Text);
            string course = textBox2.Text;
            string duration = textBox3.Text;


            string query = "UPDATE courses SET Course=@Course, Duration=@Duration WHERE CourseID=@CourseID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseid);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@Duration", duration);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated Successfully");
            CourseData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int courseid = int.Parse(textBox1.Text);
            


            string query = "DELETE FROM courses WHERE CourseID=@CourseID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseid);
                   


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Deleted Successfully");
            CourseData();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            CourseData();
        }
    }
}