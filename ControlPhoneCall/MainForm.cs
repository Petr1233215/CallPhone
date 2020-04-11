using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPhoneCall
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Subscribe subscribe = new Subscribe();
			subscribe.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Conversation conversation = new Conversation();
			conversation.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			City city = new City();
			city.Show();
		}
	}
}
