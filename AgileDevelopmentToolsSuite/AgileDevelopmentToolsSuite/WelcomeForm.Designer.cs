namespace AgileDevelopmentToolsSuite
{
    partial class WelcomeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
			this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.welcomeLabel.ForeColor = System.Drawing.Color.White;
			this.welcomeLabel.Location = new System.Drawing.Point(310, 20);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(171, 29);
			this.welcomeLabel.TabIndex = 0;
			this.welcomeLabel.Text = "Welcome to the";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(210, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Click the button below to get started.";
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.Gray;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.Color.White;
			this.startButton.Location = new System.Drawing.Point(367, 210);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(94, 30);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(356, 317);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Chat test - Host";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(356, 356);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Chat test - Connect";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.welcomeLabel);
			this.Name = "WelcomeForm";
			this.Text = "Agile Development Tools Suite";
			this.Load += new System.EventHandler(this.WelcomeForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}