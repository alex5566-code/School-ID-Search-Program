using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csvToGrid
	{
		public partial class StartForm : Form
			{
			public StartForm()
				{
					InitializeComponent();
				}

			private void StartForm_Load(object sender, EventArgs e)
				{

				}

			private void button1_Click(object sender, EventArgs e)
				{
					new Receive().Show();
				}

			private void button2_Click(object sender, EventArgs e)
				{
					new search_Received().Show();
				}

			private void pictureBox2_Click(object sender, EventArgs e)
				{
					new SplashScreen().Show();
				}

			private void button4_Click(object sender, EventArgs e)
				{
					Application.Exit();
				}

			private void button3_Click(object sender, EventArgs e)
				{
					new Return().Show();
				}

			private void button5_Click(object sender, EventArgs e)
			{
				new search_Returned().Show();
			}

			private void button6_Click(object sender, EventArgs e)
			{
				new search_Unordered().Show();
			}

			private void button8_Click(object sender, EventArgs e)
			{
				new Import().Show();
			}

			}
	}
