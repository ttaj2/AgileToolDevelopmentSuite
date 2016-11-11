using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectMangerForm projForm = new ProjectMangerForm();
            projForm.Show();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			HostForm hostForm = new HostForm();
			hostForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			ConnectForm connectForm = new ConnectForm();
			connectForm.Show();
		}

		private void WelcomeForm_Load(object sender, EventArgs e)
		{

		}
	}
}
