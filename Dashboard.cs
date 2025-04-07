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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display1();
            display2();
            display3();
        }

        private void display1()
        {
            string connectionString = "Server=127.0.0.1;Database=collegedb;Uid=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to count rows in the table
                    string query = "SELECT COUNT(*) FROM students";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the result
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        lblCount1.Text = "Total Students: " + count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void display2()
        {
            string connectionString = "Server=127.0.0.1;Database=collegedb;Uid=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to count rows in the table
                    string query = "SELECT COUNT(*) FROM courses";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the result
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        lblCount2.Text = "Total Courses: " + count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void display3()
        {
            string connectionString = "Server=127.0.0.1;Database=collegedb;Uid=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to count rows in the table
                    string query = "SELECT COUNT(*) FROM enrolls";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the result
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display the count in the label
                        lblCount3.Text = "Total Enrolls: " + count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
