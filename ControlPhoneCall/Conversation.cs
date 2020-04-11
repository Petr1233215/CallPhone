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
			this.conversationTableAdapter.Fill(this.phoneCallDataSet12.Conversation);

			var phoneCall = this.phoneCallDataSet12.Conversation.Select(elem => elem.IdCity).ToList();


			List<ConversationModel> conversationModel = this.phoneCallDataSet12.Conversation.Select(element => new ConversationModel{idCity = element.IdCity,countMinutes = element.CountMinutes}).ToList();

			

			foreach(var phone in phoneCall)
			{
				label5.Text += $"{phone} ";
			}
			string commandString = @"SELECT   Conversation.IdConversation, Conversation.IdSubScriber, Conversation.IdCity, Conversation.Date, Conversation.CountMinutes, Conversation.TimesOfDay, City.NameCity
							FROM Conversation INNER JOIN City ON Conversation.IdCity = City.IdCity";
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
			dataGridView2.DataSource = tableConversation;

			dataGridView3.DataSource = 
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
