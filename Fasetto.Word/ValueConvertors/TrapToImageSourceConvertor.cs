using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace GreyBase
{
	public class TrapToImageSourceConvertor : BaseValueConvertor<TrapToImageSourceConvertor>
	{
		public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			try
			{
				return Application.Current.FindResource(value as string);
			}
			catch (Exception)
			{
				return Application.Current.FindResource("NotFountIcon");
			}
		}

		public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
