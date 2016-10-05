namespace AgileDevelopmentToolsSuite
{
	partial class ChatForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Users = new System.Windows.Forms.ListBox();
			this.Rank = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Window;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(595, 368);
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 387);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 54);
			this.button1.TabIndex = 1;
			this.button1.Text = "Send";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 405);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(386, 20);
			this.textBox1.TabIndex = 2;
			// 
			// Users
			// 
			this.Users.FormattingEnabled = true;
			this.Users.Location = new System.Drawing.Point(525, 387);
			this.Users.Name = "Users";
			this.Users.Size = new System.Drawing.Size(82, 95);
			this.Users.TabIndex = 3;
			// 
			// Rank
			// 
			this.Rank.FormattingEnabled = true;
			this.Rank.Location = new System.Drawing.Point(485, 387);
			this.Rank.Name = "Rank";
			this.Rank.Size = new System.Drawing.Size(38, 95);
			this.Rank.TabIndex = 4;
			// 
			// ChatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(619, 514);
			this.Controls.Add(this.Rank);
			this.Controls.Add(this.Users);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Name = "ChatForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.ChatForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox Users;
		private System.Windows.Forms.ListBox Rank;
	}
}