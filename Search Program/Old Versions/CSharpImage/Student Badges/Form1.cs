using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.OleDb;
using System.Drawing.Printing;
//using PrintDataGrid;

namespace Student_Badges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\gbertollini\\Desktop\\CSharpImage\\Pics\\1.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gbertollini\Desktop\CSharpImage\Student Badges\Database1.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from Table1Q", OdbConn);
            //OdbA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
