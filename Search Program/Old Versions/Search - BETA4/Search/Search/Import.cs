using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Configuration;
using System.Data.OleDb;
using PrintDataGrid;

namespace csvToGrid
	{
		public partial class Import : Form
			{
				public Import()
					{
						InitializeComponent();
					}
				public void button1_Click(object sender, EventArgs e)
					{
						DataSet dataset;
						string delimiter = ",";
						string tablename = "medTable";
						dataset = new DataSet();
						OpenFileDialog openFileDialog1 = new OpenFileDialog();
						openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
						openFileDialog1.FilterIndex = 1;
						if (openFileDialog1.ShowDialog() == DialogResult.OK)
							{
								if (MessageBox.Show("Are you sure you want to import the data from \n " + openFileDialog1.FileName + "? \n " + " After importing data, please review all data before sending it to the database. ", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
									{
										filename = openFileDialog1.FileName;
										StreamReader sr = new StreamReader(filename);
										string csv = File.ReadAllText(openFileDialog1.FileName);
										dataset.Tables.Add(tablename);
										dataset.Tables[tablename].Columns.Add("Prescription");
										dataset.Tables[tablename].Columns.Add("Customer_Name");
										dataset.Tables[tablename].Columns.Add("Medication");
										dataset.Tables[tablename].Columns.Add("Quantity");
										dataset.Tables[tablename].Columns.Add("Date_Filled");

										string allData = sr.ReadToEnd();
										string[] rows = allData.Split("\r".ToCharArray());

										foreach (string r in rows)
											{
												string[] items = r.Split(delimiter.ToCharArray());
												dataset.Tables[tablename].Rows.Add(items);
											}
										this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
										//MessageBox.Show("File was successfully imported.", "Success!", MessageBoxButtons.OK);
										if (MessageBox.Show("Does the correct data appear to be imported?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
											{
												//DataSet dataset;
												string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Search\\KinneyDatabase.accdb"; //Persist Security Info=True";
												for (int i = 0; i < dataGridView1.Rows.Count; i++)
													{
														//string StrQuery = @"INSERT INTO script_Orders (" + "'script', " + "'cust_Name') VALUES (" + dataGridView1.Rows[i].Cells["Prescription"].Value + ", " + dataGridView1.Rows[i].Cells["Customer_Name"].Value + ");";
														string StrQuery = String.Format("INSERT INTO script_Orders (script,cust_Name,drug,qty,fill_Date) VALUES ('{0}','{1}','{2}','{3}',#{4}#)", dataGridView1.Rows[i].Cells["Prescription"].Value, dataGridView1.Rows[i].Cells["Customer_Name"].Value, dataGridView1.Rows[i].Cells["Medication"].Value, dataGridView1.Rows[i].Cells["Quantity"].Value, dataGridView1.Rows[i].Cells["Date_Filled"].Value);
														try
															{
																using (OleDbConnection conn = new OleDbConnection(ConnString))
																{
																	using (OleDbCommand comm = new OleDbCommand(StrQuery, conn))
																	{
																		conn.Open();
																		comm.ExecuteNonQuery();
																		conn.Close();
																	}
																}
															}
														catch (Exception ex)
															{
																MessageBox.Show(ex.Message + "\n" + "\n" + "Please ignore this error as we try to resolve it.", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
															}
													}
											}
										else
											{
												this.dataGridView1.DataSource = null; 
												this.Refresh();
												button1_Click(sender, e);
											}
									}
							}
					}

				public string filename { get; set; }


				private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
					{

					}

				private void Import_Load(object sender, EventArgs e)
					{

					}

				private void button4_Click(object sender, EventArgs e)
					{
						Application.Exit();

					}

				private void button2_Click(object sender, EventArgs e)
					{
						this.Close();
					}

				private void button3_Click(object sender, EventArgs e)
					{
						string ConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Search\\KinneyDatabase.accdb"; //Persist Security Info=True";
						for (int i = 0; i < dataGridView1.Rows.Count; i++)
							{
								string StrQuery = String.Format("INSERT INTO script_Orders (script,cust_Name,drug,qty,fill_Date) VALUES ('{0}','{1}','{2}','{3}',#{4}#)", dataGridView1.Rows[i].Cells["Prescription"].Value, dataGridView1.Rows[i].Cells["Customer_Name"].Value, dataGridView1.Rows[i].Cells["Medication"].Value, dataGridView1.Rows[i].Cells["Quantity"].Value, dataGridView1.Rows[i].Cells["Date_Filled"].Value);
								try
									{
										using (OleDbConnection conn = new OleDbConnection(ConnString))
											{
												using (OleDbCommand comm = new OleDbCommand(StrQuery, conn))
													{
														conn.Open();
														comm.ExecuteNonQuery();
														conn.Close();
													}
											}
									}
								catch (Exception ex)
									{
										MessageBox.Show(ex.Message + "\n" +"\n" + "Please ignore this error as we try to resolve it."  , "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
							}
					}

				private void button5_Click(object sender, EventArgs e)
					{
						// Calling DataGridView Printing
						PrintDGV.Print_DataGridView(dataGridView1);
					}
		
				private void button6_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select script AS Prescription,cust_Name AS [Customer Name],drug AS Medication,qty AS Quantity,fill_Date AS [Date Filled] from script_Orders", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

				private void textBox1_TextChanged(object sender, EventArgs e)
					{
						try
							{
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
								DataTable dt = new DataTable();
								OleDbDataAdapter OdbA = new OleDbDataAdapter("Select script AS Prescription,cust_Name AS [Customer Name],drug AS Medication,qty AS Quantity,fill_Date AS [Date Filled] from script_Orders WHERE script LIKE '%" + textBox1.Text.ToString() + "%'", OdbConn);
								OdbA.Fill(dt);
								dataGridView1.DataSource = dt;
							}
						catch (Exception c)
							{
								throw (c);

							}
						Console.WriteLine("Exception caught!");
					}

				private void textBox2_TextChanged(object sender, EventArgs e)
					{
						try
							{
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
								DataTable dt = new DataTable();
								OleDbDataAdapter OdbA = new OleDbDataAdapter("Select script AS Prescription,cust_Name AS [Customer Name],drug AS Medication,qty AS Quantity,fill_Date AS [Date Filled] from script_Orders WHERE cust_Name LIKE '%" + textBox2.Text.ToString() + "%'", OdbConn);
								OdbA.Fill(dt);
								dataGridView1.DataSource = dt;
							}
						catch (Exception c)
							{
								throw (c);

							}
						Console.WriteLine("Exception caught!");
					}

				private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select script AS Prescription,cust_Name AS [Customer Name],drug AS Medication,qty AS Quantity,fill_Date AS [Date Filled] from script_Orders WHERE fill_Date LIKE " + "#" + dateTimePicker1.Text + "#", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}
			}
	}
