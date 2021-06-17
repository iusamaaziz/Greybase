using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class SideMenuItemDesignModel : SideMenuItemViewModel
	{

		public static SideMenuItemDesignModel Instance => new SideMenuItemDesignModel();

		public SideMenuItemDesignModel()
		{
			Name = "Dashboard";
			IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png";
		}
	}
}
