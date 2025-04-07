using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hardcoded credentials
            string correctUsername = "admin";
            string correctPassword = "password123"; // Use a secure password in a real application

            // Check credentials
            if (textBox1.Text == correctUsername && textBox2.Text == correctPassword)
            {
                Main mn = new Main();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
