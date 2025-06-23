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
		public partial class search_Returned : Form
			{
				public search_Returned()
					{
						InitializeComponent();
					}

				private void search_Returned_Load(object sender, EventArgs e)
					{

			}

		//private void button2_Click(object sender, EventArgs e)
		//	{
		//		this.Close();
		//		new StartForm().Show();
		//	}

		private void button3_Click(object sender, EventArgs e)
				{
					OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\Students.accdb");
					DataTable dt = new DataTable();
					OleDbDataAdapter OdbA = new OleDbDataAdapter("SELECT top 10 * from students ORDER BY date_Returned DESC", OdbConn);
					OdbA.Fill(dt);
					dataGridView2.DataSource = dt;
				}

				private void button4_Click(object sender, EventArgs e)
					{
						Application.Exit();
					}

				private void textBox3_TextChanged(object sender, EventArgs e)
					{
						try
							{
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\Students.accdb");
								DataTable dt = new DataTable();
								OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from students WHERE Student_Name LIKE '%" + textBox3.Text.ToString() + "%'", OdbConn);
								OdbA.Fill(dt);
								dataGridView2.DataSource = dt;
							}
						catch (Exception c)
							{
								throw (c);
								
							}
								Console.WriteLine("Exception caught!");
					}
	
				private void textBox1_TextChanged(object sender, EventArgs e)
						{
							try
								{
									OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\Students.accdb");
									DataTable dt = new DataTable();
									OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from students WHERE Student_ID LIKE '%" + textBox1.Text.ToString() + "%'", OdbConn);
									OdbA.Fill(dt);
									dataGridView2.DataSource = dt;
								}
							catch (Exception c)
								{
									throw (c);
								
								}
									Console.WriteLine("Exception caught!");
						}

				private void button5_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\Students.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from students", OdbConn);
						OdbA.Fill(dt);
						dataGridView2.DataSource = dt;
					}

		//				private void button6_Click(object sender, EventArgs e)
		//					{
		//						this.Close();
		//						new StartForm().Show();
		//					}

				private void button8_Click(object sender, EventArgs e)
					{
						// Calling DataGridView Printing
						PrintDGV.Print_DataGridView(dataGridView2);
					}

				private void button6_Click_1(object sender, EventArgs e)
					{
						this.Close();
						new StartForm().Show();
					}

				private void pictureBox1_Click(object sender, EventArgs e)
					{
						this.Hide();
						new SplashScreen().Show();
					}

        private void label2_Click(object sender, EventArgs e)
			{
			}

        private void pictureBox1_Click_1(object sender, EventArgs e)
			{
			}

        private void button5_Click_1(object sender, EventArgs e)
			{
			}

        private void pictureBox3_Click(object sender, EventArgs e)
			{
			}

        private void button1_Click(object sender, EventArgs e)
        {
			pictureBox3.ImageLocation = "C:\\Search\\Pics\\" + textBox1.Text.ToString()  + ".jpg";
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					dataGridView2.CurrentRow.Selected = true;
					textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells["Student_ID"].FormattedValue.ToString();
					//textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();

			}
			
			//pictureBox1.ImageLocation = "C:\\Users\\gbertollini\\Desktop\\CSharpImage\\Pics\\" + "Select * from Table1 WHERE StudentID LIKE '%" + textBox1.Text.ToString() + "%'" + ".jpg";
			//pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
	}


