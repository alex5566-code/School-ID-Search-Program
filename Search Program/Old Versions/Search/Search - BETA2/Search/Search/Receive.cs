using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Collections;
using System.Data.OleDb;


namespace csvToGrid
	{
		public partial class Receive : Form
		{
			OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Search\KinneyDatabase.accdb");
			
			public Receive()
			{
				InitializeComponent();
			}

		
			private void label1_Click(object sender, EventArgs e)
			{

			}

			private void Form1_Load(object sender, EventArgs e)
				{
					vcon.Open();
				}
		
			private void button2_Click(object sender, EventArgs e)
			{
				this.Close();
				new search_Received().Show();
			}

			private void button4_Click(object sender, EventArgs e)
			{
				this.Close();
				new search_Returned().Show();
			}
			public object rowCount { get; set; }

			private void button2_Click_1(object sender, EventArgs e)
			{
				this.Close();
				new search_Received().Show();
			}

			private void button6_Click(object sender, EventArgs e)
			{
				Application.Exit();
			}

			private void button1_Click(object sender, EventArgs e)
			{
				if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
				{
					MessageBox.Show("You must fill in all fields.");
					return;
				}
				else
				{
					try
					{
						Int32.Parse(textBox1.Text);
						Int32.Parse(textBox2.Text);
						//If it reaches this line then it must be an int because an exception has not been thrown
					}
					catch
					{
						MessageBox.Show("The ''Scan Script'' and ''Quantity'' fields must be numeric values ");
						return;
					}
					{
						OleDbCommand dbCommand;
						OleDbDataReader dbReader;
						new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Search\KinneyDatabase.accdb");
						dbCommand = new OleDbCommand("select count(*) as Record_Count from script_received", vcon);

						dbReader = dbCommand.ExecuteReader();

						if (dbReader.Read() == true)
							rowCount = dbReader["Record_Count"].ToString();
						else
							return;

						var date = DateTime.Now.ToString("MM/dd/yyyy");
							//get the existence of the record as count
						string cmdStr = ("Select count(*) from script_Orders where script = " + textBox1.Text);
						OleDbCommand cmd = new OleDbCommand(cmdStr, vcon);
						int count = (int)cmd.ExecuteScalar();

						if (count > 0)

							//record already exist 
							{
								using (OleDbCommand command = new OleDbCommand("INSERT INTO script_Received (script, qty, emp_id, received_Date) VALUES (@script,@qty,@emp_Id,@rec_date)"))
								{
									command.CommandType = CommandType.Text;
									command.Parameters.Add("@script", OleDbType.Integer).Value = textBox1.Text;
									command.Parameters.Add("@qty", OleDbType.VarChar).Value = textBox2.Text;
									command.Parameters.Add("@emp_id", OleDbType.VarChar).Value = textBox3.Text;
									command.Parameters.Add("@rec_date", OleDbType.Date).Value = date;
									command.Connection = vcon;
									command.ExecuteNonQuery();
								}

								this.textBox1.Clear();
								this.textBox2.Clear();
								this.textBox1.Focus();
							}
						else
						{
							this.Close();
							new Unordered().Show();
						}
					}
				}
			}

			private void button3_Click(object sender, EventArgs e)
			{
				this.Close();
				new Return().Show();
			}

			private void button5_Click(object sender, EventArgs e)
			{
				this.Close();
				new search_Unordered().Show();
			}


			}

		
		}

