namespace StringLength
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.labelStringLength = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.AcceptsReturn = true;
			this.textBoxInput.AcceptsTab = true;
			this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInput.Location = new System.Drawing.Point(2, 2);
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(260, 156);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
			// 
			// labelStringLength
			// 
			this.labelStringLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelStringLength.Location = new System.Drawing.Point(3, 166);
			this.labelStringLength.Name = "labelStringLength";
			this.labelStringLength.Size = new System.Drawing.Size(259, 13);
			this.labelStringLength.TabIndex = 1;
			this.labelStringLength.Text = "String Length: ";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 185);
			this.Controls.Add(this.labelStringLength);
			this.Controls.Add(this.textBoxInput);
			this.Name = "FormMain";
			this.Text = "StringLength - by Patware";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label labelStringLength;
	}
}

