using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringLength
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void textBoxInput_TextChanged(object sender, EventArgs e)
		{
			this.labelStringLength.Text = string.Format("String Length: {0}", this.textBoxInput.Text.Length);
			
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			this.textBoxInput.Text = "Enter Text Here";
		}
	}
}