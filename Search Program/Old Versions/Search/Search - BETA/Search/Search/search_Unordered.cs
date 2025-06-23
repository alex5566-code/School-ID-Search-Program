using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using PrintDataGrid;

namespace csvToGrid
	{
		public partial class search_Unordered : Form
			{
				public search_Unordered()
					{
						InitializeComponent();
					}
		
				private void button9_Click(object sender, EventArgs e)
				{
					this.Close();
					new search_Received().Show();
				}

				private void search_Unordered_Load(object sender, EventArgs e)
					{

					}

				private void button1_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from query_All_Unordered WHERE Fill_Date = " + "#" + dateTimePicker1.Text + "#", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

				private void textBox1_TextChanged(object sender, EventArgs e)
					{
						try
							{
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
								DataTable dt = new DataTable();
								OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from query_All_Unordered WHERE Prescription_ID LIKE '%" + textBox1.Text.ToString() + "%'", OdbConn);
								OdbA.Fill(dt);
								dataGridView1.DataSource = dt;
							}
						catch (Exception c)
							{
								throw (c);
							}
								Console.WriteLine("Exception caught!");
					}

				private void textBox3_TextChanged(object sender, EventArgs e)
					{
						try
							{
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
								DataTable dt = new DataTable();
								OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from query_All_Unordered WHERE Customer_Name LIKE '%" + textBox3.Text.ToString() + "%'", OdbConn);
								//= " + textBox2.Text.ToString, OdbConn);

								OdbA.Fill(dt);
								dataGridView1.DataSource = dt;
							}
						catch (Exception c)
							{
								throw (c);
								
							}
								Console.WriteLine("Exception caught!");
					}

				private void button2_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from query_All_Unordered", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

				private void button3_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("SELECT top 10 * from query_All_Unordered ORDER BY Date_Received DESC", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

				private void button7_Click(object sender, EventArgs e)
				{
					this.Close();
					new Receive().Show();
				}

				private void button6_Click(object sender, EventArgs e)
				{
					this.Close();
					new Return().Show();
				}

				private void button5_Click(object sender, EventArgs e)
				{
					this.Hide();
					new search_Returned().Show();
				}

				private void button8_Click(object sender, EventArgs e)
				{
					// Calling DataGridView Printing
					PrintDGV.Print_DataGridView(dataGridView1);
				}

				private void button4_Click(object sender, EventArgs e)
				{
					Application.Exit();
				}

	}
}
