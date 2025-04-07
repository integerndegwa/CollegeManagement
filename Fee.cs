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
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int fid = int.Parse(textBox1.Text);
            string studentname = textBox2.Text;
            int amount = int.Parse(textBox3.Text);


            string query = "INSERT INTO fees (FID, StudentName, Amount) VALUES (@FID, @StudentName, @Amount)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FID", fid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@Amount", amount);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Inserted Successfully");
            FeeData();
        }

        private void FeeData()
        {
            string query = "SELECT * FROM fees";

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
            int fid = int.Parse(textBox1.Text);
            string studentname = textBox2.Text;
            int amount = int.Parse(textBox3.Text);


            string query = "UPDATE fees SET StudentName=@StudentName, Amount=@Amount WHERE FID=@FID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FID", fid);
                    cmd.Parameters.AddWithValue("@StudentName", studentname);
                    cmd.Parameters.AddWithValue("@Amount", amount);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated Successfully");
            FeeData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int fid = int.Parse(textBox1.Text);
           


            string query = "DELETE FROM fees WHERE FID=@FID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FID", fid);
                   

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Deleted Successfully");
            FeeData();
        }

        private void Fee_Load(object sender, EventArgs e)
        {
            FeeData();
        }
    }
}
