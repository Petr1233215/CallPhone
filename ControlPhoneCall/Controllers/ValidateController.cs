using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPhoneCall.Controllers
{
	class ValidateController
	{
		
		public static bool validateItem(string item, Label label)
		{
			if (!validateItem(item))
			{
				label.Show();
				return false;
			}

			label.Hide();
			return true;
		}

		public static bool validateItem(int? item,Label label)
		{
			if(item == null)
			{
				label.Show();
				return false;
			}
			label.Hide();
			return true;
		}


		public static bool validateItem(string item)
		{
			if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
				return false;

			return true;
		}



		public static string trimUnnecessary(string item)
		{
			item = item.Replace("(", "")
						.Replace(")", "")
						.Replace("-", "")
						.Replace(" ", "")
						.Trim();
			return item;
		}

		public static void CleanerTextBox(params TextBoxBase[] texts)
		{
			foreach(TextBoxBase text in texts)
			{
				text.Text = "";
			}
		}

		public static void CleanerNumeric(params NumericUpDown[] nums)
		{
			foreach(NumericUpDown num in nums)
			{
				num.Value = 0;
			}
		}

		public static int? ConvertMaskToInt(string item)
		{
			string s = trimUnnecessary(item);
			if (validateItem(s))
				return Convert.ToInt32(s);
			return null;
		}
	}
}
