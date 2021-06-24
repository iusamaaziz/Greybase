using GreyBase.DataModels;
using System.Collections.Generic;
using System.Windows.Input;
using System;

namespace GreyBase
{
	public class SideMenuItemViewModel : BaseViewModel
	{
		public string Name { get; set; }

		public string IconPath { get; set; }

		public bool IsActive { get; set; } = false;


		#region Public Commands

		/// <summary>
		/// Opens the current message thread
		/// </summary>
		public ICommand OpenPageCommand { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public SideMenuItemViewModel()
		{
			// Create commands
			OpenPageCommand = new RelayCommand(OpenPage);
		}

		#endregion

		#region Command Methods

		public void OpenPage()
		{
			switch (Name)
			{
				case "Dashboard":
					IoC.Application.GoToPage(ApplicationPage.Dashboard);
					break;
				case "Race Results":
					IoC.Application.GoToPage(ApplicationPage.RaceResult);
					break;
				case "Race Cards":
					IoC.Application.GoToPage(ApplicationPage.RaceCard);
					break;
				case "Import Files":
					IoC.Application.GoToPage(ApplicationPage.Import);
					break;
				case "Greyhounds":
					IoC.Application.GoToPage(ApplicationPage.Greyhound);
					break;
				default:
					IsActive = false;
					break;
			}
			IsActive = true;

		}

		#endregion

	}
}
