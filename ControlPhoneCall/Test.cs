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
	public partial class Test : Form
	{
		BindingSource bs = new BindingSource();
		public Test()
		{
			InitializeComponent();
			this.bs = this.cityBindingSource;
		}
		

		private void Test_Load(object sender, EventArgs e)
		{
			

		}
	}
}
