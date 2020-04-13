using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPhoneCall.Model;
using ControlPhoneCall.Controllers;
using System.Data.SqlClient;

namespace ControlPhoneCall
{
	public partial class City : Form
	{
		CityModel cityModel;
		string con = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=PhoneCall; Integrated Security=true";
		string commandString;
		SqlConnection sqlConnection;
		SqlCommand command;
		

		public City()
		{
			InitializeComponent();
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
		}

		private void City_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'phoneCallDataSet19.City' table. You can move, or remove it, as needed.
			this.cityTableAdapter.Fill(this.phoneCallDataSet19.City);
			labelIDCity.Text = "";
		}


		private void Button1_Click(object sender, EventArgs e)
		{
			cityModel = new CityModel(textBoxCity.Text, numericRateDay.Value, numericRateNight.Value, numericDiscount.Value);
			if (cityModel.validate(errorCity, errorRDay, errorRNight))
			{
				Cursor.Current = Cursors.WaitCursor;
				sqlConnection = new SqlConnection(con);

				if (ValidateController.validateItem(labelIDCity.Text))
				{
					commandString = $@"UPDATE [dbo].[City]
								   SET [NameCity] = '{cityModel.CityName}'
									  ,[RateDay] = '{cityModel.RateDay}'
									  ,[RateNigth] = '{cityModel.RateNight}'
									  ,[Discount] = '{cityModel.Discount}'
								   WHERE IdCity = '{labelIDCity.Text}'";
				}
				else
				{
					commandString = $@"INSERT INTO [dbo].[City]
							   ([NameCity]
							   ,[RateDay]
							   ,[RateNigth]
							   ,[Discount])
					 VALUES(
						    '{cityModel.CityName}',
							'{cityModel.RateDay.ToString()}',
							'{cityModel.RateNight}',
							'{cityModel.Discount}')";
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
				this.cityTableAdapter.Fill(this.phoneCallDataSet19.City);


				labelIDCity.Text = "";
				ValidateController.CleanerTextBox(textBoxCity);
				ValidateController.CleanerNumeric(numericDiscount, numericRateDay, numericRateNight);

			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (ValidateController.validateItem(labelIDCity.Text))
			{
				sqlConnection = new SqlConnection(con);
				commandString = $@"DELETE FROM [dbo].[City]
									WHERE IdCity = '{labelIDCity.Text}'";
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
				this.cityTableAdapter.Fill(this.phoneCallDataSet19.City);


				labelIDCity.Text = "";
				ValidateController.CleanerTextBox(textBoxCity);
				ValidateController.CleanerNumeric(numericDiscount, numericRateDay, numericRateNight);
			}
			else
			{
				MessageBox.Show("Выберите строку для удаления");
			}
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			labelIDCity.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBoxCity.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			numericRateDay.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
			numericRateNight.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
			numericDiscount.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
		}

	}
}
