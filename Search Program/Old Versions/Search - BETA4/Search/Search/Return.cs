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
		public partial class Return : Form
			{
				OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Search\KinneyDatabase.accdb");
			
				public Return()
					{
						InitializeComponent();
					}

				private void button6_Click(object sender, EventArgs e)
					{
						Application.Exit();
					}

				private void Form3_Load(object sender, EventArgs e)
					{
						vcon.Open();
					}

				private void button2_Click(object sender, EventArgs e)
					{
						this.Close();
						new Receive().Show();
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
								OleDbCommand dbCommand;
								OleDbDataReader dbReader;
								new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Search\KinneyDatabase.accdb");
								dbCommand = new OleDbCommand("select count(*) as Record_Count from script_returned", vcon);

								dbReader = dbCommand.ExecuteReader();

								if (dbReader.Read() == true)
									rowCount = dbReader["Record_Count"].ToString();
								else
									return;

								var date = DateTime.Now.ToString("MM/dd/yyyy");


								//string sql = string.Format("INSERT INTO script_received values " +
								//    "('{0}','{1}',{2},{3},#{4}#,)",
								//    rowCount,
								//    textBox1.Text,
								//    textBox2.Text,
								//    date,
								//    textBox2.Text
								//    );

								//using(OleDbConnection conn = OpenDbConnection())
							{
								using (OleDbCommand command = new OleDbCommand("INSERT INTO script_returned (script, qty, emp_id, returned_Date) VALUES (@script,@qty,@emp_Id,@ret_date)"))
									{
										command.CommandType = CommandType.Text;
										command.Parameters.Add("@script", OleDbType.Integer).Value = textBox1.Text;
										command.Parameters.Add("@qty", OleDbType.VarChar).Value = textBox2.Text;
										command.Parameters.Add("@emp_id", OleDbType.VarChar).Value = textBox3.Text;
										command.Parameters.Add("@ret_date", OleDbType.Date).Value = date;
										command.Connection = vcon;

										//vcon.Open();

										command.ExecuteNonQuery();
									}
										//OleDbCommand command = new OleDbCommand(sql, vcon);
										//command.ExecuteNonQuery();
										//command.Dispose();
										this.textBox1.Clear();
										this.textBox2.Clear();
										this.textBox1.Focus();
							}
					}
		}

		public string rowCount { get; set; }

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
			new Receive().Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
			new search_Returned().Show();
		}

	}
}
