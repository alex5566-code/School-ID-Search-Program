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
		public partial class Unordered : Form
			{
				OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Search\KinneyDatabase.accdb");

				public Unordered()
					{
						InitializeComponent();
					}
				
				private void Unordered_Load(object sender, EventArgs e)
					{
						vcon.Open();
					}
				
				private void button2_Click(object sender, EventArgs e)
					{
						this.Close();
						new StartForm().Show();
					}
			
				public object rowCount { get; set; }
				
				private void button3_Click(object sender, EventArgs e)
					{
						Application.Exit();
					}
				
				private void button1_Click(object sender, EventArgs e)
					{
						if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "")
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
						
								new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Search\KinneyDatabase.accdb");
								var date = DateTime.Now.ToString("MM/dd/yyyy");
												
								using (OleDbCommand command = new OleDbCommand("INSERT INTO script_Received (script, qty, emp_id, received_Date) VALUES (@script,@qty,@emp_Id,@rec_date)"))
									{
										command.CommandType = CommandType.Text;
										command.Parameters.Add("@script", OleDbType.Integer).Value = textBox1.Text;
										command.Parameters.Add("@qty", OleDbType.VarChar).Value = textBox2.Text;
										command.Parameters.Add("@emp_Id", OleDbType.VarChar).Value = textBox3.Text;
										command.Parameters.Add("@rec_date", OleDbType.Date).Value = date;
										command.Connection = vcon;
										command.ExecuteNonQuery();
									}
								using (OleDbCommand command = new OleDbCommand("INSERT INTO script_Unordered (script, cust_Name, drug, fill_Date) VALUES (@script,@cust,@drug,@fil_date)"))
									{
										command.CommandType = CommandType.Text;
										command.Parameters.Add("@script", OleDbType.Integer).Value = textBox1.Text;
										command.Parameters.Add("@cust", OleDbType.VarChar).Value = textBox4.Text;
										command.Parameters.Add("@drug", OleDbType.VarChar).Value = textBox6.Text;
										command.Parameters.Add("@fil_date", OleDbType.Date).Value = "#" + dateTimePicker1.Text + "#";
										command.Connection = vcon;
										command.ExecuteNonQuery();
									}
								this.textBox1.Clear();
								this.textBox2.Clear();
								this.textBox1.Focus();
							}						
					}
			}
	}

