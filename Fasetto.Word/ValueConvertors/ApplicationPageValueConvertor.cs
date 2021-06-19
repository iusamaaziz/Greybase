using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GreyBase.DataModels;

namespace GreyBase
{
	/// <summary>
	/// Converts the <see cref="ApplicationPage"/> to an actual view/page
	/// </summary>
	public class ApplicationPageValueConvertor : BaseValueConvertor<ApplicationPageValueConvertor>
	{
		public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			switch ((ApplicationPage)value)
			{
				default:
					Debugger.Break();
					return null;
				case ApplicationPage.Dashboard:
					return new DashboardPage();
			}
		}

		public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
