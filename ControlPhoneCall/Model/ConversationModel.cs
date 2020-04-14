using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ControlPhoneCall.Controllers;
using System.Windows.Forms;

namespace ControlPhoneCall.Model
{
	class ConversationModel
	{
		public int? IDCity { get; set; }
		public int? IDSubscriber { get; set; }
		public int? CountMinutes { get; set; }

		public double? PriceConverstation { get; set; }

		public DateTime date = DateTime.Now;

		
		
		

		public ConversationModel(string id, string idSubscr, decimal countMin, string rDay, string rNight)
		{
			IDCity = ValidateController.ConvertStringToInt(id);
			IDSubscriber = ValidateController.ConvertStringToInt(idSubscr);
			CountMinutes = Convert.ToInt32(countMin);
			PriceConverstation = CalculationPriceMinutes(rDay, rNight, countMin);
		}

		

		private double? CalculationPriceMinutes(string rDay, string rNight,decimal countMIn)
		{
			if(ValidateController.validateItem(rDay) && ValidateController.validateItem(rNight))
			{
				if(date.TimeOfDay.Hours > 12)
					return Convert.ToDouble(rDay) * Convert.ToDouble(countMIn);
				else
					return Convert.ToDouble(rNight) * Convert.ToDouble(countMIn);
			}
			return null;
		}

		public bool validate(Label city, Label subscriber, Label minutes)
		{
			bool result = ValidateController.validateItem(IDCity.ToString(),city) 
				&& ValidateController.validateItem(IDSubscriber.ToString(),subscriber)
				&& ValidateController.validateItem(CountMinutes.ToString(),minutes)
				&& ValidateController.validateItem(PriceConverstation.ToString());
			return result;
		}
	}
}
