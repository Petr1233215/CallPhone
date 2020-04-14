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
using ControlPhoneCall.Controllers;


namespace ControlPhoneCall
{
	public partial class Conversation : Form
	{
		public Conversation()
		{
			InitializeComponent();
		}
		string con = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=PhoneCall; Integrated Security=true";
		SqlConnection sqlConnection;
		ConversationModel conversationModel;
		string commandString;
		SqlCommand command;
		DataTable tableConversation;
		SqlDataAdapter adapter;

		private void Conversation_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'phoneCallDataSet24.City' table. You can move, or remove it, as needed.
			this.cityTableAdapter2.Fill(this.phoneCallDataSet24.City);
			// TODO: This line of code loads data into the 'phoneCallDataSet23.City' table. You can move, or remove it, as needed.
			this.cityTableAdapter1.Fill(this.phoneCallDataSet23.City);
			// TODO: This line of code loads data into the 'phoneCallDataSet22.Subscribers' table. You can move, or remove it, as needed.
			this.subscribersTableAdapter1.Fill(this.phoneCallDataSet22.Subscribers);
			// TODO: This line of code loads data into the 'phoneCallDataSet21.City' table. You can move, or remove it, as needed.
			this.cityTableAdapter.Fill(this.phoneCallDataSet21.City);
			// TODO: This line of code loads data into the 'phoneCallDataSet20.Subscribers' table. You can move, or remove it, as needed.
			this.subscribersTableAdapter.Fill(this.phoneCallDataSet20.Subscribers);
			// TODO: This line of code loads data into the 'phoneCallDataSet12.Conversation' table. You can move, or remove it, as needed.
			commandString = @"SELECT        Conversation.IdConversation, Conversation.IdSubScriber, Conversation.IdCity, Conversation.Date, Conversation.CountMinutes, 
						Conversation.TimesOfDay, Conversation.PriceConverstation, Subscribers.NumberPhone, 
									 City.NameCity, City.RateDay, City.RateNigth, Subscribers.INN, Subscribers.Address
						FROM            City INNER JOIN
												 Conversation ON City.IdCity = Conversation.IdCity INNER JOIN
												 Subscribers ON Conversation.IdSubScriber = Subscribers.IdSubscriber";

			sqlConnection = new SqlConnection(con);

			try
			{
				sqlConnection.Open();
			}
			catch (Exception)
			{

				throw;
			}


			command = new SqlCommand(commandString,sqlConnection);

			tableConversation = new DataTable();
			adapter = new SqlDataAdapter(command);

			adapter.Fill(tableConversation);
			dataGridView1.DataSource = tableConversation;

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			conversationModel = new ConversationModel(
					comboBoxIdCity.Text,
					comboBoxIdSubscriber.Text,
					textBoxMinute.Value,
					comboBoxRDay.Text,
					comboBoxRDay.Text
			);

			if (conversationModel.validate(errorCity, errorSubscribe, errorMinute))
			{
				commandString = $@"
						INSERT INTO [dbo].[Conversation]
							   ([IdSubScriber]
							   ,[IdCity]
							   ,[Date]
							   ,[CountMinutes]
							   ,[TimesOfDay]
							   ,[PriceConverstation])
						 VALUES
							   (
								'{conversationModel.IDSubscriber}',
								'{conversationModel.IDCity}',
								'{conversationModel.date.ToShortDateString()}',
								'{conversationModel.CountMinutes}',
								'{conversationModel.date.ToShortTimeString()}',
								'{conversationModel.PriceConverstation}'
								)";

				sqlConnection = new SqlConnection(con);
				try
				{
					sqlConnection.Open();
				}
				catch (Exception)
				{

					MessageBox.Show("Не удалось подключиться");
				}
				command = new SqlCommand(commandString, sqlConnection);
				command.ExecuteNonQuery();
				sqlConnection.Close();

				DataTable DT = dataGridView1.DataSource as DataTable;
				DT.Clear();
				adapter.Fill(tableConversation);


				ValidateController.CleanerNumeric(textBoxMinute);
			}
			else
			{
				MessageBox.Show("Заполните данные");
			}
		}

		private void ComboBoxSubscriber_TextChanged(object sender, EventArgs e)
		{
			comboBoxIdSubscriber.SelectedIndex = comboBoxSubscriber.SelectedIndex;
		}

		private void ComboBoxCity_TextChanged(object sender, EventArgs e)
		{
			int indexCity = comboBoxCity.SelectedIndex;
			comboBoxIdCity.SelectedIndex = indexCity;
			comboBoxRDay.SelectedIndex = indexCity;
			comboBoxRNight.SelectedIndex = indexCity;
		}
	}
}
