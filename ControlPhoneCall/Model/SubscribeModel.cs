using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				validateItem("sdfsdf");
				if(validateWithoutLabel(value) && trimUnnecessary(value).Length == 12)
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
				if (validateWithoutLabel(value) && trimUnnecessary(value).Length == 12)
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
				if (validateWithoutLabel(value))
					address = value;
			}
		}

		public bool validate(Label labelMob,Label labelInn,Label labelAddress)
		{
			bool result = validateItem(MobilePhone,labelMob) && validateItem(INN,labelInn) && validateItem(Address,labelAddress); 
			return result;
		}

		private bool validateItem(string item,Label label)
		{
			if(!validateWithoutLabel(item))
			{
				label.Show();
				return false;
			}

			label.Hide();
			return true;
		}

		private bool validateItem(string item)
		{
			return true;
		}

		private bool validateWithoutLabel(string item)
		{
			if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
				return false;

			return true;
		}

		private string trimUnnecessary(string item)
		{
			item = item.Replace("(", "")
						.Replace(")", "")
						.Replace("-", "")
						.Replace(" ", "")
						.Trim();
			return item;
		}
	}
}
