using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
	public partial class Form1 : Form
	{
		CrossPlatform sys = new CrossPlatform();

		public Form1()
		{
			InitializeComponent();

			this.Resize += new EventHandler (this.form_resize);

			// check system
			if (sys.IsARM ()) {
				this.Height = Screen.PrimaryScreen.Bounds.Height;
				this.Width = Screen.PrimaryScreen.Bounds.Width;
			}
		}

		void form_resize (object sender, EventArgs e)
		{
			// made it react
			this.button1.Width = this.Width - 30;
			this.button1.Location = 
				new System.Drawing.Point(8, ( this.Height - this.button1.Height - 50 ));
		}

		void button1_Click (object sender, MouseEventArgs me) 
		{
			if (me.Clicks > 1)
				this.label1.Text = "This is a double click";
			else
				this.label1.Text = "Hello World From Docker with X";
		}
	}
}
