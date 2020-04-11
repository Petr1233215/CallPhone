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

namespace ControlPhoneCall
{
	public partial class Subscribe : Form
	{
		public Subscribe()
		{
			InitializeComponent();
		}

		
		string con = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=PhoneCall; Integrated Security=true";
		SqlConnection sqlConnection;
		SqlCommand command;



		private void Subscribe_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'phoneCallDataSet14.Subscribers' table. You can move, or remove it, as needed.
			this.subscribersTableAdapter1.Fill(this.phoneCallDataSet14.Subscribers);
			// TODO: This line of code loads data into the 'phoneCallDataSet.Subscribers' table. You can move, or remove it, as needed.
			//this.phoneCallDataSet.Subscribers.To

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			

			string commandString = $@"INSERT INTO [dbo].[Subscribers]
						   ([NumberPhone]
						   ,[INN]
						   ,[Address])
					 VALUES(
						   {textBoxCity.Text},
							{textBoxCity.Text},
							{textBoxCity.Text}

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

			command = new SqlCommand(commandString,sqlConnection);

			command.ExecuteNonQuery();


			try
			{
				this.subscribersTableAdapter1.Fill(this.phoneCallDataSet14.Subscribers);
				//subscribersBindingSource1.EndEdit();

				//subscribersTableAdapter1.Update(this.phoneCallDataSet14.Subscribers);

			}
			catch (Exception ex)
			{
				MessageBox.Show("sdfsdf");
			}
			Cursor.Current = Cursors.Default;
			
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

		private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			
			
		}

		private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			
			
		}
	}
}
