using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Collections;
using ControlPhoneCall.Model;


namespace ControlPhoneCall
{
	public partial class Conversation : Form
	{
		public Conversation()
		{
			InitializeComponent();
		}

		private void Conversation_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'phoneCallDataSet12.Conversation' table. You can move, or remove it, as needed.
			string commandString = @"SELECT        Conversation.IdConversation, Conversation.IdSubScriber, Conversation.IdCity, Conversation.Date, Conversation.CountMinutes, 
						Conversation.TimesOfDay, Conversation.PriceConverstation, Subscribers.NumberPhone, 
									 City.NameCity, City.RateDay, City.RateNigth, Subscribers.INN, Subscribers.Address
						FROM            City INNER JOIN
												 Conversation ON City.IdCity = Conversation.IdCity INNER JOIN
												 Subscribers ON Conversation.IdSubScriber = Subscribers.IdSubscriber";
			string con = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=PhoneCall; Integrated Security=true";
			
			SqlConnection sqlConnection = new SqlConnection(con);
			try
			{
				sqlConnection.Open();
			}
			catch (Exception)
			{

				throw;
			}


			SqlCommand command = new SqlCommand(commandString,sqlConnection);

			DataTable tableConversation = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command);

			adapter.Fill(tableConversation);
			dataGridView1.DataSource = tableConversation;

			MessageBox.Show(tableConversation.Rows[0][0].ToString());
		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}
	}
}
