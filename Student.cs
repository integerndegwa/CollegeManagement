using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(textBox1.Text);
            string studentname = textBox2.Text;
            string email = textBox3.Text;
            string phone = textBox4.Text;

            string query = "INSERT INTO students (StudentID, StudentName, Email, Phone) VALUES (@StudentID, @StudentName, @Email, @Phone)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Inserted Successfully");
            StudentData();
        }
            private void StudentData() 
        {
            string query = "SELECT * FROM students";

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
            int studentid = int.Parse(textBox1.Text);
            string studentname = textBox2.Text;
            string email = textBox3.Text;
            string phone = textBox4.Text;

            string query = "UPDATE students SET StudentName=@StudentName, Email=@Email, Phone=@Phone WHERE StudentID=@StudentID";


            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated Successfully");
            StudentData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(textBox1.Text);


            string query = "DELETE FROM students WHERE StudentID=@StudentID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentid);
                   

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Deleted Successfully");
            StudentData();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            StudentData();
        }
    }
    }
