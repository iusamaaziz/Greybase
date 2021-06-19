using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyBase
{
	public class SideMenuListDesignModel : SideMenuListViewModel
	{
		public static SideMenuListDesignModel Instance => new SideMenuListDesignModel();

		public SideMenuListDesignModel()
		{
			Items = new List<SideMenuItemViewModel>
			{
				new SideMenuItemViewModel
				{
					Name = "Dashboard",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = true
				},
				new SideMenuItemViewModel
				{
					Name = "Greyhounds",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_dog_park_100px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Races",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_report_file_128px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Trainers",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Import Files",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Greyhounds",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_dog_park_100px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Races",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_report_file_128px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Trainers",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Import Files",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Greyhounds",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_dog_park_100px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Races",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_report_file_128px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Trainers",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = false
				},
				new SideMenuItemViewModel
				{
					Name = "Import Files",
					IconPath = "pack://application:,,,/GreyBase;component/Images/Icons/icons8_home_60px.png",
					IsActive = false
				}
			};
		}

	}
}
