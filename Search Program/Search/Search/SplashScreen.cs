using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace csvToGrid
{
	public partial class SplashScreen : Form
	{
		//private string p;

		public SplashScreen()
		{
			InitializeComponent();
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
