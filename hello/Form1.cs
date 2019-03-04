using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace castello.test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void button1_Click (object sender, EventArgs e) 
		{
			this.label1.Text = "Hello World From Docker with X";
		}
	}
}
