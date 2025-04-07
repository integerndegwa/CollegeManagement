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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course ce = new Course();
            ce.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enrollment et = new Enrollment();
            et.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fee fe = new Fee();
            fe.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard();
            dd.Show();
        }
    }
}
