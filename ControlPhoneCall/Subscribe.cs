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
using ControlPhoneCall.Model;
using ControlPhoneCall.Controllers;

namespace ControlPhoneCall
{
	public partial class Subscribe : Form
	{
		public Subscribe()
		{
			InitializeComponent();
		}
		
		string con = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=PhoneCall; Integrated Security=true";
		string commandString;
		SqlConnection sqlConnection;
		SqlCommand command;
		SubscribeModel subscribeModel;




		private void Subscribe_Load(object sender, EventArgs e)
		{
			idSubscriber.Text = "";
			// TODO: This line of code loads data into the 'phoneCallDataSet15.Subscribers' table. You can move, or remove it, as needed.
			this.subscribersTableAdapter2.Fill(this.phoneCallDataSet15.Subscribers);
			//this.phoneCallDataSet.Subscribers.To

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			subscribeModel = new SubscribeModel(textBoxNumber.Text, textBoxInn.Text, textBoxAddress.Text);
			if (subscribeModel.validate(errorNumber, errorINN, errorAddress))
			{
				Cursor.Current = Cursors.WaitCursor;
				sqlConnection = new SqlConnection(con);
				if (ValidateController.validateItem(idSubscriber.Text))
				{
					commandString = $@"UPDATE [dbo].[Subscribers]
								   SET [NumberPhone] = '{subscribeModel.MobilePhone}'
									  ,[INN] = '{subscribeModel.INN}'
									  ,[Address] = '{subscribeModel.Address}'
								 WHERE IdSubscriber = '{idSubscriber.Text}'";
				}
				else
				{
					commandString = $@"INSERT INTO [dbo].[Subscribers]
						   ([NumberPhone]
						   ,[INN]
						   ,[Address])
					 VALUES(
						    '{subscribeModel.MobilePhone}',
							'{subscribeModel.INN}',
							'{subscribeModel.Address}')";
				}

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
				this.subscribersTableAdapter2.Fill(this.phoneCallDataSet15.Subscribers);

				idSubscriber.Text = "";
				ValidateController.CleanerTextBox(textBoxAddress,textBoxInn,textBoxNumber);
				Cursor.Current = Cursors.Default;
			}
			else
			{
				MessageBox.Show("Заполните данные");
			}


			
			
		}

		private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			
			try
			{
				if(e.ColumnIndex == 2)
				{
					MessageBox.Show("В данном столбце допускается только 12 символов, в виде цифр");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("sdfsdf");
			}
		}

		

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			idSubscriber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBoxInn.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBoxNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (ValidateController.validateItem(idSubscriber.Text))
			{
				sqlConnection = new SqlConnection(con);
				commandString = $@"DELETE FROM [dbo].[Subscribers]
									WHERE IdSubscriber = '{idSubscriber.Text}'";
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
				this.subscribersTableAdapter2.Fill(this.phoneCallDataSet15.Subscribers);

				idSubscriber.Text = "";
				ValidateController.CleanerTextBox(textBoxAddress, textBoxInn, textBoxNumber);
				Cursor.Current = Cursors.Default;
			}
			else
			{
				MessageBox.Show("Выберите строку для удаления");
			}
		}
	}


	
}
