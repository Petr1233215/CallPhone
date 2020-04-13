using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPhoneCall.Controllers;

namespace ControlPhoneCall.Model
{
	class SubscribeModel
	{
		private string mobilePhone;
		private string inn;
		private string address;


		public SubscribeModel(string mobile,string inn,string address)
		{
			MobilePhone = mobile;
			INN = inn;
			Address = address;
		}
		public string MobilePhone
		{
			get
			{
				return mobilePhone;
			}
			set
			{
				if(ValidateController.validateItem(value) && ValidateController.trimUnnecessary(value).Length == 12)
					mobilePhone = value;
			}
		}
		public string INN
		{
			get
			{
				return inn;
			}
			set
			{
				if (ValidateController.validateItem(value) && ValidateController.trimUnnecessary(value).Length == 12)
					inn = value;
			}
		}
		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				if (ValidateController.validateItem(value))
					address = value;
			}
		}

		public bool validate(Label labelMob,Label labelInn,Label labelAddress)
		{
			bool result = ValidateController.validateItem(MobilePhone,labelMob) && ValidateController.validateItem(INN,labelInn) && ValidateController.validateItem(Address,labelAddress); 
			return result;
		}
	}
}
