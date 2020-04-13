using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPhoneCall.Controllers;
using System.Windows.Forms;

namespace ControlPhoneCall.Model
{
	class CityModel
	{
		private string cityName;


		public CityModel(string city,decimal rDay,decimal rNight,decimal discount)
		{
			CityName = city;
			Discount = Convert.ToInt32(discount);
			RateDay = rDay - (rDay * discount) / 100.0m;
			RateNight = rNight - (rNight * discount) / 100.0m;
		}

		public string CityName
		{
			get => cityName;
			set
			{
				if (ValidateController.validateItem(value))
					cityName = value;
			}
		}
		
		public decimal RateDay { get; set; }

		public decimal RateNight { get; set; }

		public int Discount { get; set; }


		public bool validate(Label labelCity, Label labelRDay, Label labelRNight)
		{
			bool result =ValidateController.validateItem(CityName,labelCity);
			return result;
		}


	}
}
