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
		public partial class search_Received : Form
			{
				public search_Received()
					{
						InitializeComponent();
						this.dataGridView1.Columns[0].Visible = false;
					}

				//private void Form2_Load(object sender, EventArgs e)
				//    {

				//    }

				private void button1_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						dataGridView1.DataSource = dt;


					}

				private void button2_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from query_All_Received", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

				private void button3_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("SELECT TOP 9 * from query_All_Received ORDER BY Date_Received DESC", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}
				
				private void button4_Click(object sender, EventArgs e)
					{
						Application.Exit();
					}

				private void button7_Click(object sender, EventArgs e)
					{
						this.Close();
						new Receive().Show();
					}

				private void textBox3_TextChanged(object sender, EventArgs e)
					{
						try
							{
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
								DataTable dt = new DataTable();
								
								dataGridView1.DataSource = dt;
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
								OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
								DataTable dt = new DataTable();
								dataGridView1.DataSource = dt;
							}
						catch (Exception c)
							{
								throw (c);
								
							}
								Console.WriteLine("Exception caught!");
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

				private void button6_Click(object sender, EventArgs e)
					{
						this.Close();
						new Return().Show();
					}

				private void pictureBox1_Click(object sender, EventArgs e)
					{
						this.Hide();
						new SplashScreen().Show();
					}

				private void button9_Click(object sender, EventArgs e)
					{
						this.Close();
						new search_Unordered().Show();
					}

				private void button10_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("Select * from query_Total_All_Received", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

				private void button11_Click(object sender, EventArgs e)
					{
						OleDbConnection OdbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Search\KinneyDatabase.accdb");
						DataTable dt = new DataTable();
						OleDbDataAdapter OdbA = new OleDbDataAdapter("SELECT TOP 10 * from query_Total_All_Received ORDER BY Date_Received DESC", OdbConn);
						OdbA.Fill(dt);
						dataGridView1.DataSource = dt;
					}

        private void search_Received_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinneyDatabaseDataSet.script_Orders' table. You can move, or remove it, as needed.
            this.script_OrdersTableAdapter.Fill(this.kinneyDatabaseDataSet.script_Orders);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
			buttonDelete.PerformClick();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
			buttonAddNew.PerformClick();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cust_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void cust_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drugLabel_Click(object sender, EventArgs e)
        {

        }

        private void fill_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
			// TODO

			try
			{
				string msg = "Do you want to permanently delete the selected records?";
				string caption = "Delete Data";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				MessageBoxIcon ico = MessageBoxIcon.Question;

				DialogResult result;

				result = MessageBox.Show(this, msg, caption, buttons, ico);

				if (result == DialogResult.Yes)
				{
					// Delete
					this.script_OrdersBindingSource.RemoveCurrent();

					// Saves the changes
					this.script_OrdersBindingSource.EndEdit();
					this.script_OrdersTableAdapter.Update(this.kinneyDatabaseDataSet.script_Orders);

					// Refresh data
					this.script_OrdersTableAdapter.Fill(this.kinneyDatabaseDataSet.script_Orders);

					MessageBox.Show("The record has been deleted.", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					return;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Delete data failed : " + ex.Message.ToString(), "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}

        private void buttonSave_Click(object sender, EventArgs e)
        {
			// TODO 

			try
            {
				string msg = "Do you want to save | update the selected record?";
				string caption = "Save | Update";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				MessageBoxIcon ico = MessageBoxIcon.Question;

				DialogResult result;

				result = MessageBox.Show(this, msg, caption, buttons, ico);

				if (result == DialogResult.Yes)
                {
					// Save | Update
					this.script_OrdersBindingSource.EndEdit();
					this.script_OrdersTableAdapter.Update(this.kinneyDatabaseDataSet.script_Orders);

					// Refresh data
					this.script_OrdersTableAdapter.Fill(this.kinneyDatabaseDataSet.script_Orders);

					MessageBox.Show("The record has been saved successfully.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
                {
					return;
                }
					
            }
			catch (Exception ex)
            {
				MessageBox.Show("Save | Update data failed : " + ex.Message.ToString(), "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
			this.script_OrdersBindingSource.MoveNext();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {

			this.script_OrdersBindingSource.AddNew();

		}

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
			this.script_OrdersBindingSource.MovePrevious();
        }

        private void search_Received_FormClosing(object sender, FormClosingEventArgs e)
        {
			string msg = "Do you want to exit the application?";
			string caption = "Exit Application";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			MessageBoxIcon ico = MessageBoxIcon.Question;

			DialogResult result;

			result = MessageBox.Show(this, msg, caption, buttons, ico);

			if (result == DialogResult.Yes)
            {
				// Closes the form.
				// MessageBox.Show("Goodbye, fellow user.", "",
				// MessageBoxButtons.OK, MessageBoxIcon.Information);
			    e.Cancel = false;
            }
			else
            {
				e.Cancel = true;
            }
        }

        private void toolStripButtonUpdateItem_Click(object sender, EventArgs e)
        {
			buttonSave.PerformClick();
        }

       

        private void toolStripButtonRefresh_Click_1(object sender, EventArgs e)
        {
			search_Received_Load(sender, e);
		}

        private void scriptTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void scriptLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearImagebutton_Click(object sender, EventArgs e)
        {
			try
            {
				this.photoPictureBox.Image = null;
            }
            catch
            {

            }
        }

        private void ChooseImageButton_Click(object sender, EventArgs e)
        {
			try
            {
				OpenFileDialog ofd = new OpenFileDialog();

				string myPictures = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

				ofd.Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Images|*.png|BMP Images|*.bmp|" + "All files (*.*)|*.*";
				ofd.FileName = "Image file name";
				ofd.Title = "Choose an image...";
				ofd.AddExtension = true;
				ofd.FilterIndex = 0;
				ofd.Multiselect = false;
				ofd.ValidateNames = true;
				ofd.InitialDirectory = myPictures;
				ofd.RestoreDirectory = true;

				if (ofd.ShowDialog() == DialogResult.OK)
                {
					this.photoPictureBox.Image = Image.FromFile(ofd.FileName);
                }
				else
                {
					return;
                }
            }
            catch
            {
				MessageBox.Show("Error : Something went wrong.", "Choose Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
	}

