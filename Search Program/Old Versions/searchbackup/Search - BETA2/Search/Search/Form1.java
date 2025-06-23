package search;

// ********* THIS FILE IS AUTO PORTED FORM C# USING CODEPORTING.COM *********

import com.codeporting.csharp2java.System.EventArgs;
import com.codeporting.csharp2java.System.DateTime;


	
	public partial class Form1 extends Form
	{
		private OleDbConnection vcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Search\\KinneyDatabase.accdb");

		public Form1()
		{
			InitializeComponent();
		}

	
		private void label1_Click(Object sender, EventArgs e)
		{

		}

		private void form1_Load(Object sender, EventArgs e)
			{
				vcon.Open();
			}
	
		private void button2_Click(Object sender, EventArgs e)
		{
			new Form2().Show();
		}

		private void button4_Click(Object sender, EventArgs e)
		{
			Application.Exit();
		}
		 Object _rowCount;public Object getrowCount(){ return _rowCount; }; public void setrowCount(Object value){_rowCount = value; };

		private void button2_Click_1(Object sender, EventArgs e)
		{
			this.Close();
			new Form2().Show();
		}

		private void button6_Click(Object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(Object sender, EventArgs e)
		{
			if ("".equals(textBox1.Text) || "".equals(textBox2.Text) || "".equals(textBox3.Text))
			{
				MessageBox.Show("You must fill in all fields.");
				return;
			}
			else
			{
				OleDbCommand dbCommand;
				OleDbDataReader dbReader;
				new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Search\\KinneyDatabase.accdb");
				dbCommand = new OleDbCommand("select count(*) as Record_Count from script_received", vcon);

				dbReader = dbCommand.ExecuteReader();

				if (dbReader.Read() == true)
				    setrowCount(dbReader["Record_Count"].toString());
				else
				return;

				String date = .Now.toString("MM/dd/yyyy");


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
						OleDbCommand command = new OleDbCommand("INSERT INTO script_returned (script, qty, emp_id, received_Date) VALUES (@script,@qty,@emp_Id,@rec_date)");
						try /*JAVA: was using*/
						{
							command.CommandType = CommandType.Text;
							command.Parameters.Add("@script", OleDbType.Integer).Value = textBox1.Text;
							command.Parameters.Add("@qty", OleDbType.VarChar).Value = textBox2.Text;
							command.Parameters.Add("@emp_id", OleDbType.VarChar).Value = textBox3.Text;
							command.Parameters.Add("@rec_date", OleDbType.Date).Value = date;
							command.Connection = vcon;

							//vcon.Open();

							command.ExecuteNonQuery();
						}
						finally { if (command != null) command.close(); }
						//OleDbCommand command = new OleDbCommand(sql, vcon);
						//command.ExecuteNonQuery();
						//command.Dispose();
						this.textBox1.Clear();
						this.textBox2.Clear();
						this.textBox1.Focus();
					}
				}
			}
		}

	
	

